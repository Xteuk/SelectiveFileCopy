<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindowUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeselectAllByExtensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselectAllByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllByExtensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterPanel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MainTreeView = New Aga.Controls.Tree.TreeViewAdv()
        Me.MainPath = New Aga.Controls.Tree.TreeColumn()
        Me.MainExt = New Aga.Controls.Tree.TreeColumn()
        Me.MainSize = New Aga.Controls.Tree.TreeColumn()
        Me.MainX = New Aga.Controls.Tree.TreeColumn()
        Me.MainNb = New Aga.Controls.Tree.TreeColumn()
        Me.StateIcon = New Aga.Controls.Tree.NodeControls.NodeStateIcon()
        Me.TBName = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBExtension = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBSize = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.CBSelection = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.TBNb = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.FoldersTab = New System.Windows.Forms.TabPage()
        Me.FoldersTreeView = New Aga.Controls.Tree.TreeViewAdv()
        Me.FoldersGroup = New Aga.Controls.Tree.TreeColumn()
        Me.FoldersSize = New Aga.Controls.Tree.TreeColumn()
        Me.FoldersX = New Aga.Controls.Tree.TreeColumn()
        Me.NodeTextBox1 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeTextBox2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeCheckBox1 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.ByTypesTab = New System.Windows.Forms.TabPage()
        Me.ByTypesTreeView = New Aga.Controls.Tree.TreeViewAdv()
        Me.ByTypesGroup = New Aga.Controls.Tree.TreeColumn()
        Me.ByTypesSize = New Aga.Controls.Tree.TreeColumn()
        Me.ByTypesX = New Aga.Controls.Tree.TreeColumn()
        Me.NodeTextBox3 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeTextBox4 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeCheckBox2 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.spring = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LoadUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BottomPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numberProgress = New System.Windows.Forms.ProgressBar()
        Me.sizeProgress = New System.Windows.Forms.ProgressBar()
        Me.fileDestBrowseDLG = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyIncludesRootFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseCopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopCopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiledestinationNotSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileAddedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileUpdatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IgnoredFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileIgnoredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FolderdestinationNotSelectedYetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFolderWillBeAddedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IgnoredFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistingFolderWillBeDeletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.DestinationPathTS = New System.Windows.Forms.ToolStripTextBox()
        Me.ByNamesGroup = New Aga.Controls.Tree.TreeColumn()
        Me.ByNamesSize = New Aga.Controls.Tree.TreeColumn()
        Me.ByNamesX = New Aga.Controls.Tree.TreeColumn()
        Me.NodeTextBox5 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeTextBox6 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeCheckBox3 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.TBName2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBSize2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBSelection2 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActionToolStripButton1 = New SelectiveFileCopy.ActionToolStripButton(Me.components)
        Me.SelectInputFolderAction = New SelectiveFileCopy.CustomAction(Me.components)
        Me.ActionToolStripButton2 = New SelectiveFileCopy.ActionToolStripButton(Me.components)
        Me.SelectDestFolderAction = New SelectiveFileCopy.CustomAction(Me.components)
        Me.ActionToolStripButton3 = New SelectiveFileCopy.ActionToolStripButton(Me.components)
        Me.SelectDestZipAction = New SelectiveFileCopy.CustomAction(Me.components)
        Me.ActionToolStripButton4 = New SelectiveFileCopy.ActionToolStripButton(Me.components)
        Me.StartCopyAction = New SelectiveFileCopy.CustomAction(Me.components)
        Me.ActionToolstripMenuItem1 = New SelectiveFileCopy.ActionToolstripMenuItem(Me.components)
        Me.ActionToolstripMenuItem2 = New SelectiveFileCopy.ActionToolstripMenuItem(Me.components)
        Me.ActionToolstripMenuItem3 = New SelectiveFileCopy.ActionToolstripMenuItem(Me.components)
        Me.ActionToolstripMenuItem4 = New SelectiveFileCopy.ActionToolstripMenuItem(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.CenterPanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.FoldersTab.SuspendLayout()
        Me.ByTypesTab.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.BottomPanel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeselectAllByExtensionToolStripMenuItem, Me.DeselectAllByNameToolStripMenuItem, Me.SelectAllByExtensionToolStripMenuItem, Me.SelectAllByNameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 100)
        '
        'DeselectAllByExtensionToolStripMenuItem
        '
        Me.DeselectAllByExtensionToolStripMenuItem.Name = "DeselectAllByExtensionToolStripMenuItem"
        Me.DeselectAllByExtensionToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.DeselectAllByExtensionToolStripMenuItem.Text = "Deselect all by extension"
        '
        'DeselectAllByNameToolStripMenuItem
        '
        Me.DeselectAllByNameToolStripMenuItem.Name = "DeselectAllByNameToolStripMenuItem"
        Me.DeselectAllByNameToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.DeselectAllByNameToolStripMenuItem.Text = "Deselect all by name"
        '
        'SelectAllByExtensionToolStripMenuItem
        '
        Me.SelectAllByExtensionToolStripMenuItem.Name = "SelectAllByExtensionToolStripMenuItem"
        Me.SelectAllByExtensionToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.SelectAllByExtensionToolStripMenuItem.Text = "Select all by extension"
        '
        'SelectAllByNameToolStripMenuItem
        '
        Me.SelectAllByNameToolStripMenuItem.Name = "SelectAllByNameToolStripMenuItem"
        Me.SelectAllByNameToolStripMenuItem.Size = New System.Drawing.Size(217, 24)
        Me.SelectAllByNameToolStripMenuItem.Text = "Select all by name"
        '
        'CenterPanel
        '
        Me.CenterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CenterPanel.Controls.Add(Me.SplitContainer1)
        Me.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CenterPanel.Location = New System.Drawing.Point(0, 61)
        Me.CenterPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CenterPanel.Name = "CenterPanel"
        Me.CenterPanel.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.CenterPanel.Size = New System.Drawing.Size(1156, 545)
        Me.CenterPanel.TabIndex = 15
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 6)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MainTreeView)
        Me.SplitContainer1.Panel1MinSize = 50
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2MinSize = 50
        Me.SplitContainer1.Size = New System.Drawing.Size(1138, 529)
        Me.SplitContainer1.SplitterDistance = 600
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 2
        '
        'MainTreeView
        '
        Me.MainTreeView.AllowColumnReorder = True
        Me.MainTreeView.BackColor = System.Drawing.SystemColors.Window
        Me.MainTreeView.Columns.Add(Me.MainPath)
        Me.MainTreeView.Columns.Add(Me.MainExt)
        Me.MainTreeView.Columns.Add(Me.MainSize)
        Me.MainTreeView.Columns.Add(Me.MainX)
        Me.MainTreeView.Columns.Add(Me.MainNb)
        Me.MainTreeView.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainTreeView.DefaultToolTipProvider = Nothing
        Me.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTreeView.DragDropMarkColor = System.Drawing.Color.Black
        Me.MainTreeView.FullRowSelect = True
        Me.MainTreeView.LineColor = System.Drawing.SystemColors.ControlDark
        Me.MainTreeView.Location = New System.Drawing.Point(0, 0)
        Me.MainTreeView.Margin = New System.Windows.Forms.Padding(4)
        Me.MainTreeView.Model = Nothing
        Me.MainTreeView.Name = "MainTreeView"
        Me.MainTreeView.NodeControls.Add(Me.StateIcon)
        Me.MainTreeView.NodeControls.Add(Me.TBName)
        Me.MainTreeView.NodeControls.Add(Me.TBExtension)
        Me.MainTreeView.NodeControls.Add(Me.TBSize)
        Me.MainTreeView.NodeControls.Add(Me.CBSelection)
        Me.MainTreeView.NodeControls.Add(Me.TBNb)
        Me.MainTreeView.SelectedNode = Nothing
        Me.MainTreeView.Size = New System.Drawing.Size(600, 529)
        Me.MainTreeView.TabIndex = 0
        Me.MainTreeView.Text = "TreeViewAdv1"
        Me.MainTreeView.UseColumns = True
        '
        'MainPath
        '
        Me.MainPath.Header = "File / Folder"
        Me.MainPath.Sortable = True
        Me.MainPath.SortOrder = System.Windows.Forms.SortOrder.None
        Me.MainPath.TooltipText = Nothing
        Me.MainPath.Width = 250
        '
        'MainExt
        '
        Me.MainExt.Header = "Ext."
        Me.MainExt.SortOrder = System.Windows.Forms.SortOrder.None
        Me.MainExt.TooltipText = Nothing
        '
        'MainSize
        '
        Me.MainSize.Header = "Size"
        Me.MainSize.Sortable = True
        Me.MainSize.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.MainSize.TooltipText = Nothing
        Me.MainSize.Width = 130
        '
        'MainX
        '
        Me.MainX.Header = "X"
        Me.MainX.SortOrder = System.Windows.Forms.SortOrder.None
        Me.MainX.TooltipText = Nothing
        Me.MainX.Width = 25
        '
        'MainNb
        '
        Me.MainNb.Header = "#"
        Me.MainNb.SortOrder = System.Windows.Forms.SortOrder.None
        Me.MainNb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MainNb.TooltipText = Nothing
        '
        'StateIcon
        '
        Me.StateIcon.DataPropertyName = "Type"
        Me.StateIcon.LeftMargin = 1
        Me.StateIcon.ParentColumn = Me.MainPath
        Me.StateIcon.ScaleMode = Aga.Controls.Tree.ImageScaleMode.Clip
        '
        'TBName
        '
        Me.TBName.DataFormat = ""
        Me.TBName.DataPropertyName = "Text"
        Me.TBName.IncrementalSearchEnabled = True
        Me.TBName.LeftMargin = 3
        Me.TBName.ParentColumn = Me.MainPath
        Me.TBName.Trimming = System.Drawing.StringTrimming.EllipsisWord
        '
        'TBExtension
        '
        Me.TBExtension.DataFormat = ""
        Me.TBExtension.DataPropertyName = "Extension"
        Me.TBExtension.IncrementalSearchEnabled = True
        Me.TBExtension.LeftMargin = 3
        Me.TBExtension.ParentColumn = Me.MainExt
        '
        'TBSize
        '
        Me.TBSize.DataFormat = ""
        Me.TBSize.DataPropertyName = "SizeDisplay"
        Me.TBSize.IncrementalSearchEnabled = True
        Me.TBSize.LeftMargin = 3
        Me.TBSize.ParentColumn = Me.MainSize
        Me.TBSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CBSelection
        '
        Me.CBSelection.DataPropertyName = "Selected"
        Me.CBSelection.EditEnabled = True
        Me.CBSelection.LeftMargin = 0
        Me.CBSelection.ParentColumn = Me.MainX
        '
        'TBNb
        '
        Me.TBNb.DataFormat = "{0:N0}"
        Me.TBNb.DataPropertyName = "DisplayedCount"
        Me.TBNb.IncrementalSearchEnabled = True
        Me.TBNb.LeftMargin = 3
        Me.TBNb.ParentColumn = Me.MainNb
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.FoldersTab)
        Me.TabControl1.Controls.Add(Me.ByTypesTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(533, 529)
        Me.TabControl1.TabIndex = 1
        '
        'FoldersTab
        '
        Me.FoldersTab.Controls.Add(Me.FoldersTreeView)
        Me.FoldersTab.Location = New System.Drawing.Point(4, 25)
        Me.FoldersTab.Margin = New System.Windows.Forms.Padding(4)
        Me.FoldersTab.Name = "FoldersTab"
        Me.FoldersTab.Padding = New System.Windows.Forms.Padding(4)
        Me.FoldersTab.Size = New System.Drawing.Size(525, 500)
        Me.FoldersTab.TabIndex = 0
        Me.FoldersTab.Text = "Folders"
        Me.FoldersTab.UseVisualStyleBackColor = True
        '
        'FoldersTreeView
        '
        Me.FoldersTreeView.BackColor = System.Drawing.SystemColors.Window
        Me.FoldersTreeView.Columns.Add(Me.FoldersGroup)
        Me.FoldersTreeView.Columns.Add(Me.FoldersSize)
        Me.FoldersTreeView.Columns.Add(Me.FoldersX)
        Me.FoldersTreeView.Cursor = System.Windows.Forms.Cursors.Default
        Me.FoldersTreeView.DefaultToolTipProvider = Nothing
        Me.FoldersTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FoldersTreeView.DragDropMarkColor = System.Drawing.Color.Black
        Me.FoldersTreeView.FullRowSelect = True
        Me.FoldersTreeView.LineColor = System.Drawing.SystemColors.ControlDark
        Me.FoldersTreeView.Location = New System.Drawing.Point(4, 4)
        Me.FoldersTreeView.Margin = New System.Windows.Forms.Padding(4)
        Me.FoldersTreeView.Model = Nothing
        Me.FoldersTreeView.Name = "FoldersTreeView"
        Me.FoldersTreeView.NodeControls.Add(Me.NodeTextBox1)
        Me.FoldersTreeView.NodeControls.Add(Me.NodeTextBox2)
        Me.FoldersTreeView.NodeControls.Add(Me.NodeCheckBox1)
        Me.FoldersTreeView.SelectedNode = Nothing
        Me.FoldersTreeView.ShowLines = False
        Me.FoldersTreeView.Size = New System.Drawing.Size(517, 492)
        Me.FoldersTreeView.TabIndex = 0
        Me.FoldersTreeView.Text = "TreeViewAdv2"
        Me.FoldersTreeView.UseColumns = True
        '
        'FoldersGroup
        '
        Me.FoldersGroup.Header = "Group"
        Me.FoldersGroup.Sortable = True
        Me.FoldersGroup.SortOrder = System.Windows.Forms.SortOrder.None
        Me.FoldersGroup.TooltipText = Nothing
        Me.FoldersGroup.Width = 100
        '
        'FoldersSize
        '
        Me.FoldersSize.Header = "Size"
        Me.FoldersSize.Sortable = True
        Me.FoldersSize.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.FoldersSize.TooltipText = Nothing
        Me.FoldersSize.Width = 100
        '
        'FoldersX
        '
        Me.FoldersX.Header = "X"
        Me.FoldersX.SortOrder = System.Windows.Forms.SortOrder.None
        Me.FoldersX.TooltipText = Nothing
        Me.FoldersX.Width = 25
        '
        'NodeTextBox1
        '
        Me.NodeTextBox1.DataFormat = ""
        Me.NodeTextBox1.DataPropertyName = "Text"
        Me.NodeTextBox1.IncrementalSearchEnabled = True
        Me.NodeTextBox1.LeftMargin = 3
        Me.NodeTextBox1.ParentColumn = Me.FoldersGroup
        '
        'NodeTextBox2
        '
        Me.NodeTextBox2.DataFormat = ""
        Me.NodeTextBox2.DataPropertyName = "SizeDisplay"
        Me.NodeTextBox2.IncrementalSearchEnabled = True
        Me.NodeTextBox2.LeftMargin = 3
        Me.NodeTextBox2.ParentColumn = Me.FoldersSize
        '
        'NodeCheckBox1
        '
        Me.NodeCheckBox1.DataPropertyName = "Selected"
        Me.NodeCheckBox1.EditEnabled = True
        Me.NodeCheckBox1.LeftMargin = 0
        Me.NodeCheckBox1.ParentColumn = Me.FoldersX
        '
        'ByTypesTab
        '
        Me.ByTypesTab.Controls.Add(Me.ByTypesTreeView)
        Me.ByTypesTab.Location = New System.Drawing.Point(4, 25)
        Me.ByTypesTab.Margin = New System.Windows.Forms.Padding(4)
        Me.ByTypesTab.Name = "ByTypesTab"
        Me.ByTypesTab.Padding = New System.Windows.Forms.Padding(4)
        Me.ByTypesTab.Size = New System.Drawing.Size(525, 500)
        Me.ByTypesTab.TabIndex = 1
        Me.ByTypesTab.Text = "By Types"
        Me.ByTypesTab.UseVisualStyleBackColor = True
        '
        'ByTypesTreeView
        '
        Me.ByTypesTreeView.BackColor = System.Drawing.SystemColors.Window
        Me.ByTypesTreeView.Columns.Add(Me.ByTypesGroup)
        Me.ByTypesTreeView.Columns.Add(Me.ByTypesSize)
        Me.ByTypesTreeView.Columns.Add(Me.ByTypesX)
        Me.ByTypesTreeView.Cursor = System.Windows.Forms.Cursors.Default
        Me.ByTypesTreeView.DefaultToolTipProvider = Nothing
        Me.ByTypesTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ByTypesTreeView.DragDropMarkColor = System.Drawing.Color.Black
        Me.ByTypesTreeView.FullRowSelect = True
        Me.ByTypesTreeView.LineColor = System.Drawing.SystemColors.ControlDark
        Me.ByTypesTreeView.Location = New System.Drawing.Point(4, 4)
        Me.ByTypesTreeView.Margin = New System.Windows.Forms.Padding(4)
        Me.ByTypesTreeView.Model = Nothing
        Me.ByTypesTreeView.Name = "ByTypesTreeView"
        Me.ByTypesTreeView.NodeControls.Add(Me.NodeTextBox3)
        Me.ByTypesTreeView.NodeControls.Add(Me.NodeTextBox4)
        Me.ByTypesTreeView.NodeControls.Add(Me.NodeCheckBox2)
        Me.ByTypesTreeView.SelectedNode = Nothing
        Me.ByTypesTreeView.ShowLines = False
        Me.ByTypesTreeView.Size = New System.Drawing.Size(517, 492)
        Me.ByTypesTreeView.TabIndex = 1
        Me.ByTypesTreeView.Text = "TreeViewAdv3"
        Me.ByTypesTreeView.UseColumns = True
        '
        'ByTypesGroup
        '
        Me.ByTypesGroup.Header = "Group"
        Me.ByTypesGroup.Sortable = True
        Me.ByTypesGroup.SortOrder = System.Windows.Forms.SortOrder.None
        Me.ByTypesGroup.TooltipText = Nothing
        Me.ByTypesGroup.Width = 100
        '
        'ByTypesSize
        '
        Me.ByTypesSize.Header = "Size"
        Me.ByTypesSize.Sortable = True
        Me.ByTypesSize.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.ByTypesSize.TooltipText = Nothing
        Me.ByTypesSize.Width = 100
        '
        'ByTypesX
        '
        Me.ByTypesX.Header = "X"
        Me.ByTypesX.SortOrder = System.Windows.Forms.SortOrder.None
        Me.ByTypesX.TooltipText = Nothing
        Me.ByTypesX.Width = 25
        '
        'NodeTextBox3
        '
        Me.NodeTextBox3.DataFormat = ""
        Me.NodeTextBox3.DataPropertyName = "Text"
        Me.NodeTextBox3.IncrementalSearchEnabled = True
        Me.NodeTextBox3.LeftMargin = 3
        Me.NodeTextBox3.ParentColumn = Me.ByTypesGroup
        '
        'NodeTextBox4
        '
        Me.NodeTextBox4.DataFormat = ""
        Me.NodeTextBox4.DataPropertyName = "SizeDisplay"
        Me.NodeTextBox4.IncrementalSearchEnabled = True
        Me.NodeTextBox4.LeftMargin = 3
        Me.NodeTextBox4.ParentColumn = Me.ByTypesSize
        '
        'NodeCheckBox2
        '
        Me.NodeCheckBox2.DataPropertyName = "Selected"
        Me.NodeCheckBox2.EditEnabled = True
        Me.NodeCheckBox2.LeftMargin = 0
        Me.NodeCheckBox2.ParentColumn = Me.ByTypesX
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.spring, Me.ProgressLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 652)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1156, 26)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(50, 20)
        Me.StatusLabel.Text = "Ready"
        '
        'spring
        '
        Me.spring.Name = "spring"
        Me.spring.Size = New System.Drawing.Size(1086, 20)
        Me.spring.Spring = True
        '
        'ProgressLabel2
        '
        Me.ProgressLabel2.Name = "ProgressLabel2"
        Me.ProgressLabel2.Size = New System.Drawing.Size(0, 20)
        '
        'LoadUpdateTimer
        '
        Me.LoadUpdateTimer.Enabled = True
        Me.LoadUpdateTimer.Interval = 500
        '
        'BottomPanel3
        '
        Me.BottomPanel3.AutoSize = True
        Me.BottomPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BottomPanel3.ColumnCount = 4
        Me.BottomPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BottomPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BottomPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BottomPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BottomPanel3.Controls.Add(Me.Label4, 3, 2)
        Me.BottomPanel3.Controls.Add(Me.Label3, 3, 1)
        Me.BottomPanel3.Controls.Add(Me.numberProgress, 0, 1)
        Me.BottomPanel3.Controls.Add(Me.sizeProgress, 0, 2)
        Me.BottomPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel3.Location = New System.Drawing.Point(0, 606)
        Me.BottomPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomPanel3.Name = "BottomPanel3"
        Me.BottomPanel3.RowCount = 3
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.Size = New System.Drawing.Size(1156, 46)
        Me.BottomPanel3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(1125, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mb"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(1125, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "#"
        '
        'numberProgress
        '
        Me.BottomPanel3.SetColumnSpan(Me.numberProgress, 3)
        Me.numberProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numberProgress.Location = New System.Drawing.Point(4, 4)
        Me.numberProgress.Margin = New System.Windows.Forms.Padding(4)
        Me.numberProgress.Name = "numberProgress"
        Me.numberProgress.Size = New System.Drawing.Size(1113, 15)
        Me.numberProgress.TabIndex = 10
        '
        'sizeProgress
        '
        Me.BottomPanel3.SetColumnSpan(Me.sizeProgress, 3)
        Me.sizeProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sizeProgress.Location = New System.Drawing.Point(4, 27)
        Me.sizeProgress.Margin = New System.Windows.Forms.Padding(4)
        Me.sizeProgress.Name = "sizeProgress"
        Me.sizeProgress.Size = New System.Drawing.Size(1113, 15)
        Me.sizeProgress.TabIndex = 6
        '
        'fileDestBrowseDLG
        '
        Me.fileDestBrowseDLG.DefaultExt = "zip"
        Me.fileDestBrowseDLG.FileName = Global.SelectiveFileCopy.My.MySettings.Default.SaveFilePath
        Me.fileDestBrowseDLG.Filter = "Zip File|*.zip"
        Me.fileDestBrowseDLG.SupportMultiDottedExtensions = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.RunToolStripMenuItem, Me.InfosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1156, 30)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolstripMenuItem1, Me.ToolStripSeparator5, Me.ActionToolstripMenuItem2, Me.ActionToolstripMenuItem3})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.FileToolStripMenuItem.Text = "Source / Destination"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyIncludesRootFolderToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(75, 26)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'CopyIncludesRootFolderToolStripMenuItem
        '
        Me.CopyIncludesRootFolderToolStripMenuItem.Checked = True
        Me.CopyIncludesRootFolderToolStripMenuItem.CheckOnClick = True
        Me.CopyIncludesRootFolderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CopyIncludesRootFolderToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.GraphTopToBottom_16x
        Me.CopyIncludesRootFolderToolStripMenuItem.Name = "CopyIncludesRootFolderToolStripMenuItem"
        Me.CopyIncludesRootFolderToolStripMenuItem.Size = New System.Drawing.Size(264, 26)
        Me.CopyIncludesRootFolderToolStripMenuItem.Text = "Copy includes Root folder"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolstripMenuItem4, Me.PauseCopyToolStripMenuItem, Me.StopCopyToolStripMenuItem})
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(48, 26)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'PauseCopyToolStripMenuItem
        '
        Me.PauseCopyToolStripMenuItem.Enabled = False
        Me.PauseCopyToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.Pause_16x
        Me.PauseCopyToolStripMenuItem.Name = "PauseCopyToolStripMenuItem"
        Me.PauseCopyToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.PauseCopyToolStripMenuItem.Text = "Pause copy"
        '
        'StopCopyToolStripMenuItem
        '
        Me.StopCopyToolStripMenuItem.Enabled = False
        Me.StopCopyToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.Stop_16x
        Me.StopCopyToolStripMenuItem.Name = "StopCopyToolStripMenuItem"
        Me.StopCopyToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.StopCopyToolStripMenuItem.Text = "Stop copy"
        '
        'InfosToolStripMenuItem
        '
        Me.InfosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiledestinationNotSelectedToolStripMenuItem, Me.FileAddedToolStripMenuItem, Me.FileUpdatedToolStripMenuItem, Me.IgnoredFileToolStripMenuItem, Me.FileIgnoredToolStripMenuItem, Me.ToolStripSeparator3, Me.FolderdestinationNotSelectedYetToolStripMenuItem, Me.NewFolderWillBeAddedToolStripMenuItem, Me.ExistingFolderWillBeUpdatedToolStripMenuItem, Me.IgnoredFolderToolStripMenuItem, Me.ExistingFolderWillBeDeletedToolStripMenuItem})
        Me.InfosToolStripMenuItem.Name = "InfosToolStripMenuItem"
        Me.InfosToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.InfosToolStripMenuItem.Text = "Infos"
        '
        'FiledestinationNotSelectedToolStripMenuItem
        '
        Me.FiledestinationNotSelectedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.File_16x
        Me.FiledestinationNotSelectedToolStripMenuItem.Name = "FiledestinationNotSelectedToolStripMenuItem"
        Me.FiledestinationNotSelectedToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.FiledestinationNotSelectedToolStripMenuItem.Text = "File (destination not selected yet)"
        '
        'FileAddedToolStripMenuItem
        '
        Me.FileAddedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.AddFile_16x
        Me.FileAddedToolStripMenuItem.Name = "FileAddedToolStripMenuItem"
        Me.FileAddedToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.FileAddedToolStripMenuItem.Text = "New file, will be added"
        '
        'FileUpdatedToolStripMenuItem
        '
        Me.FileUpdatedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.UpdateFile_16x
        Me.FileUpdatedToolStripMenuItem.Name = "FileUpdatedToolStripMenuItem"
        Me.FileUpdatedToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.FileUpdatedToolStripMenuItem.Text = "Existing file, will be replaced"
        '
        'IgnoredFileToolStripMenuItem
        '
        Me.IgnoredFileToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.BlankFile_16x
        Me.IgnoredFileToolStripMenuItem.Name = "IgnoredFileToolStripMenuItem"
        Me.IgnoredFileToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.IgnoredFileToolStripMenuItem.Text = "Ignored file"
        '
        'FileIgnoredToolStripMenuItem
        '
        Me.FileIgnoredToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.DeleteFile_16
        Me.FileIgnoredToolStripMenuItem.Name = "FileIgnoredToolStripMenuItem"
        Me.FileIgnoredToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.FileIgnoredToolStripMenuItem.Text = "Existing file, will be deleted"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(328, 6)
        '
        'FolderdestinationNotSelectedYetToolStripMenuItem
        '
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.Folder_16x
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Name = "FolderdestinationNotSelectedYetToolStripMenuItem"
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Text = "Folder (destination not selected yet)"
        '
        'NewFolderWillBeAddedToolStripMenuItem
        '
        Me.NewFolderWillBeAddedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.AddFolder_16x
        Me.NewFolderWillBeAddedToolStripMenuItem.Name = "NewFolderWillBeAddedToolStripMenuItem"
        Me.NewFolderWillBeAddedToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.NewFolderWillBeAddedToolStripMenuItem.Text = "New folder, will be added"
        '
        'ExistingFolderWillBeUpdatedToolStripMenuItem
        '
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.UpdateFolder_16x
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Name = "ExistingFolderWillBeUpdatedToolStripMenuItem"
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Text = "Existing folder, will be updated"
        '
        'IgnoredFolderToolStripMenuItem
        '
        Me.IgnoredFolderToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.IgnoredFolder_16x
        Me.IgnoredFolderToolStripMenuItem.Name = "IgnoredFolderToolStripMenuItem"
        Me.IgnoredFolderToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.IgnoredFolderToolStripMenuItem.Text = "Ignored folder"
        '
        'ExistingFolderWillBeDeletedToolStripMenuItem
        '
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.DeleteFolder_16x
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Name = "ExistingFolderWillBeDeletedToolStripMenuItem"
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Size = New System.Drawing.Size(331, 26)
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Text = "Existing folder, will be deleted"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolStripButton1, Me.ToolStripSeparator4, Me.ActionToolStripButton2, Me.ActionToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ActionToolStripButton4, Me.ToolStripButton6, Me.ToolStripButton7, Me.DestinationPathTS})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1156, 31)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.CheckOnClick = True
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.SelectiveFileCopy.My.Resources.Resources.GraphTopToBottom_16x
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Enabled = False
        Me.ToolStripButton6.Image = Global.SelectiveFileCopy.My.Resources.Resources.Pause_16x
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Enabled = False
        Me.ToolStripButton7.Image = Global.SelectiveFileCopy.My.Resources.Resources.Stop_16x
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'DestinationPathTS
        '
        Me.DestinationPathTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DestinationPathTS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DestinationPathTS.Name = "DestinationPathTS"
        Me.DestinationPathTS.ReadOnly = True
        Me.DestinationPathTS.Size = New System.Drawing.Size(300, 31)
        '
        'ByNamesGroup
        '
        Me.ByNamesGroup.Header = "Group"
        Me.ByNamesGroup.SortOrder = System.Windows.Forms.SortOrder.None
        Me.ByNamesGroup.TooltipText = Nothing
        Me.ByNamesGroup.Width = 100
        '
        'ByNamesSize
        '
        Me.ByNamesSize.Header = "Size"
        Me.ByNamesSize.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.ByNamesSize.TooltipText = Nothing
        Me.ByNamesSize.Width = 100
        '
        'ByNamesX
        '
        Me.ByNamesX.Header = "X"
        Me.ByNamesX.SortOrder = System.Windows.Forms.SortOrder.None
        Me.ByNamesX.TooltipText = Nothing
        Me.ByNamesX.Width = 25
        '
        'NodeTextBox5
        '
        Me.NodeTextBox5.DataFormat = ""
        Me.NodeTextBox5.DataPropertyName = "Text"
        Me.NodeTextBox5.IncrementalSearchEnabled = True
        Me.NodeTextBox5.LeftMargin = 3
        Me.NodeTextBox5.ParentColumn = Me.ByNamesGroup
        '
        'NodeTextBox6
        '
        Me.NodeTextBox6.DataFormat = ""
        Me.NodeTextBox6.DataPropertyName = "SizeDisplay"
        Me.NodeTextBox6.IncrementalSearchEnabled = True
        Me.NodeTextBox6.LeftMargin = 3
        Me.NodeTextBox6.ParentColumn = Me.ByNamesSize
        '
        'NodeCheckBox3
        '
        Me.NodeCheckBox3.DataPropertyName = "Selected"
        Me.NodeCheckBox3.EditEnabled = True
        Me.NodeCheckBox3.LeftMargin = 0
        Me.NodeCheckBox3.ParentColumn = Me.ByNamesX
        '
        'TBName2
        '
        Me.TBName2.DataFormat = ""
        Me.TBName2.DataPropertyName = "Text"
        Me.TBName2.IncrementalSearchEnabled = True
        Me.TBName2.LeftMargin = 3
        Me.TBName2.ParentColumn = Nothing
        Me.TBName2.Trimming = System.Drawing.StringTrimming.EllipsisWord
        '
        'TBSize2
        '
        Me.TBSize2.DataFormat = ""
        Me.TBSize2.DataPropertyName = "SizeDisplay"
        Me.TBSize2.IncrementalSearchEnabled = True
        Me.TBSize2.LeftMargin = 3
        Me.TBSize2.ParentColumn = Nothing
        Me.TBSize2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TBSelection2
        '
        Me.TBSelection2.DataPropertyName = "Selected"
        Me.TBSelection2.LeftMargin = 0
        Me.TBSelection2.ParentColumn = Nothing
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(304, 6)
        '
        'ActionToolStripButton1
        '
        Me.ActionToolStripButton1.Action = Me.SelectInputFolderAction
        Me.ActionToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActionToolStripButton1.Image = Global.SelectiveFileCopy.My.Resources.Resources.OpenFolder_16x
        Me.ActionToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ActionToolStripButton1.Name = "ActionToolStripButton1"
        Me.ActionToolStripButton1.Size = New System.Drawing.Size(29, 28)
        Me.ActionToolStripButton1.Text = "Select Input Folder"
        Me.ActionToolStripButton1.ToolTipText = "Select the input folder, it will load its content."
        '
        'SelectInputFolderAction
        '
        Me.SelectInputFolderAction.Checked = False
        Me.SelectInputFolderAction.Enabled = True
        Me.SelectInputFolderAction.Image = Global.SelectiveFileCopy.My.Resources.Resources.OpenFolder_16x
        Me.SelectInputFolderAction.Text = "Select Input Folder"
        Me.SelectInputFolderAction.Tooltip = "Select the input folder, it will load its content."
        '
        'ActionToolStripButton2
        '
        Me.ActionToolStripButton2.Action = Me.SelectDestFolderAction
        Me.ActionToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActionToolStripButton2.Image = Global.SelectiveFileCopy.My.Resources.Resources.WelcomeSampleFolder_16x
        Me.ActionToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ActionToolStripButton2.Name = "ActionToolStripButton2"
        Me.ActionToolStripButton2.Size = New System.Drawing.Size(29, 28)
        Me.ActionToolStripButton2.Text = "Select Destination (As Folder)"
        Me.ActionToolStripButton2.ToolTipText = "Select Destination as a Folder"
        '
        'SelectDestFolderAction
        '
        Me.SelectDestFolderAction.Checked = False
        Me.SelectDestFolderAction.Enabled = True
        Me.SelectDestFolderAction.Image = Global.SelectiveFileCopy.My.Resources.Resources.WelcomeSampleFolder_16x
        Me.SelectDestFolderAction.Text = "Select Destination (As Folder)"
        Me.SelectDestFolderAction.Tooltip = "Select Destination as a Folder"
        '
        'ActionToolStripButton3
        '
        Me.ActionToolStripButton3.Action = Me.SelectDestZipAction
        Me.ActionToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActionToolStripButton3.Image = Global.SelectiveFileCopy.My.Resources.Resources.FileDestination_16x
        Me.ActionToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ActionToolStripButton3.Name = "ActionToolStripButton3"
        Me.ActionToolStripButton3.Size = New System.Drawing.Size(29, 28)
        Me.ActionToolStripButton3.Text = "Select Destination (As a Zip File)"
        Me.ActionToolStripButton3.ToolTipText = "Select Destination as a Zip File"
        '
        'SelectDestZipAction
        '
        Me.SelectDestZipAction.Checked = False
        Me.SelectDestZipAction.Enabled = True
        Me.SelectDestZipAction.Image = Global.SelectiveFileCopy.My.Resources.Resources.FileDestination_16x
        Me.SelectDestZipAction.Text = "Select Destination (As a Zip File)"
        Me.SelectDestZipAction.Tooltip = "Select Destination as a Zip File"
        '
        'ActionToolStripButton4
        '
        Me.ActionToolStripButton4.Action = Me.StartCopyAction
        Me.ActionToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ActionToolStripButton4.Enabled = False
        Me.ActionToolStripButton4.Image = Global.SelectiveFileCopy.My.Resources.Resources.Run_16x
        Me.ActionToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ActionToolStripButton4.Name = "ActionToolStripButton4"
        Me.ActionToolStripButton4.Size = New System.Drawing.Size(29, 28)
        Me.ActionToolStripButton4.Text = "Start Copying Files"
        '
        'StartCopyAction
        '
        Me.StartCopyAction.Checked = False
        Me.StartCopyAction.Enabled = False
        Me.StartCopyAction.Image = Global.SelectiveFileCopy.My.Resources.Resources.Run_16x
        Me.StartCopyAction.Text = "Start Copying Files"
        Me.StartCopyAction.Tooltip = ""
        '
        'ActionToolstripMenuItem1
        '
        Me.ActionToolstripMenuItem1.Action = Me.SelectInputFolderAction
        Me.ActionToolstripMenuItem1.Image = Global.SelectiveFileCopy.My.Resources.Resources.OpenFolder_16x
        Me.ActionToolstripMenuItem1.Name = "ActionToolstripMenuItem1"
        Me.ActionToolstripMenuItem1.Size = New System.Drawing.Size(307, 26)
        Me.ActionToolstripMenuItem1.Text = "Select Input Folder"
        Me.ActionToolstripMenuItem1.ToolTipText = "Select the input folder, it will load its content."
        '
        'ActionToolstripMenuItem2
        '
        Me.ActionToolstripMenuItem2.Action = Me.SelectDestFolderAction
        Me.ActionToolstripMenuItem2.Image = Global.SelectiveFileCopy.My.Resources.Resources.WelcomeSampleFolder_16x
        Me.ActionToolstripMenuItem2.Name = "ActionToolstripMenuItem2"
        Me.ActionToolstripMenuItem2.Size = New System.Drawing.Size(307, 26)
        Me.ActionToolstripMenuItem2.Text = "Select Destination (As Folder)"
        Me.ActionToolstripMenuItem2.ToolTipText = "Select Destination as a Folder"
        '
        'ActionToolstripMenuItem3
        '
        Me.ActionToolstripMenuItem3.Action = Me.SelectDestZipAction
        Me.ActionToolstripMenuItem3.Image = Global.SelectiveFileCopy.My.Resources.Resources.FileDestination_16x
        Me.ActionToolstripMenuItem3.Name = "ActionToolstripMenuItem3"
        Me.ActionToolstripMenuItem3.Size = New System.Drawing.Size(307, 26)
        Me.ActionToolstripMenuItem3.Text = "Select Destination (As a Zip File)"
        Me.ActionToolstripMenuItem3.ToolTipText = "Select Destination as a Zip File"
        '
        'ActionToolstripMenuItem4
        '
        Me.ActionToolstripMenuItem4.Action = Me.StartCopyAction
        Me.ActionToolstripMenuItem4.Enabled = False
        Me.ActionToolstripMenuItem4.Image = Global.SelectiveFileCopy.My.Resources.Resources.Run_16x
        Me.ActionToolstripMenuItem4.Name = "ActionToolstripMenuItem4"
        Me.ActionToolstripMenuItem4.Size = New System.Drawing.Size(215, 26)
        Me.ActionToolstripMenuItem4.Text = "Start Copying Files"
        '
        'MainWindowUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 678)
        Me.Controls.Add(Me.CenterPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BottomPanel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainWindowUI"
        Me.Text = "Selective CopyFile"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.CenterPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.FoldersTab.ResumeLayout(False)
        Me.ByTypesTab.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.BottomPanel3.ResumeLayout(False)
        Me.BottomPanel3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MainTreeView As Aga.Controls.Tree.TreeViewAdv
    Friend WithEvents CBSelection As Aga.Controls.Tree.NodeControls.NodeCheckBox
    Friend WithEvents TBName As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents TBExtension As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents TBSize As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents FoldersTreeView As Aga.Controls.Tree.TreeViewAdv
    Friend WithEvents StateIcon As Aga.Controls.Tree.NodeControls.NodeStateIcon
    Friend WithEvents TBName2 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents TBSize2 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents TBSelection2 As Aga.Controls.Tree.NodeControls.NodeCheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeselectAllByExtensionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeselectAllByNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllByExtensionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllByNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FoldersTab As TabPage
    Friend WithEvents ByTypesTab As TabPage
    Friend WithEvents ByTypesTreeView As Aga.Controls.Tree.TreeViewAdv
    Friend WithEvents CenterPanel As Panel
    Friend WithEvents NodeTextBox1 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents NodeTextBox2 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents NodeCheckBox1 As Aga.Controls.Tree.NodeControls.NodeCheckBox
    Friend WithEvents MainPath As Aga.Controls.Tree.TreeColumn
    Friend WithEvents MainExt As Aga.Controls.Tree.TreeColumn
    Friend WithEvents MainSize As Aga.Controls.Tree.TreeColumn
    Friend WithEvents MainX As Aga.Controls.Tree.TreeColumn
    Friend WithEvents FoldersGroup As Aga.Controls.Tree.TreeColumn
    Friend WithEvents FoldersSize As Aga.Controls.Tree.TreeColumn
    Friend WithEvents FoldersX As Aga.Controls.Tree.TreeColumn
    Friend WithEvents ByTypesGroup As Aga.Controls.Tree.TreeColumn
    Friend WithEvents ByTypesSize As Aga.Controls.Tree.TreeColumn
    Friend WithEvents ByTypesX As Aga.Controls.Tree.TreeColumn
    Friend WithEvents ByNamesGroup As Aga.Controls.Tree.TreeColumn
    Friend WithEvents ByNamesSize As Aga.Controls.Tree.TreeColumn
    Friend WithEvents ByNamesX As Aga.Controls.Tree.TreeColumn
    Friend WithEvents NodeTextBox3 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents NodeTextBox4 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents NodeCheckBox2 As Aga.Controls.Tree.NodeControls.NodeCheckBox
    Friend WithEvents NodeTextBox5 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents NodeTextBox6 As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents NodeCheckBox3 As Aga.Controls.Tree.NodeControls.NodeCheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sizeProgress As ProgressBar
    Friend WithEvents numberProgress As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents BottomPanel3 As TableLayoutPanel
    Friend WithEvents MainNb As Aga.Controls.Tree.TreeColumn
    Friend WithEvents TBNb As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents spring As ToolStripStatusLabel
    Friend WithEvents ProgressLabel2 As ToolStripStatusLabel
    Friend WithEvents LoadUpdateTimer As Timer
    Friend WithEvents fileDestBrowseDLG As SaveFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InfosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiledestinationNotSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileAddedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileUpdatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IgnoredFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileIgnoredToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FolderdestinationNotSelectedYetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewFolderWillBeAddedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistingFolderWillBeUpdatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IgnoredFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistingFolderWillBeDeletedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyIncludesRootFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseCopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopCopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DestinationPathTS As ToolStripTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SelectInputFolderAction As CustomAction
    Friend WithEvents ActionToolStripButton1 As ActionToolStripButton
    Friend WithEvents ActionToolstripMenuItem1 As ActionToolstripMenuItem
    Friend WithEvents SelectDestFolderAction As CustomAction
    Friend WithEvents ActionToolstripMenuItem2 As ActionToolstripMenuItem
    Friend WithEvents ActionToolstripMenuItem3 As ActionToolstripMenuItem
    Friend WithEvents SelectDestZipAction As CustomAction
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ActionToolStripButton2 As ActionToolStripButton
    Friend WithEvents ActionToolStripButton3 As ActionToolStripButton
    Friend WithEvents ActionToolstripMenuItem4 As ActionToolstripMenuItem
    Friend WithEvents StartCopyAction As CustomAction
    Friend WithEvents ActionToolStripButton4 As ActionToolStripButton
End Class
