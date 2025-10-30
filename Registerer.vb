
Imports System.Collections.Concurrent
Imports Aga.Controls.Tree

Public Class Registerer

    Public ByTypes As New TreeModel
    Public ByNames As New TreeModel
    Public Folders As New TreeModel

    Private mapByTypes As New ConcurrentDictionary(Of String, SigmaOnOff)(StringComparer.OrdinalIgnoreCase)
    Private mapByName As New ConcurrentDictionary(Of String, SigmaOnOff)(StringComparer.OrdinalIgnoreCase)
    Private mapByFolder As New ConcurrentDictionary(Of String, SigmaOnOff)(StringComparer.OrdinalIgnoreCase)

    Public Sub PostProcess()
        mapByTypes = New ConcurrentDictionary(Of String, SigmaOnOff)(StringComparer.OrdinalIgnoreCase)
        mapByName = New ConcurrentDictionary(Of String, SigmaOnOff)(StringComparer.OrdinalIgnoreCase)
        mapByFolder = New ConcurrentDictionary(Of String, SigmaOnOff)(StringComparer.OrdinalIgnoreCase)

    End Sub

    Private myForm As MainWindow
    Public Sub New(form As MainWindow)
        myForm = form
    End Sub

    Public lastUpdate As DateTime = DateTime.Now

    Public Function getNode(ByVal parent As TreeModel, ByVal name As String) As SigmaOnOff
        'Dim node As SigmaOnOff = parent.Nodes.Where(Function(x) x.Text = name).FirstOrDefault()
        Dim dict As ConcurrentDictionary(Of String, SigmaOnOff)
        If parent Is ByTypes Then
            dict = mapByTypes
        ElseIf parent Is ByNames Then
            dict = mapByName
        ElseIf parent Is Folders Then
            dict = mapByFolder
        Else
            Return Nothing
        End If
        Dim node As SigmaOnOff = Nothing
        If dict.TryGetValue(name, node) Then Return node

        If node Is Nothing Then
            node = New SigmaOnOff() With {.Text = name}
            parent.Nodes.Add(node)
            dict.TryAdd(name, node)
        End If
        Return node
    End Function

    Public Sub register(ByVal node As MyFile)
        Dim ext As SigmaOnOff = getNode(ByTypes, node.Extension.ToLower)
        ext.Add(node, False)

        Dim name As SigmaOnOff = getNode(ByNames, node.Name.ToLower)
        name.Add(node, False)
        num_files += 1
    End Sub

    Public Sub register(ByVal node As MyFolder)
        Dim name As SigmaOnOff = getNode(Folders, node.Name.ToLower)
        name.Add(node, False)
        num_folders += 1
    End Sub

    Private num_files As Long = 0
    Private num_folders As Long = 0
    Public ReadOnly Property NumFiles As Long
        Get
            Return num_files
        End Get
    End Property

    Public ReadOnly Property NumFolders As Long
        Get
            Return num_folders
        End Get
    End Property

End Class
