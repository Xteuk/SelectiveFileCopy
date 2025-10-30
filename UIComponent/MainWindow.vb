Imports System.IO
Imports System.IO.Compression
Imports Aga.Controls.Tree

Public Class MainWindow
    Implements ICopyListener

    Private contentModel As TreeModel
    Private registerer As New Registerer(Me)
    Private Configuration As Configuration = Nothing

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'registerer.UpdateFunction = AddressOf RequestTreesUpdate
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        FoldersTreeView.Model = New SortedTreeModel(registerer.Folders)
        ByTypesTreeView.Model = New SortedTreeModel(registerer.ByTypes)
        'ByNamesTreeView.Model = New SortedTreeModel(registerer.ByNames)

        CurrentStep = Steps.FolderSelection

        'Me.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        Me.Icon = My.Resources.iconfinder_move_to_folder_64482
        TabControl1.SelectedIndex = 1

        My.Settings.Upgrade()
        Configuration.PreProcess()

    End Sub

    Private Sub ThreadedLoadDir()
        Try
            NoTreeUpdate = True
            LoadUpdateTimer.Start()
            Chrono = Stopwatch.StartNew()

            CType(MainTreeView.Model, SortedTreeModel).Comparer = New SizeComparer(False)
            CType(FoldersTreeView.Model, SortedTreeModel).Comparer = New SizeComparer(False)
            CType(ByTypesTreeView.Model, SortedTreeModel).Comparer = New SizeComparer(False)
            'CType(ByNamesTreeView.Model, SortedTreeModel).Comparer = comparerOn

            Try
                Configuration.Root = rootDir
                Dim my_root As MyFolder = New MyFolder(rootDir)
                contentModel.Root.Nodes.Add(my_root)
                MainTreeView.AllNodes.First().Expand()

                my_root.LoadInfos(registerer)
                registerer.PostProcess()
            Finally
            End Try

            NoTreeUpdate = False

            BeginInvoke(Sub() OnFinishedLoading())
        Catch ex As Exception
        Finally
            LoadUpdateTimer.Stop()
            Chrono.Stop()
            Chrono = Nothing
        End Try
    End Sub

    Private Function RequestTreesUpdate() As Integer

        If NoTreeUpdate Then Return 0
        Try
            Dim ev As New TreePathEventArgs()

            contentModel.OnStructureChanged(ev)
            registerer.Folders.OnStructureChanged(ev)
            registerer.ByTypes.OnStructureChanged(ev)

        Catch ex As Exception
        End Try

        Return 0
    End Function

#Region "TreeView Columns resizing"
    Private Sub ResizeColumnsTree1(sender As TreeViewAdv)
        Dim first As TreeColumn = sender.Columns.Where(Function(x) x.Index = 0).First()
        Dim others As Integer = sender.Columns.Where(Function(x) x.IsVisible And x.Index > 0).Sum(Function(x) x.Width)
        'first.Width = sender.Width - others - 30
    End Sub

    Private Sub ResizeColumnsTree2()
        Dim cols As TreeColumn() = FoldersTreeView.Columns.Where(Function(x) x.IsVisible = True).ToArray()
        For Each col As TreeColumn In cols
            col.Width = (FoldersTreeView.Width - 30) / cols.Count
        Next
    End Sub

    Private Sub TreeViewAdv1_ColumnWidthChanged(sender As System.Object, e As Aga.Controls.Tree.TreeColumnEventArgs) _
    Handles MainTreeView.ColumnWidthChanged, FoldersTreeView.ColumnWidthChanged
        Dim tree As TreeViewAdv = sender
        If e.Column.Index = 0 Then Return
        ResizeColumnsTree1(sender)
    End Sub

    Private Sub TreeViewAdv1_SizeChanged(sender As System.Object, e As System.EventArgs) _
    Handles MainTreeView.SizeChanged, FoldersTreeView.SizeChanged
        ResizeColumnsTree1(sender)
    End Sub

#End Region

#Region "Context Menu"
    Private Sub TreeViewAdv1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) _
    Handles MainTreeView.MouseClick
        Dim tree As TreeViewAdv = sender
        Dim node As TreeNodeAdv = tree.GetNodeAt(tree.PointToClient(MousePosition))
        'tree.SelectedNode = node
        If node Is Nothing Then
            'tree.SelectedNode = Nothing
            Return
        End If
        DeselectAllByExtensionToolStripMenuItem.Enabled = Not TypeOf (node.Tag) Is MyFolder
        SelectAllByExtensionToolStripMenuItem.Enabled = Not TypeOf (node.Tag) Is MyFolder
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition)
        End If

        RequestTreesUpdate()
    End Sub

    Private Sub OtherTrees_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) _
    Handles ByTypesTreeView.MouseClick, FoldersTreeView.MouseClick ', ByNamesTreeView.MouseClick
        Dim tree As TreeViewAdv = sender
        Dim node As TreeNodeAdv = tree.GetNodeAt(tree.PointToClient(MousePosition))
        tree.SelectedNode = node
        If node Is Nothing Then Return

        RequestTreesUpdate()
    End Sub

    Private Sub DoSelectAllByExtension(ByVal check As CheckState)
        Dim treenode As TreeNodeAdv = MainTreeView.SelectedNode
        If Not TypeOf (treenode.Tag) Is MyFile Then Return
        Dim node As MyFile = treenode.Tag
        registerer.getNode(registerer.ByTypes, node.Extension).Selected = check

        RequestTreesUpdate()
    End Sub

    Private Sub SelectAllByExtensionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
    Handles SelectAllByExtensionToolStripMenuItem.Click
        DoSelectAllByExtension(CheckState.Checked)
    End Sub

    Private Sub DeselectAllByExtensionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
    Handles DeselectAllByExtensionToolStripMenuItem.Click
        DoSelectAllByExtension(CheckState.Unchecked)
    End Sub

    Private Sub DoSelectAllByName(ByVal check As CheckState)
        Dim treenode As TreeNodeAdv = MainTreeView.SelectedNode
        If treenode Is Nothing Then Return
        If TypeOf (treenode.Tag) Is MyFile Then
            Dim node As MyFile = treenode.Tag
            registerer.getNode(registerer.ByTypes, node.Name).Selected = check
        ElseIf TypeOf (treenode.Tag) Is MyFolder Then
            Dim node As MyFolder = treenode.Tag
            registerer.getNode(registerer.Folders, node.Name).Selected = check
        End If

        RequestTreesUpdate()
    End Sub

    Private Sub DeselectAllByNameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
    Handles DeselectAllByNameToolStripMenuItem.Click
        DoSelectAllByName(CheckState.Unchecked)
    End Sub

    Private Sub SelectAllByNameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) _
    Handles SelectAllByNameToolStripMenuItem.Click
        DoSelectAllByName(CheckState.Checked)
    End Sub
#End Region

#Region "InputDir Loading"

    Private loaded As Boolean = False
    Private NoTreeUpdate As Boolean = False
    Private lastUpdate As DateTime = DateTime.Now
    Private rootDir As IO.DirectoryInfo = Nothing
    Private threadLoadDir As Threading.Thread = Nothing
    Private Sub LoadDir(ByVal dir As IO.DirectoryInfo)
        CurrentStep = Steps.Loading

        rootDir = dir
        contentModel = New TreeModel
        MainTreeView.Model = New SortedTreeModel(contentModel)

        If threadLoadDir IsNot Nothing Then
            If threadLoadDir.IsAlive Then threadLoadDir.Abort()
        End If

        registerer.Folders.Nodes.Clear()
        registerer.ByTypes.Nodes.Clear()
        'registerer.ByNames.Nodes.Clear()

        MainTreeView.Enabled = False
        FoldersTreeView.Enabled = False
        ByTypesTreeView.Enabled = False
        'ByNamesTreeView.Enabled = False
        StatusLabel.Text = "Loading..."
        threadLoadDir = New Threading.Thread(AddressOf ThreadedLoadDir)
        threadLoadDir.Start()

    End Sub

    Private Sub OnFinishedLoading()
        threadLoadDir = Nothing
        MainTreeView.Enabled = True
        FoldersTreeView.Enabled = True
        ByTypesTreeView.Enabled = True
        'ByNamesTreeView.Enabled = True
        StatusLabel.Text = "Ready."
        RequestTreesUpdate()
        CurrentStep = Steps.ElementsSelection
        MainTreeView.Select()
    End Sub

#End Region

#Region "File Copy Process"
    Private Sub ThreadedCopy()
        Try
            Dim parent As MyFolder = contentModel.Root.Nodes(0)
            Select Case DestinationType
                Case DestinationTypes.Folder
                    Dim destination As New IO.DirectoryInfo(DestinationPath)
                    parent.CopyTo(destination.Parent, Me, destination.Name, True)

                Case DestinationTypes.ZipFile
                    If File.Exists(DestinationPath) Then File.Delete(DestinationPath)
                    Dim zip As ZipArchive = ZipFile.Open(DestinationPath, ZipArchiveMode.Create)
                    parent.CopyTo(zip, "", Me)
                    zip.Dispose()

            End Select

            BeginInvoke(Sub() OnCopyFinished())
        Catch ex As Exception
        End Try
    End Sub

    Private Sub StartCopy()

        Dim parent As MyFolder = contentModel.Root.Nodes(0)

        Me.overwrite_default_choice = SelectiveFileCopy.OnFileExists.Choice.Overwrite
        nb_file_copied = 0
        numberProgress.Value = 0
        numberProgress.Maximum = parent.CountSelected + 1
        sizeProgress.Value = 0
        pb1_ratio = parent.Size.selectedSize / 1000
        sizeProgress.Maximum = 1000

        CurrentStep = Steps.Running
        UpdateUI()

    End Sub

    Private Sub OnCopyFinished()
        numberProgress.Value = numberProgress.Maximum
        sizeProgress.Value = sizeProgress.Maximum
        StatusText = "Ready."
        threadRunning = Nothing

        CurrentStep = Steps.ElementsSelection
        UpdateUI()

        MsgBox(String.Format("{0} file copied.", nb_file_copied), MsgBoxStyle.Information)

    End Sub

    Private nb_file_copied As Integer = 0
    Public Sub OnCopied(ByVal orig As IO.FileSystemInfo, ByVal new_path As IO.FileSystemInfo) _
    Implements ICopyListener.OnCopied
        If InvokeRequired Then
            BeginInvoke(Sub() OnCopied(orig, new_path))
        Else
            If TypeOf orig Is DirectoryInfo Then StatusText = new_path.FullName
            If TypeOf orig Is IO.FileInfo Then
                nb_file_copied += 1
                Dim value As Integer = sizeProgress.Value
                value += CType(orig, IO.FileInfo).Length / pb1_ratio
                If value >= sizeProgress.Maximum Then
                    sizeProgress.Value = sizeProgress.Maximum
                Else
                    sizeProgress.Value = value
                End If
                sizeProgress.Update()
            End If
        End If
    End Sub

    Public Sub OnCopying(ByVal orig As IO.FileSystemInfo, ByVal new_path As IO.FileSystemInfo) _
    Implements ICopyListener.OnCopying
        If InvokeRequired Then
            BeginInvoke(Sub() OnCopying(orig, new_path))
        Else
            numberProgress.Value += 1
            numberProgress.Update()
        End If
    End Sub

    Public Sub OnCopyFailed(ByVal orig As IO.FileSystemInfo, ByVal new_path As IO.FileSystemInfo, ex As Exception) _
    Implements ICopyListener.OnCopyFailed

    End Sub

    Delegate Function DelegateTypeOnFileExists(path As IO.FileSystemInfo) As Boolean
    Private DelegateOnFileExists As New DelegateTypeOnFileExists(AddressOf OnFileExists)
    Private overwrite_default_choice As OnFileExists.Choice = SelectiveFileCopy.OnFileExists.Choice.Overwrite

    Public Function OnFileExists(path As IO.FileSystemInfo) _
    As Boolean _
    Implements ICopyListener.OnFileExists
        If overwrite_default_choice = SelectiveFileCopy.OnFileExists.Choice.AlwaysOverwrite Then Return True
        If overwrite_default_choice = SelectiveFileCopy.OnFileExists.Choice.NeverOverwrite Then Return False
        If InvokeRequired Then
            Return Invoke(DelegateOnFileExists, path)
        Else
            Dim diag As New OnFileExists()
            diag.Message = path.FullName & ":" & vbCrLf & "  File exist already."
            diag.ShowDialog(Me)
            Select Case diag.Selection
                Case SelectiveFileCopy.OnFileExists.Choice.Overwrite
                    Return True
                Case SelectiveFileCopy.OnFileExists.Choice.AlwaysOverwrite
                    overwrite_default_choice = SelectiveFileCopy.OnFileExists.Choice.AlwaysOverwrite
                    Return True
                Case SelectiveFileCopy.OnFileExists.Choice.DontOverwrite
                    Return False
                Case SelectiveFileCopy.OnFileExists.Choice.NeverOverwrite
                    overwrite_default_choice = SelectiveFileCopy.OnFileExists.Choice.NeverOverwrite
                    Return False
                Case SelectiveFileCopy.OnFileExists.Choice.StopEverything
                    Throw New Exception("Copy cancelled by user.")
            End Select

            Return True
        End If
    End Function

#End Region

#Region "UI Properties"

    Private _currentStep As Steps = Steps.FolderSelection
    Private Property CurrentStep As Steps
        Get
            Return _currentStep
        End Get
        Set(value As Steps)
            _currentStep = value
            If InvokeRequired Then
                BeginInvoke(Sub() CurrentStep = value)
            Else
                UpdateUI()
            End If
        End Set
    End Property

    Private Property DestinationPath As String
        Get
            Return destinationPathTBX.Text
        End Get
        Set(value As String)
            destinationPathTBX.Text = value
        End Set
    End Property

    Public Property DestinationType As DestinationTypes = GetDefaultDestinationType()

    Private Function GetDefaultDestinationType() As DestinationTypes
        Try
            Return [Enum].Parse(GetType(DestinationTypes), My.Settings.LatestDestinationType)
        Catch ex As Exception
            Return DestinationTypes.ZipFile
        End Try
    End Function

    Public Property StatusText As String
        Get
            Return StatusLabel.Text
        End Get
        Set(value As String)
            If InvokeRequired Then
                BeginInvoke(Sub() StatusLabel.Text = value)
            Else
                StatusLabel.Text = value
            End If
        End Set
    End Property

#End Region

#Region "UI Events"

    ' This function manages all Hide/Show or Enable/Disable steps of the UI components
    Private Sub UpdateUI()
        BottomPanel3.Visible = CurrentStep = Steps.ElementsSelection Or CurrentStep = Steps.Running

        MainTreeView.Enabled = Not CurrentStep = Steps.Running
        FoldersTreeView.Enabled = Not CurrentStep = Steps.Running
        ByTypesTreeView.Enabled = Not CurrentStep = Steps.Running
        destinationPathTBX.Enabled = Not CurrentStep = Steps.Running

        ToolStrip1.Enabled = Not CurrentStep = Steps.Running
        MenuStrip1.Enabled = Not CurrentStep = Steps.Running

        RunMI.Enabled = Not String.IsNullOrEmpty(DestinationPath) And Not String.IsNullOrEmpty(InputDirPath)
        RunTS.Enabled = RunMI.Enabled

        Me.Update()
    End Sub

    Private InputDirPath As String
    Private Sub Form1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If loaded Then Return
        TreeViewAdv1_ColumnWidthChanged(MainTreeView, New Aga.Controls.Tree.TreeColumnEventArgs(MainTreeView.Columns(1)))
        TreeViewAdv1_ColumnWidthChanged(FoldersTreeView, New Aga.Controls.Tree.TreeColumnEventArgs(FoldersTreeView.Columns(1)))
        loaded = True
        If My.Application.CommandLineArgs.Count > 0 Then
            InputDirPath = My.Application.CommandLineArgs(0)
            LoadDir(New IO.DirectoryInfo(InputDirPath))
        End If
        For i As Integer = 1 To My.Application.CommandLineArgs.Count - 1
            Dim arg As String = My.Application.CommandLineArgs(i)
            If arg.StartsWith("-to=") Then destinationPathTBX.Text = arg.Substring(4)

        Next
        ''LoadDir(New IO.DirectoryInfo("c:\temp"))
        'TextBox2.Text = "c:\temp2"
    End Sub

    Private Sub OnSelectSourceClick(sender As System.Object, e As System.EventArgs) _
    Handles ToolStripButton1.Click, SelectSourceToolStripMenuItem.Click
        Dim browser As New FolderBrowser2
        Dim defaultPath = InputDirPath
        If String.IsNullOrEmpty(InputDirPath) Then
            defaultPath = My.Settings.LatestSource
        End If
        If InputDirPath <> "" And IO.Directory.Exists(InputDirPath) Then
            browser.DirectoryPath = InputDirPath
        End If
        If browser.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            InputDirPath = browser.DirectoryPath
            Dim dir As New IO.DirectoryInfo(InputDirPath)
            If dir.Exists Then LoadDir(dir)
        End If
    End Sub

    Private pb1_ratio As Double = 1
    Private threadRunning As Threading.Thread = Nothing
    Private Sub OnStartCopyClick(sender As System.Object, e As System.EventArgs) Handles RunTS.Click, RunMI.Click
        My.Settings.LatestDestinationType = DestinationType.ToString()
        My.Settings.LatestDestination = DestinationPath
        My.Settings.LatestSource = InputDirPath
        StartCopy()
        threadRunning = New Threading.Thread(AddressOf ThreadedCopy)
        threadRunning.Start()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If threadLoadDir IsNot Nothing Then
            If threadLoadDir.IsAlive Then threadLoadDir.Abort()
        End If
        If threadRunning IsNot Nothing Then
            If threadRunning.IsAlive() Then threadRunning.Abort()
        End If
    End Sub

    Private Chrono As Stopwatch = Nothing
    Private Sub LoadUpdateTimer_Tick(sender As Object, e As EventArgs) Handles LoadUpdateTimer.Tick

        If registerer.NumFiles = 0 Then
            ProgressLabel2.Text = ""
        Else
            If Chrono Is Nothing Then Chrono = Stopwatch.StartNew()
            Dim elapsed = Chrono.Elapsed.ToString("hh\:mm\:ss")
            Dim mean = Chrono.ElapsedMilliseconds / registerer.NumFiles
            ProgressLabel2.Text = String.Format("{0:N0} files, {1:N0} folders. Elapsed: {2}. Mean: {3}ms", registerer.NumFiles, registerer.NumFolders, elapsed, mean)
        End If

    End Sub

    Private dirDestBrowseDLG As New FolderBrowser2()
    Private Sub OpenSelectFileDialog()

        Select Case DestinationType
            Case DestinationTypes.Folder
                dirDestBrowseDLG.DirectoryPath = DestinationPath
                If String.IsNullOrEmpty(DestinationPath) Then
                    dirDestBrowseDLG.DirectoryPath = My.Settings.LatestDestination
                End If
                If dirDestBrowseDLG.ShowDialog(Me) = DialogResult.OK Then
                    DestinationPath = dirDestBrowseDLG.DirectoryPath
                End If
            Case DestinationTypes.ZipFile
                fileDestBrowseDLG.FileName = DestinationPath
                If String.IsNullOrEmpty(DestinationPath) Then
                    fileDestBrowseDLG.FileName = My.Settings.LatestDestination
                End If
                If fileDestBrowseDLG.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    DestinationPath = fileDestBrowseDLG.FileName
                End If
        End Select

    End Sub

    ''' <summary>
    ''' Automated selection when mouse hovers over a node
    ''' (disabled)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainTreeView_MouseMove(sender As Object, e As MouseEventArgs) _
    Handles MainTreeView.MouseMove, ByTypesTreeView.MouseMove, FoldersTreeView.MouseMove
        Dim treeView = CType(sender, TreeViewAdv)
        Dim node = treeView.GetNodeAt(e.Location)
        treeView.SelectedNode = node
    End Sub

    Private Sub MainTreeView_ColumnClicked(sender As Object, e As TreeColumnEventArgs) _
    Handles MainTreeView.ColumnClicked, FoldersTreeView.ColumnClicked, ByTypesTreeView.ColumnClicked

        If e.Column.Sortable = False Then Return

        Dim treeView = CType(sender, TreeViewAdv)
        Dim model = CType(treeView.Model, SortedTreeModel)

        Select Case e.Column.SortOrder
            Case SortOrder.Ascending
                e.Column.SortOrder = SortOrder.Descending
            Case SortOrder.Descending
                e.Column.SortOrder = SortOrder.Ascending
            Case SortOrder.None
                e.Column.SortOrder = SortOrder.Ascending
        End Select

        If e.Column Is MainSize Or e.Column Is FoldersSize Or e.Column Is ByTypesSize Then
            model.Comparer = New SizeComparer(False) With {.SortOrder = e.Column.SortOrder}
        ElseIf e.Column Is MainPath Or e.Column Is FoldersGroup Or e.Column Is ByTypesGroup Then
            model.Comparer = New NameComparer() With {.SortOrder = e.Column.SortOrder}
        End If
    End Sub

    Private Sub OnSelectDestinationFolderClick(sender As Object, e As EventArgs) Handles SelectDestinationasFolderToolStripMenuItem.Click, ToolStripButton2.Click
        DestinationType = DestinationTypes.Folder
        OpenSelectFileDialog()
        UpdateUI()
    End Sub

    Private Sub OnSelectDestinationZipFileClick(sender As Object, e As EventArgs) Handles SelectDestinationasZipFileToolStripMenuItem.Click, ToolStripButton3.Click
        DestinationType = DestinationTypes.ZipFile
        OpenSelectFileDialog()
        UpdateUI()
    End Sub

    Private OptionsWindow As OptionsWindow = Nothing
    Private Sub OnShowOptionsClick(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If OptionsWindow Is Nothing Then
            OptionsWindow = New OptionsWindow()
        End If
        OptionsWindow.ShowDialog(Me)
    End Sub

#End Region

End Class
