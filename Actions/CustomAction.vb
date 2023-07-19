Imports System.ComponentModel

Public Class CustomAction

    Private _text As String = ""
    Private _image As Image = Nothing
    Private _tip As String = ""
    Private _enabled As Boolean = True
    Private _checked As Boolean = False

    Public Sub RegisterTo(tsi As ToolStripItem)

        ' TODO: use an intermediate class to link each Component to the CustomAction
        ' so that RemoveHandler can be properly done...
        ' (or a List(Of Component), maybe...

        Dim sync_sub = Sub()
                           SynchroniseWith(tsi)
                       End Sub
        sync_sub()

        AddHandler tsi.Click, AddressOf OnComponentClicked
        AddHandler tsi.TextChanged, AddressOf OnComponentTextChanged

        AddHandler Me.OnImageChanged, sync_sub
        AddHandler Me.OnTextChanged, sync_sub
        AddHandler Me.OnTooltipChanged, sync_sub
        AddHandler Me.OnEnableChanged, sync_sub
        If TypeOf tsi Is ToolStripMenuItem Then
            AddHandler Me.OnCheckChanged, sync_sub
        ElseIf TypeOf tsi Is ToolStripButton Then
            AddHandler Me.OnCheckChanged, sync_sub
        End If

    End Sub

    Protected Sub SynchroniseWith(tsi As ToolStripItem)
        tsi.Image = Me.Image
        tsi.Text = Me.Text
        tsi.ToolTipText = Me.Tooltip
        tsi.Enabled = Me.Enabled
        If TypeOf tsi Is ToolStripMenuItem Then
            CType(tsi, ToolStripMenuItem).Checked = Me.Checked
        ElseIf TypeOf tsi Is ToolStripButton Then
            CType(tsi, ToolStripButton).Checked = Me.Checked
        End If
    End Sub

    Public Sub UnregisterFrom(tsi As ToolStripItem)

        tsi.Image = Nothing
        tsi.Text = ""
        tsi.ToolTipText = ""
        tsi.Enabled = False
        RemoveHandler tsi.Click, AddressOf OnComponentClicked
        'RemoveHandler Me.OnImageChanged, Sub()
        '                                     cp.Image = Me.Image
        '                                 End Sub
        'RemoveHandler Me.OnTextChanged, Sub()
        '                                    cp.Text = Me.Text
        '                                End Sub
        'RemoveHandler Me.OnTooltipChanged, Sub()
        '                                       cp.ToolTipText = Me.Tooltip
        '                                   End Sub

    End Sub

    Protected Sub OnComponentTextChanged(sender As Object, ev As EventArgs)
        Me.Text = sender.Text
    End Sub

    Protected Sub OnComponentClicked(sender As Object, ev As EventArgs)
        RaiseEvent OnActionStart(Me, ev)
    End Sub

    Public Property Image As Image
        Get
            Return _image
        End Get
        Set(value As Image)
            If _image IsNot value Then
                _image = value
                RaiseEvent OnImageChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            If _text <> value Then
                _text = value
                RaiseEvent OnTextChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Property Tooltip As String
        Get
            Return _tip
        End Get
        Set(value As String)
            If _tip <> value Then
                _tip = value
                RaiseEvent OnTooltipChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Property Enabled As Boolean
        Get
            Return _enabled
        End Get
        Set(value As Boolean)
            If _enabled <> value Then
                _enabled = value
                RaiseEvent OnEnableChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            If _checked <> value Then
                _checked = value
                RaiseEvent OnCheckChanged(Me, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Event OnEnableChanged(ByVal sender As CustomAction, ByVal args As EventArgs)
    Public Event OnCheckChanged(ByVal sender As CustomAction, ByVal args As EventArgs)
    Public Event OnImageChanged(ByVal sender As CustomAction, ByVal args As EventArgs)
    Public Event OnTextChanged(ByVal sender As CustomAction, ByVal args As EventArgs)
    Public Event OnTooltipChanged(ByVal sender As CustomAction, ByVal args As EventArgs)

    Public Event OnActionStart(ByVal sender As CustomAction, ByVal args As EventArgs)

End Class
