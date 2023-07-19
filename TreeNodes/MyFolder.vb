
Imports System.IO.Compression

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

    'Public Overrides ReadOnly Property Count As Integer
    '    Get
    '        Dim i As Integer = 0
    '        i = Nodes.Cast(Of OnOff).Sum(Function(x) x.Count)
    '        Return i
    '    End Get
    'End Property

    Public Sub LoadInfos(ByVal registerer As Registerer)

        Count = 0

        Try
            'dir.GetDirectories("*", IO.SearchOption.AllDirectories)
            'dir.GetFiles("*", IO.SearchOption.AllDirectories)

            Dim folders = dir.EnumerateDirectories()
            Dim my_folders As New List(Of MyFolder)
            For Each subdir As IO.DirectoryInfo In folders
                Dim my_folder As New MyFolder(subdir)
                Add(my_folder)
                my_folders.Add(my_folder)
            Next

            For Each my_folder As MyFolder In my_folders
                my_folder.LoadInfos(registerer)
                registerer.register(my_folder)
                Count += my_folder.Count
            Next

            Dim files = dir.EnumerateFiles()
            'Count += files.Length
            For Each file As IO.FileInfo In files
                Dim my_file As New MyFile(file)
                'Nodes.Add(my_file)
                Add(my_file)
                Count += 1
                registerer.register(my_file)
            Next
        Catch ex As System.Threading.ThreadAbortException
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
                For Each node As OnOff In MyBase.list
                    If TypeOf (node) Is MyFile Then
                        CType(node, MyFile).CopyTo(destination, path, listener)
                    ElseIf TypeOf (node) Is MyFolder Then
                        CType(node, MyFolder).CopyTo(destination, IO.Path.Combine(path, Name), listener)
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
