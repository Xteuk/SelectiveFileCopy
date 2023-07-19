<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.ByTypesTab = New System.Windows.Forms.TabPage()
        Me.ByTypesTreeView = New Aga.Controls.Tree.TreeViewAdv()
        Me.ByTypesGroup = New Aga.Controls.Tree.TreeColumn()
        Me.ByTypesSize = New Aga.Controls.Tree.TreeColumn()
        Me.ByTypesX = New Aga.Controls.Tree.TreeColumn()
        Me.NodeTextBox3 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeTextBox4 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeCheckBox2 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.FoldersTab = New System.Windows.Forms.TabPage()
        Me.FoldersTreeView = New Aga.Controls.Tree.TreeViewAdv()
        Me.FoldersGroup = New Aga.Controls.Tree.TreeColumn()
        Me.FoldersSize = New Aga.Controls.Tree.TreeColumn()
        Me.FoldersX = New Aga.Controls.Tree.TreeColumn()
        Me.NodeTextBox1 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeTextBox2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeCheckBox1 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.ByNamesGroup = New Aga.Controls.Tree.TreeColumn()
        Me.ByNamesSize = New Aga.Controls.Tree.TreeColumn()
        Me.ByNamesX = New Aga.Controls.Tree.TreeColumn()
        Me.NodeTextBox5 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeTextBox6 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeCheckBox3 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.TBName2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBSize2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBSelection2 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BottomPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectDestinationasFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectDestinationasZipFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyIncludesRootFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartCoypingSelectedFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseCopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopCopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileAddedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileUpdatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IgnoredFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileIgnoredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewFolderWillBeAddedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IgnoredFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExistingFolderWillBeDeletedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.FiledestinationNotSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderdestinationNotSelectedYetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainInfo = New Aga.Controls.Tree.TreeColumn()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.CenterPanel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ByTypesTab.SuspendLayout()
        Me.FoldersTab.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.BottomPanel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeselectAllByExtensionToolStripMenuItem, Me.DeselectAllByNameToolStripMenuItem, Me.SelectAllByExtensionToolStripMenuItem, Me.SelectAllByNameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 92)
        '
        'DeselectAllByExtensionToolStripMenuItem
        '
        Me.DeselectAllByExtensionToolStripMenuItem.Name = "DeselectAllByExtensionToolStripMenuItem"
        Me.DeselectAllByExtensionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeselectAllByExtensionToolStripMenuItem.Text = "Deselect all by extension"
        '
        'DeselectAllByNameToolStripMenuItem
        '
        Me.DeselectAllByNameToolStripMenuItem.Name = "DeselectAllByNameToolStripMenuItem"
        Me.DeselectAllByNameToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeselectAllByNameToolStripMenuItem.Text = "Deselect all by name"
        '
        'SelectAllByExtensionToolStripMenuItem
        '
        Me.SelectAllByExtensionToolStripMenuItem.Name = "SelectAllByExtensionToolStripMenuItem"
        Me.SelectAllByExtensionToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SelectAllByExtensionToolStripMenuItem.Text = "Select all by extension"
        '
        'SelectAllByNameToolStripMenuItem
        '
        Me.SelectAllByNameToolStripMenuItem.Name = "SelectAllByNameToolStripMenuItem"
        Me.SelectAllByNameToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.SelectAllByNameToolStripMenuItem.Text = "Select all by name"
        '
        'CenterPanel
        '
        Me.CenterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CenterPanel.Controls.Add(Me.SplitContainer1)
        Me.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CenterPanel.Location = New System.Drawing.Point(0, 49)
        Me.CenterPanel.Name = "CenterPanel"
        Me.CenterPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.CenterPanel.Size = New System.Drawing.Size(952, 444)
        Me.CenterPanel.TabIndex = 15
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MainTreeView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(938, 430)
        Me.SplitContainer1.SplitterDistance = 672
        Me.SplitContainer1.TabIndex = 2
        '
        'MainTreeView
        '
        Me.MainTreeView.AllowColumnReorder = True
        Me.MainTreeView.BackColor = System.Drawing.SystemColors.Window
        Me.MainTreeView.Columns.Add(Me.MainInfo)
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
        Me.MainTreeView.Model = Nothing
        Me.MainTreeView.Name = "MainTreeView"
        Me.MainTreeView.NodeControls.Add(Me.StateIcon)
        Me.MainTreeView.NodeControls.Add(Me.TBName)
        Me.MainTreeView.NodeControls.Add(Me.TBExtension)
        Me.MainTreeView.NodeControls.Add(Me.TBSize)
        Me.MainTreeView.NodeControls.Add(Me.CBSelection)
        Me.MainTreeView.NodeControls.Add(Me.TBNb)
        Me.MainTreeView.SelectedNode = Nothing
        Me.MainTreeView.Size = New System.Drawing.Size(672, 430)
        Me.MainTreeView.TabIndex = 0
        Me.MainTreeView.Text = "TreeViewAdv1"
        Me.MainTreeView.UseColumns = True
        '
        'MainPath
        '
        Me.MainPath.Header = "File / Folder"
        Me.MainPath.SortOrder = System.Windows.Forms.SortOrder.None
        Me.MainPath.TooltipText = Nothing
        Me.MainPath.Width = 300
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
        Me.TBName.DataPropertyName = "Text"
        Me.TBName.IncrementalSearchEnabled = True
        Me.TBName.LeftMargin = 3
        Me.TBName.ParentColumn = Me.MainPath
        Me.TBName.Trimming = System.Drawing.StringTrimming.EllipsisWord
        '
        'TBExtension
        '
        Me.TBExtension.DataPropertyName = "Extension"
        Me.TBExtension.IncrementalSearchEnabled = True
        Me.TBExtension.LeftMargin = 3
        Me.TBExtension.ParentColumn = Me.MainExt
        '
        'TBSize
        '
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
        Me.TBNb.DataPropertyName = "DisplayedCount"
        Me.TBNb.IncrementalSearchEnabled = True
        Me.TBNb.LeftMargin = 3
        Me.TBNb.ParentColumn = Me.MainNb
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ByTypesTab)
        Me.TabControl1.Controls.Add(Me.FoldersTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(262, 430)
        Me.TabControl1.TabIndex = 1
        '
        'ByTypesTab
        '
        Me.ByTypesTab.Controls.Add(Me.ByTypesTreeView)
        Me.ByTypesTab.Location = New System.Drawing.Point(4, 22)
        Me.ByTypesTab.Name = "ByTypesTab"
        Me.ByTypesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ByTypesTab.Size = New System.Drawing.Size(254, 404)
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
        Me.ByTypesTreeView.Location = New System.Drawing.Point(3, 3)
        Me.ByTypesTreeView.Model = Nothing
        Me.ByTypesTreeView.Name = "ByTypesTreeView"
        Me.ByTypesTreeView.NodeControls.Add(Me.NodeTextBox3)
        Me.ByTypesTreeView.NodeControls.Add(Me.NodeTextBox4)
        Me.ByTypesTreeView.NodeControls.Add(Me.NodeCheckBox2)
        Me.ByTypesTreeView.SelectedNode = Nothing
        Me.ByTypesTreeView.ShowLines = False
        Me.ByTypesTreeView.Size = New System.Drawing.Size(248, 398)
        Me.ByTypesTreeView.TabIndex = 1
        Me.ByTypesTreeView.Text = "TreeViewAdv3"
        Me.ByTypesTreeView.UseColumns = True
        '
        'ByTypesGroup
        '
        Me.ByTypesGroup.Header = "Group"
        Me.ByTypesGroup.SortOrder = System.Windows.Forms.SortOrder.None
        Me.ByTypesGroup.TooltipText = Nothing
        Me.ByTypesGroup.Width = 100
        '
        'ByTypesSize
        '
        Me.ByTypesSize.Header = "Size"
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
        Me.NodeTextBox3.DataPropertyName = "Text"
        Me.NodeTextBox3.IncrementalSearchEnabled = True
        Me.NodeTextBox3.LeftMargin = 3
        Me.NodeTextBox3.ParentColumn = Me.ByTypesGroup
        '
        'NodeTextBox4
        '
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
        'FoldersTab
        '
        Me.FoldersTab.Controls.Add(Me.FoldersTreeView)
        Me.FoldersTab.Location = New System.Drawing.Point(4, 22)
        Me.FoldersTab.Name = "FoldersTab"
        Me.FoldersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FoldersTab.Size = New System.Drawing.Size(254, 404)
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
        Me.FoldersTreeView.Location = New System.Drawing.Point(3, 3)
        Me.FoldersTreeView.Model = Nothing
        Me.FoldersTreeView.Name = "FoldersTreeView"
        Me.FoldersTreeView.NodeControls.Add(Me.NodeTextBox1)
        Me.FoldersTreeView.NodeControls.Add(Me.NodeTextBox2)
        Me.FoldersTreeView.NodeControls.Add(Me.NodeCheckBox1)
        Me.FoldersTreeView.SelectedNode = Nothing
        Me.FoldersTreeView.ShowLines = False
        Me.FoldersTreeView.Size = New System.Drawing.Size(248, 398)
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
        Me.FoldersSize.SortOrder = System.Windows.Forms.SortOrder.Descending
        Me.FoldersSize.TooltipText = Nothing
        Me.FoldersSize.Width = 100
        '
        'FoldersX
        '
        Me.FoldersX.Header = "X"
        Me.FoldersX.Sortable = True
        Me.FoldersX.SortOrder = System.Windows.Forms.SortOrder.None
        Me.FoldersX.TooltipText = Nothing
        Me.FoldersX.Width = 25
        '
        'NodeTextBox1
        '
        Me.NodeTextBox1.DataPropertyName = "Text"
        Me.NodeTextBox1.IncrementalSearchEnabled = True
        Me.NodeTextBox1.LeftMargin = 3
        Me.NodeTextBox1.ParentColumn = Me.FoldersGroup
        '
        'NodeTextBox2
        '
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
        Me.NodeTextBox5.DataPropertyName = "Text"
        Me.NodeTextBox5.IncrementalSearchEnabled = True
        Me.NodeTextBox5.LeftMargin = 3
        Me.NodeTextBox5.ParentColumn = Me.ByNamesGroup
        '
        'NodeTextBox6
        '
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
        Me.TBName2.DataPropertyName = "Text"
        Me.TBName2.IncrementalSearchEnabled = True
        Me.TBName2.LeftMargin = 3
        Me.TBName2.ParentColumn = Nothing
        Me.TBName2.Trimming = System.Drawing.StringTrimming.EllipsisWord
        '
        'TBSize2
        '
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 529)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(952, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.StatusLabel.Text = "Ready"
        '
        'BottomPanel3
        '
        Me.BottomPanel3.AutoSize = True
        Me.BottomPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BottomPanel3.ColumnCount = 2
        Me.BottomPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BottomPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.BottomPanel3.Controls.Add(Me.Label4, 1, 1)
        Me.BottomPanel3.Controls.Add(Me.Label3, 1, 0)
        Me.BottomPanel3.Controls.Add(Me.ProgressBar2, 0, 0)
        Me.BottomPanel3.Controls.Add(Me.ProgressBar1, 0, 1)
        Me.BottomPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel3.Location = New System.Drawing.Point(0, 493)
        Me.BottomPanel3.Name = "BottomPanel3"
        Me.BottomPanel3.RowCount = 2
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.Size = New System.Drawing.Size(952, 36)
        Me.BottomPanel3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(927, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mb"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(927, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "#"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(3, 3)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(908, 12)
        Me.ProgressBar2.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 21)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(908, 12)
        Me.ProgressBar1.TabIndex = 6
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "zip"
        Me.SaveFileDialog1.FileName = Global.SelectiveFileCopy.My.MySettings.Default.SaveFilePath
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.RunToolStripMenuItem, Me.InfosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(952, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectSourceToolStripMenuItem, Me.SelectDestinationasFolderToolStripMenuItem, Me.SelectDestinationasZipFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.FileToolStripMenuItem.Text = "Source / Destination"
        '
        'SelectSourceToolStripMenuItem
        '
        Me.SelectSourceToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.OpenFolder_16x
        Me.SelectSourceToolStripMenuItem.Name = "SelectSourceToolStripMenuItem"
        Me.SelectSourceToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SelectSourceToolStripMenuItem.Text = "Select Source Folder"
        '
        'SelectDestinationasFolderToolStripMenuItem
        '
        Me.SelectDestinationasFolderToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.WelcomeSampleFolder_16x
        Me.SelectDestinationasFolderToolStripMenuItem.Name = "SelectDestinationasFolderToolStripMenuItem"
        Me.SelectDestinationasFolderToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SelectDestinationasFolderToolStripMenuItem.Text = "Select Destination (as Folder)"
        '
        'SelectDestinationasZipFileToolStripMenuItem
        '
        Me.SelectDestinationasZipFileToolStripMenuItem.Enabled = False
        Me.SelectDestinationasZipFileToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.FileDestination_16x
        Me.SelectDestinationasZipFileToolStripMenuItem.Name = "SelectDestinationasZipFileToolStripMenuItem"
        Me.SelectDestinationasZipFileToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SelectDestinationasZipFileToolStripMenuItem.Text = "Select Destination (as Zip File)"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyIncludesRootFolderToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'CopyIncludesRootFolderToolStripMenuItem
        '
        Me.CopyIncludesRootFolderToolStripMenuItem.Checked = True
        Me.CopyIncludesRootFolderToolStripMenuItem.CheckOnClick = True
        Me.CopyIncludesRootFolderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CopyIncludesRootFolderToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.GraphTopToBottom_16x
        Me.CopyIncludesRootFolderToolStripMenuItem.Name = "CopyIncludesRootFolderToolStripMenuItem"
        Me.CopyIncludesRootFolderToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CopyIncludesRootFolderToolStripMenuItem.Text = "Copy includes Root folder"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartCoypingSelectedFilesToolStripMenuItem, Me.PauseCopyToolStripMenuItem, Me.StopCopyToolStripMenuItem})
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'StartCoypingSelectedFilesToolStripMenuItem
        '
        Me.StartCoypingSelectedFilesToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.Run_16x
        Me.StartCoypingSelectedFilesToolStripMenuItem.Name = "StartCoypingSelectedFilesToolStripMenuItem"
        Me.StartCoypingSelectedFilesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.StartCoypingSelectedFilesToolStripMenuItem.Text = "Start copying selected Files"
        '
        'PauseCopyToolStripMenuItem
        '
        Me.PauseCopyToolStripMenuItem.Enabled = False
        Me.PauseCopyToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.Pause_16x
        Me.PauseCopyToolStripMenuItem.Name = "PauseCopyToolStripMenuItem"
        Me.PauseCopyToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.PauseCopyToolStripMenuItem.Text = "Pause copy"
        '
        'StopCopyToolStripMenuItem
        '
        Me.StopCopyToolStripMenuItem.Enabled = False
        Me.StopCopyToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.Stop_16x
        Me.StopCopyToolStripMenuItem.Name = "StopCopyToolStripMenuItem"
        Me.StopCopyToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.StopCopyToolStripMenuItem.Text = "Stop copy"
        '
        'InfosToolStripMenuItem
        '
        Me.InfosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiledestinationNotSelectedToolStripMenuItem, Me.FileAddedToolStripMenuItem, Me.FileUpdatedToolStripMenuItem, Me.IgnoredFileToolStripMenuItem, Me.FileIgnoredToolStripMenuItem, Me.ToolStripSeparator3, Me.FolderdestinationNotSelectedYetToolStripMenuItem, Me.NewFolderWillBeAddedToolStripMenuItem, Me.ExistingFolderWillBeUpdatedToolStripMenuItem, Me.IgnoredFolderToolStripMenuItem, Me.ExistingFolderWillBeDeletedToolStripMenuItem})
        Me.InfosToolStripMenuItem.Name = "InfosToolStripMenuItem"
        Me.InfosToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.InfosToolStripMenuItem.Text = "Infos"
        '
        'FileAddedToolStripMenuItem
        '
        Me.FileAddedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.AddFile_16x
        Me.FileAddedToolStripMenuItem.Name = "FileAddedToolStripMenuItem"
        Me.FileAddedToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.FileAddedToolStripMenuItem.Text = "New file, will be added"
        '
        'FileUpdatedToolStripMenuItem
        '
        Me.FileUpdatedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.UpdateFile_16x
        Me.FileUpdatedToolStripMenuItem.Name = "FileUpdatedToolStripMenuItem"
        Me.FileUpdatedToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.FileUpdatedToolStripMenuItem.Text = "Existing file, will be replaced"
        '
        'IgnoredFileToolStripMenuItem
        '
        Me.IgnoredFileToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.BlankFile_16x
        Me.IgnoredFileToolStripMenuItem.Name = "IgnoredFileToolStripMenuItem"
        Me.IgnoredFileToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.IgnoredFileToolStripMenuItem.Text = "Ignored file"
        '
        'FileIgnoredToolStripMenuItem
        '
        Me.FileIgnoredToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.DeleteFile_16
        Me.FileIgnoredToolStripMenuItem.Name = "FileIgnoredToolStripMenuItem"
        Me.FileIgnoredToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.FileIgnoredToolStripMenuItem.Text = "Existing file, will be deleted"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(260, 6)
        '
        'NewFolderWillBeAddedToolStripMenuItem
        '
        Me.NewFolderWillBeAddedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.AddFolder_16x
        Me.NewFolderWillBeAddedToolStripMenuItem.Name = "NewFolderWillBeAddedToolStripMenuItem"
        Me.NewFolderWillBeAddedToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.NewFolderWillBeAddedToolStripMenuItem.Text = "New folder, will be added"
        '
        'ExistingFolderWillBeUpdatedToolStripMenuItem
        '
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.UpdateFolder_16x
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Name = "ExistingFolderWillBeUpdatedToolStripMenuItem"
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.ExistingFolderWillBeUpdatedToolStripMenuItem.Text = "Existing folder, will be updated"
        '
        'IgnoredFolderToolStripMenuItem
        '
        Me.IgnoredFolderToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.IgnoredFolder_16x
        Me.IgnoredFolderToolStripMenuItem.Name = "IgnoredFolderToolStripMenuItem"
        Me.IgnoredFolderToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.IgnoredFolderToolStripMenuItem.Text = "Ignored folder"
        '
        'ExistingFolderWillBeDeletedToolStripMenuItem
        '
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.DeleteFolder_16x
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Name = "ExistingFolderWillBeDeletedToolStripMenuItem"
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.ExistingFolderWillBeDeletedToolStripMenuItem.Text = "Existing folder, will be deleted"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(952, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.SelectiveFileCopy.My.Resources.Resources.OpenFolder_16x
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SelectiveFileCopy.My.Resources.Resources.WelcomeSampleFolder_16x
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Enabled = False
        Me.ToolStripButton3.Image = Global.SelectiveFileCopy.My.Resources.Resources.DestinationAssistant_16x
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Checked = True
        Me.ToolStripButton4.CheckOnClick = True
        Me.ToolStripButton4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.SelectiveFileCopy.My.Resources.Resources.GraphTopToBottom_16x
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.SelectiveFileCopy.My.Resources.Resources.Run_16x
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Enabled = False
        Me.ToolStripButton6.Image = Global.SelectiveFileCopy.My.Resources.Resources.Pause_16x
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Enabled = False
        Me.ToolStripButton7.Image = Global.SelectiveFileCopy.My.Resources.Resources.Stop_16x
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'FiledestinationNotSelectedToolStripMenuItem
        '
        Me.FiledestinationNotSelectedToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.File_16x
        Me.FiledestinationNotSelectedToolStripMenuItem.Name = "FiledestinationNotSelectedToolStripMenuItem"
        Me.FiledestinationNotSelectedToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.FiledestinationNotSelectedToolStripMenuItem.Text = "File (destination not selected yet)"
        '
        'FolderdestinationNotSelectedYetToolStripMenuItem
        '
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Image = Global.SelectiveFileCopy.My.Resources.Resources.Folder_16x
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Name = "FolderdestinationNotSelectedYetToolStripMenuItem"
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.FolderdestinationNotSelectedYetToolStripMenuItem.Text = "Folder (destination not selected yet)"
        '
        'MainInfo
        '
        Me.MainInfo.Header = ""
        Me.MainInfo.SortOrder = System.Windows.Forms.SortOrder.None
        Me.MainInfo.TooltipText = Nothing
        Me.MainInfo.Width = 25
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 551)
        Me.Controls.Add(Me.CenterPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BottomPanel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Selective CopyFile"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.CenterPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ByTypesTab.ResumeLayout(False)
        Me.FoldersTab.ResumeLayout(False)
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
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents BottomPanel3 As TableLayoutPanel
    Friend WithEvents MainNb As Aga.Controls.Tree.TreeColumn
    Friend WithEvents TBNb As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectSourceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectDestinationasFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectDestinationasZipFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyIncludesRootFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartCoypingSelectedFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents InfosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileAddedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileUpdatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FileIgnoredToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IgnoredFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewFolderWillBeAddedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistingFolderWillBeUpdatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IgnoredFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistingFolderWillBeDeletedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseCopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopCopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiledestinationNotSelectedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderdestinationNotSelectedYetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainInfo As Aga.Controls.Tree.TreeColumn
End Class
