Imports System.IO
Imports System.Reflection
Imports System.Text.Json
Imports System.Text.RegularExpressions

Public Class Configuration

    Public Shared Sub Read()
        ' Application folder
        Dim appFolder As String = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location)
        ' Configuration file = app folder / config.json
        Dim configFile As String = Path.Combine(appFolder, "config.json")
        ' Read with System.Text.Json
        Dim json As String = File.ReadAllText(configFile)
        Dim config = JsonSerializer.Deserialize(Of Configuration)(json)
        json = Nothing

        If config.IgnoredFolders Is Nothing Then
            config.IgnoredFolders = New String() {}
        End If

        Dim folders = New List(Of String)()
        For Each path As String In config.IgnoredFolders
            If (path.StartsWith("**/")) Then
                Dim subr = path.Substring(3)
                folders.Add(ToRegex(subr))
                folders.Add(".*\\" + ToRegex(subr))
            Else
                folders.Add(ToRegex(path))
            End If
        Next
        config.IgnoredFolders = folders.ToArray()
        inst = config
    End Sub

    Public Shared Function ToRegex(path As String) As String
        path = Regex.Replace(path, "([.+\[\]\\\(\)])", "\$1")
        path = Regex.Replace(path, "/", "\")
        path = path.Replace("*", "[^/\\]*")
        path = path.Replace("?", ".")
        Return "^" + path + "$"
    End Function

    Private Shared inst As Configuration = Nothing
    Public Shared ReadOnly Property Instance As Configuration
        Get
            If inst Is Nothing Then Read()
            Return inst
        End Get
    End Property

    Public Property IgnoredFolders As String()
    Public Shared Root As DirectoryInfo

    Public Shared Function IsIgnoredFolder(folder As String) As Boolean
        Return Instance.IgnoredFolders.Any(Function(x) Regex.IsMatch(folder, x))
    End Function

End Class
