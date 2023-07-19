<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Me.InputDirPath = New System.Windows.Forms.TextBox()
        Me.inputDirBT = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeselectAllByExtensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselectAllByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllByExtensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TopPanel = New System.Windows.Forms.Panel()
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
        Me.destinationPathBTN = New System.Windows.Forms.Button()
        Me.destinationPathTBX = New System.Windows.Forms.TextBox()
        Me.startCopyBT = New System.Windows.Forms.Button()
        Me.BottomPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.destinationTypeCB = New System.Windows.Forms.ComboBox()
        Me.numberProgress = New System.Windows.Forms.ProgressBar()
        Me.sizeProgress = New System.Windows.Forms.ProgressBar()
        Me.fileDestBrowseDLG = New System.Windows.Forms.SaveFileDialog()
        Me.ByNamesGroup = New Aga.Controls.Tree.TreeColumn()
        Me.ByNamesSize = New Aga.Controls.Tree.TreeColumn()
        Me.ByNamesX = New Aga.Controls.Tree.TreeColumn()
        Me.NodeTextBox5 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeTextBox6 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.NodeCheckBox3 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.TBName2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBSize2 = New Aga.Controls.Tree.NodeControls.NodeTextBox()
        Me.TBSelection2 = New Aga.Controls.Tree.NodeControls.NodeCheckBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TopPanel.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'InputDirPath
        '
        Me.InputDirPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputDirPath.Location = New System.Drawing.Point(65, 12)
        Me.InputDirPath.Name = "InputDirPath"
        Me.InputDirPath.ReadOnly = True
        Me.InputDirPath.Size = New System.Drawing.Size(550, 20)
        Me.InputDirPath.TabIndex = 0
        '
        'inputDirBT
        '
        Me.inputDirBT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputDirBT.Location = New System.Drawing.Point(621, 10)
        Me.inputDirBT.Name = "inputDirBT"
        Me.inputDirBT.Size = New System.Drawing.Size(38, 23)
        Me.inputDirBT.TabIndex = 1
        Me.inputDirBT.Text = "..."
        Me.inputDirBT.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeselectAllByExtensionToolStripMenuItem, Me.DeselectAllByNameToolStripMenuItem, Me.SelectAllByExtensionToolStripMenuItem, Me.SelectAllByNameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 92)
        '
        'DeselectAllByExtensionToolStripMenuItem
        '
        Me.DeselectAllByExtensionToolStripMenuItem.Name = "DeselectAllByExtensionToolStripMenuItem"
        Me.DeselectAllByExtensionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DeselectAllByExtensionToolStripMenuItem.Text = "Deselect all by extension"
        '
        'DeselectAllByNameToolStripMenuItem
        '
        Me.DeselectAllByNameToolStripMenuItem.Name = "DeselectAllByNameToolStripMenuItem"
        Me.DeselectAllByNameToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DeselectAllByNameToolStripMenuItem.Text = "Deselect all by name"
        '
        'SelectAllByExtensionToolStripMenuItem
        '
        Me.SelectAllByExtensionToolStripMenuItem.Name = "SelectAllByExtensionToolStripMenuItem"
        Me.SelectAllByExtensionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SelectAllByExtensionToolStripMenuItem.Text = "Select all by extension"
        '
        'SelectAllByNameToolStripMenuItem
        '
        Me.SelectAllByNameToolStripMenuItem.Name = "SelectAllByNameToolStripMenuItem"
        Me.SelectAllByNameToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SelectAllByNameToolStripMenuItem.Text = "Select all by name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Source :"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(664, 14)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(119, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Include Root Folder"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.CheckBox1)
        Me.TopPanel.Controls.Add(Me.Label2)
        Me.TopPanel.Controls.Add(Me.InputDirPath)
        Me.TopPanel.Controls.Add(Me.inputDirBT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(952, 46)
        Me.TopPanel.TabIndex = 14
        '
        'CenterPanel
        '
        Me.CenterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CenterPanel.Controls.Add(Me.SplitContainer1)
        Me.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CenterPanel.Location = New System.Drawing.Point(0, 46)
        Me.CenterPanel.Name = "CenterPanel"
        Me.CenterPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.CenterPanel.Size = New System.Drawing.Size(952, 418)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(938, 404)
        Me.SplitContainer1.SplitterDistance = 671
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
        Me.MainTreeView.Model = Nothing
        Me.MainTreeView.Name = "MainTreeView"
        Me.MainTreeView.NodeControls.Add(Me.StateIcon)
        Me.MainTreeView.NodeControls.Add(Me.TBName)
        Me.MainTreeView.NodeControls.Add(Me.TBExtension)
        Me.MainTreeView.NodeControls.Add(Me.TBSize)
        Me.MainTreeView.NodeControls.Add(Me.CBSelection)
        Me.MainTreeView.NodeControls.Add(Me.TBNb)
        Me.MainTreeView.SelectedNode = Nothing
        Me.MainTreeView.Size = New System.Drawing.Size(671, 404)
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
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(263, 404)
        Me.TabControl1.TabIndex = 1
        '
        'FoldersTab
        '
        Me.FoldersTab.Controls.Add(Me.FoldersTreeView)
        Me.FoldersTab.Location = New System.Drawing.Point(4, 22)
        Me.FoldersTab.Name = "FoldersTab"
        Me.FoldersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FoldersTab.Size = New System.Drawing.Size(255, 378)
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
        Me.FoldersTreeView.Size = New System.Drawing.Size(249, 372)
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
        Me.ByTypesTab.Location = New System.Drawing.Point(4, 22)
        Me.ByTypesTab.Name = "ByTypesTab"
        Me.ByTypesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ByTypesTab.Size = New System.Drawing.Size(255, 378)
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
        Me.ByTypesTreeView.Size = New System.Drawing.Size(249, 372)
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
        'spring
        '
        Me.spring.Name = "spring"
        Me.spring.Size = New System.Drawing.Size(898, 17)
        Me.spring.Spring = True
        '
        'ProgressLabel2
        '
        Me.ProgressLabel2.Name = "ProgressLabel2"
        Me.ProgressLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'LoadUpdateTimer
        '
        Me.LoadUpdateTimer.Enabled = True
        Me.LoadUpdateTimer.Interval = 500
        '
        'destinationPathBTN
        '
        Me.destinationPathBTN.Location = New System.Drawing.Point(780, 3)
        Me.destinationPathBTN.Name = "destinationPathBTN"
        Me.destinationPathBTN.Size = New System.Drawing.Size(38, 23)
        Me.destinationPathBTN.TabIndex = 14
        Me.destinationPathBTN.Text = "..."
        Me.destinationPathBTN.UseVisualStyleBackColor = True
        '
        'destinationPathTBX
        '
        Me.destinationPathTBX.Location = New System.Drawing.Point(109, 3)
        Me.destinationPathTBX.Name = "destinationPathTBX"
        Me.destinationPathTBX.ShortcutsEnabled = False
        Me.destinationPathTBX.Size = New System.Drawing.Size(665, 20)
        Me.destinationPathTBX.TabIndex = 13
        '
        'startCopyBT
        '
        Me.startCopyBT.Location = New System.Drawing.Point(824, 3)
        Me.startCopyBT.Name = "startCopyBT"
        Me.BottomPanel3.SetRowSpan(Me.startCopyBT, 3)
        Me.startCopyBT.Size = New System.Drawing.Size(125, 58)
        Me.startCopyBT.TabIndex = 4
        Me.startCopyBT.Text = "Start copy"
        Me.startCopyBT.UseVisualStyleBackColor = True
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
        Me.BottomPanel3.Controls.Add(Me.destinationPathTBX, 1, 0)
        Me.BottomPanel3.Controls.Add(Me.destinationPathBTN, 2, 0)
        Me.BottomPanel3.Controls.Add(Me.Label4, 2, 2)
        Me.BottomPanel3.Controls.Add(Me.Label3, 2, 1)
        Me.BottomPanel3.Controls.Add(Me.startCopyBT, 3, 0)
        Me.BottomPanel3.Controls.Add(Me.destinationTypeCB, 0, 0)
        Me.BottomPanel3.Controls.Add(Me.numberProgress, 0, 1)
        Me.BottomPanel3.Controls.Add(Me.sizeProgress, 0, 2)
        Me.BottomPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel3.Location = New System.Drawing.Point(0, 464)
        Me.BottomPanel3.Name = "BottomPanel3"
        Me.BottomPanel3.RowCount = 3
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.BottomPanel3.Size = New System.Drawing.Size(952, 65)
        Me.BottomPanel3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(780, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mb"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(780, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "#"
        '
        'destinationTypeCB
        '
        Me.destinationTypeCB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.destinationTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.destinationTypeCB.FormattingEnabled = True
        Me.destinationTypeCB.Items.AddRange(New Object() {"Folder", "Zip File"})
        Me.destinationTypeCB.Location = New System.Drawing.Point(3, 3)
        Me.destinationTypeCB.Name = "destinationTypeCB"
        Me.destinationTypeCB.Size = New System.Drawing.Size(100, 21)
        Me.destinationTypeCB.TabIndex = 15
        '
        'numberProgress
        '
        Me.BottomPanel3.SetColumnSpan(Me.numberProgress, 2)
        Me.numberProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numberProgress.Location = New System.Drawing.Point(3, 32)
        Me.numberProgress.Name = "numberProgress"
        Me.numberProgress.Size = New System.Drawing.Size(771, 12)
        Me.numberProgress.TabIndex = 10
        '
        'sizeProgress
        '
        Me.BottomPanel3.SetColumnSpan(Me.sizeProgress, 2)
        Me.sizeProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sizeProgress.Location = New System.Drawing.Point(3, 50)
        Me.sizeProgress.Name = "sizeProgress"
        Me.sizeProgress.Size = New System.Drawing.Size(771, 12)
        Me.sizeProgress.TabIndex = 6
        '
        'fileDestBrowseDLG
        '
        Me.fileDestBrowseDLG.DefaultExt = "zip"
        Me.fileDestBrowseDLG.FileName = Global.SelectiveFileCopy.My.MySettings.Default.SaveFilePath
        Me.fileDestBrowseDLG.Filter = "Zip File|*.zip"
        Me.fileDestBrowseDLG.SupportMultiDottedExtensions = True
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
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 551)
        Me.Controls.Add(Me.CenterPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.BottomPanel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "MainWindow"
        Me.Text = "Selective CopyFile"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputDirPath As System.Windows.Forms.TextBox
    Friend WithEvents inputDirBT As System.Windows.Forms.Button
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FoldersTab As TabPage
    Friend WithEvents ByTypesTab As TabPage
    Friend WithEvents ByTypesTreeView As Aga.Controls.Tree.TreeViewAdv
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TopPanel As Panel
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
    Friend WithEvents startCopyBT As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents sizeProgress As ProgressBar
    Friend WithEvents numberProgress As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents destinationPathBTN As Button
    Friend WithEvents destinationPathTBX As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents BottomPanel3 As TableLayoutPanel
    Friend WithEvents MainNb As Aga.Controls.Tree.TreeColumn
    Friend WithEvents TBNb As Aga.Controls.Tree.NodeControls.NodeTextBox
    Friend WithEvents spring As ToolStripStatusLabel
    Friend WithEvents ProgressLabel2 As ToolStripStatusLabel
    Friend WithEvents LoadUpdateTimer As Timer
    Friend WithEvents fileDestBrowseDLG As SaveFileDialog
    Friend WithEvents destinationTypeCB As ComboBox
End Class
