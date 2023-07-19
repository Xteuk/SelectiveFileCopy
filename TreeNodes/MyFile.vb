Imports System.IO.Compression
Imports FileInfo = System.IO.FileInfo

Public Class MyFile
    Inherits OnOff

    Private fileInfo As FileInfo

    Public Overrides ReadOnly Property IsLeaf As Boolean
        Get
            Return True
        End Get
    End Property

    Public Sub New(ByVal file As IO.FileInfo)
        MyBase.New(file.Length, file.Length)
        Me.fileInfo = file
        MyBase.Text = Me.Name
    End Sub

    Public ReadOnly Property File As FileInfo
        Get
            Return fileInfo
        End Get
    End Property

    Public ReadOnly Property Name As String
        Get
            Return File.Name
        End Get
    End Property

    Public ReadOnly Property Extension As String
        Get
            Return File.Extension
        End Get
    End Property

    Public ReadOnly Property Length As Long
        Get
            Return IIf(SelectedSize = 0, RealSize, SelectedSize)
        End Get
    End Property

    Public Overrides Property Selected As CheckState ' TriState
        Get
            Return MyBase.Selected
        End Get
        Set(value As CheckState)
            'If value = TriState.UseDefault Then Return
            MyBase.Selected = value
        End Set
    End Property

    Public ReadOnly Property Type As String
        Get
            Return "File"
        End Get
    End Property

    Public Sub CopyTo(ByVal destination As IO.DirectoryInfo, listener As ICopyListener)
        If Selected = Windows.Forms.CheckState.Unchecked Then Exit Sub
        Dim newFile As New IO.FileInfo(IO.Path.Combine(destination.FullName, Name))
        listener.OnCopying(File, newFile)
        Try
            If newFile.Exists() Then
                If listener.OnFileExists(newFile) = False Then Return
            End If
            File.CopyTo(newFile.FullName, True)
            listener.OnCopied(File, newFile)
        Finally
        End Try
    End Sub

    Public Sub CopyTo(ByVal zip As ZipArchive, path As String, listener As ICopyListener)
        If Selected = Windows.Forms.CheckState.Unchecked Then Exit Sub
        Dim newFile As New IO.FileInfo(IO.Path.Combine(path, Name))
        listener.OnCopying(File, newFile)
        Try
            'If newFile.Exists() Then
            '    If listener.OnFileExists(newFile) Then Return
            'End If
            'File.CopyTo(newFile.FullName, True)
            Dim entry As ZipArchiveEntry = zip.CreateEntryFromFile(File.FullName, IO.Path.Combine(path, File.Name), CompressionLevel.Optimal)
            listener.OnCopied(File, newFile)
        Finally
        End Try
    End Sub

    Public Overrides Property Count As Integer
        Get
            Return 1
        End Get
        Set(value As Integer)
            ' nothing
        End Set
    End Property

    Public Overrides ReadOnly Property DisplayedCount As String
        Get
            Return ""
        End Get
    End Property

End Class
