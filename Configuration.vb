Imports System.IO
Imports System.Text.RegularExpressions

Public Class Configuration

    Public Shared Sub Save()
        My.Settings.Save()
    End Sub

    Public Shared Property CopyIncludesRootFolder As Boolean
        Get
            Return My.Settings.CopyIncludesRootFolder
        End Get
        Set(value As Boolean)
            My.Settings.CopyIncludesRootFolder = value
        End Set
    End Property

    Public Shared Property IgnoredFolders As String()
        Get
            Return My.Settings.IgnoredFolders.Cast(Of String)().ToArray()
        End Get
        Set(value As String())
            My.Settings.IgnoredFolders.Clear()
            My.Settings.IgnoredFolders.AddRange(value)
        End Set
    End Property

    Private Shared ComputedIgnoredFolders As String()

    Public Shared Root As DirectoryInfo

    Public Shared Function IsIgnoredFolder(folder As String) As Boolean
        If ComputedIgnoredFolders Is Nothing Then
            PreProcess()
        End If
        Return ComputedIgnoredFolders.Any(Function(x) Regex.IsMatch(folder, x))
    End Function

    Public Shared Sub PreProcess()
        Dim folders = New List(Of String)()
        For Each path As String In My.Settings.IgnoredFolders.Cast(Of String)()
            If (path.StartsWith("**/")) Then
                Dim subr = path.Substring(3)
                folders.Add(ToRegex(subr))
                folders.Add(".*\\" + ToRegex(subr))
            Else
                folders.Add(ToRegex(path))
            End If
        Next
        ComputedIgnoredFolders = folders.ToArray()
    End Sub

    Private Shared Function ToRegex(path As String) As String
        path = Regex.Replace(path, "([.+\[\]\\\(\)])", "\$1")
        path = Regex.Replace(path, "/", "\")
        path = path.Replace("*", "[^/\\]*")
        path = path.Replace("?", ".")
        Return "^" + path + "$"
    End Function

End Class
