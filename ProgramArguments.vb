Imports CommandLine

Public Class ProgramArguments

    ' Option: --RegisterContextMenu
    <[Option]("r"c, "RegisterContextMenu", Required:=False, HelpText:="Enregistre le menu contextuel pour copier les fichiers")>
    Public Property RegisterContextMenu As Boolean = False

    ' Option: --UnregisterContextMenu
    <[Option]("u"c, "UnregisterContextMenu", Required:=False, HelpText:="Désenregistre le menu contextuel pour copier les fichiers")>
    Public Property UnregisterContextMenu As Boolean = False

    Public Shared Function GetLongArgument(propertyName As String) As String
        Return CType(GetType(ProgramArguments).GetProperty(propertyName).GetCustomAttributes(GetType([OptionAttribute]), False)(0), OptionAttribute).LongName
    End Function

End Class
