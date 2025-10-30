
Imports System.Collections.Concurrent
Imports System.IO.Compression
Imports System.Threading.Tasks

Public Class MyFolder
    Inherits SigmaOnOff

    Private dir As IO.DirectoryInfo

    Public Sub New(dir As IO.DirectoryInfo)
        Me.dir = dir
        MyBase.Text = Me.Name
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return dir.Name & "\"
        End Get
    End Property

    Public Sub LoadInfos(ByVal registerer As Registerer)

        Count = 0

        Try
            Dim folders = dir.EnumerateDirectories()
            Dim my_folders As New ConcurrentBag(Of MyFolder)
            For Each subdir As IO.DirectoryInfo In folders
                Dim my_folder As New MyFolder(subdir)
                Add(my_folder)
                my_folders.Add(my_folder)
            Next

            Parallel.ForEach(my_folders,
                Sub(my_folder As MyFolder)
                    my_folder.LoadInfos(registerer)
                    registerer.register(my_folder)
                    Count += my_folder.Count
                End Sub)

            'For Each my_folder As MyFolder In my_folders
            '    my_folder.LoadInfos(registerer)
            '    registerer.register(my_folder)
            '    Count += my_folder.Count
            'Next

            Dim files = dir.EnumerateFiles()

            'Parallel.ForEach(dir.EnumerateFiles,
            '    Sub(file As IO.FileInfo)
            '        Try
            '            Dim my_file As New MyFile(file)
            '            Add(my_file)
            '            Count += 1
            '            registerer.register(my_file)
            '        Catch ex As Exception
            '            Dim m = ex.Message
            '        End Try
            '    End Sub)
            For Each file As IO.FileInfo In files
                Dim my_file As New MyFile(file)
                Add(my_file)
                Count += 1
                registerer.register(my_file)
            Next

            Dim relative = Helper.GetRelativePath(Configuration.Root.FullName, dir.FullName)
            If Configuration.IsIgnoredFolder(relative) Then
                Selected = CheckState.Unchecked
            End If

        Catch ex As Threading.ThreadAbortException
            ' rien
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public ReadOnly Property Type As String
        Get
            Return "Folder"
        End Get
    End Property

    Public Sub CopyTo(ByVal destination As IO.DirectoryInfo, listener As ICopyListener, Optional ByVal newName As String = Nothing, Optional ByVal no_warning As Boolean = False)
        If Selected = Windows.Forms.CheckState.Unchecked Then Exit Sub
        Dim theName As String = IIf(newName Is Nothing, Name, newName)
        Dim newDir As New IO.DirectoryInfo(IO.Path.Combine(destination.FullName, theName))

        listener.OnCopying(dir, newDir)
        Try
            If no_warning = False And newDir.Exists Then
                If Not listener.OnFileExists(newDir) Then Return
            End If
            If Not newDir.Exists Then newDir.Create()
            Try
                For Each node As OnOff In MyBase.list
                    If TypeOf (node) Is MyFile Then
                        CType(node, MyFile).CopyTo(newDir, listener)
                    ElseIf TypeOf (node) Is MyFolder Then
                        CType(node, MyFolder).CopyTo(newDir, listener)
                    End If
                Next
                listener.OnCopied(dir, newDir)
            Catch ex As Exception
                listener.OnCopyFailed(dir, newDir, ex)
            End Try
        Finally
        End Try
    End Sub

    Public Sub CopyTo(ByVal destination As ZipArchive, path As String, listener As ICopyListener, Optional ByVal newName As String = Nothing, Optional ByVal no_warning As Boolean = False)
        If Selected = Windows.Forms.CheckState.Unchecked Then Exit Sub
        Dim theName As String = IIf(newName Is Nothing, Name, newName)
        Dim newDir As New IO.DirectoryInfo(IO.Path.Combine(path, theName))

        listener.OnCopying(dir, newDir)
        Try
            Try
                Dim myPath = IO.Path.Combine(path, Name)
                For Each node As OnOff In MyBase.list
                    If TypeOf (node) Is MyFile Then
                        CType(node, MyFile).CopyTo(destination, myPath, listener)
                    ElseIf TypeOf (node) Is MyFolder Then
                        CType(node, MyFolder).CopyTo(destination, myPath, listener)
                    End If
                Next
                listener.OnCopied(dir, newDir)
            Catch ex As Exception
                listener.OnCopyFailed(dir, newDir, ex)
            End Try
        Finally
        End Try
    End Sub

End Class
