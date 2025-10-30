Imports CommandLine
Imports Microsoft.Win32

Public Class Program

    ' La fonction "Main" lance le formulaire "MainWindow"
    Public Shared Sub Main()

        Dim arguments As ProgramArguments = Nothing
        Dim parser = CommandLine.Parser.Default.ParseArguments(Of ProgramArguments)(Environment.GetCommandLineArgs())
        If parser.Errors.Any(Function(x) x.StopsProcessing) Then
            Return
        End If
        arguments = parser.Value
        If arguments Is Nothing Then arguments = New ProgramArguments()

        If arguments.RegisterContextMenu Then
            RegisterContextMenu()

        ElseIf arguments.UnregisterContextMenu Then

            UnregisterContextMenu()

        Else
            Dim form As New MainWindow
            Application.Run(form)
        End If

    End Sub

    Public Shared Sub RegisterContextMenu()
        Registry.SetValue("HKEY_CLASSES_ROOT\Directory\shell\SelectiveFileCopy", "", "Selective File Copy")
        Registry.SetValue("HKEY_CLASSES_ROOT\Directory\shell\SelectiveFileCopy", "MUIVerb", "Selective File Copy")
        Registry.SetValue("HKEY_CLASSES_ROOT\Directory\shell\SelectiveFileCopy", "Icon", Application.ExecutablePath + ",0")
        Registry.SetValue("HKEY_CLASSES_ROOT\Directory\shell\SelectiveFileCopy\command", "", Application.ExecutablePath + " ""%1""")
    End Sub

    Public Shared Sub UnregisterContextMenu()
        Registry.ClassesRoot.DeleteSubKeyTree("Directory\shell\SelectiveFileCopy")
    End Sub

    Public Shared Function IsContextMenuRegistered() As Boolean
        Return Registry.ClassesRoot.OpenSubKey("Directory\shell\SelectiveFileCopy") IsNot Nothing
    End Function

End Class
