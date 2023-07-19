
Public Class OnOff
    Inherits Aga.Controls.Tree.Node


    Private the_size As New Binary() With {.selectedSize = 0, .realSize = 0}
    Public RaiseEventFreezed As Boolean = False

    Public Sub New()

    End Sub

    Public Sub New(ByVal another As OnOff)
        the_size.realSize = another.RealSize
        the_size.selectedSize = another.SelectedSize
    End Sub

    Public Sub New(selectedSize As Double, realSize As Double)
        the_size.selectedSize = selectedSize
        the_size.realSize = realSize
    End Sub

    Public Event StatusChanged(ByRef before As OnOff, ByRef after As OnOff)

    Public Sub RaiseEventStatusChanged(before As OnOff)
        If Not RaiseEventFreezed Then
            RaiseEvent StatusChanged(before, Me)
            'MyBase.NotifyModel()
        End If
    End Sub

    Public Sub setSizes(selectedSize As Double, realSize As Double)
        If realSize < 0 Then realSize = 0
        If selectedSize < 0 Then selectedSize = 0
        If selectedSize <> Me.SelectedSize Or realSize <> Me.RealSize Then
            Dim before As New OnOff(Me)
            the_size.realSize = realSize
            the_size.selectedSize = selectedSize
            RaiseEventStatusChanged(before)
        End If
    End Sub

    Public Sub deltaSizes(deltaSelected As Double, deltaReal As Double)
        If deltaReal <> 0 Or deltaSelected <> 0 Then
            setSizes(SelectedSize + deltaSelected, RealSize + deltaReal)
        End If
    End Sub

    Public Overridable Property Selected As CheckState
        Get
            If SelectedSize = 0 Then Return CheckState.Unchecked '  TriState.False
            If SelectedSize = RealSize Then Return CheckState.Checked ' TriState.True
            Return CheckState.Indeterminate ' TriState.UseDefault
        End Get

        Set(value As CheckState)
            Select Case value
                Case CheckState.Unchecked 'TriState.False
                    setSizes(0, RealSize)
                Case CheckState.Checked 'TriState.True
                    setSizes(RealSize, RealSize)
                Case CheckState.Indeterminate 'TriState.UseDefault
            End Select
        End Set
    End Property

    Public ReadOnly Property Size As Binary
        Get
            Return the_size
        End Get
    End Property

    Public Property SelectedSize As Double
        Get
            Return the_size.selectedSize
        End Get
        Set(value As Double)
            If SelectedSize <> value Then
                Dim before As New OnOff(Me)
                the_size.selectedSize = value
                RaiseEventStatusChanged(before)
            End If
        End Set
    End Property

    Public Property RealSize As Double
        Get
            Return the_size.realSize
        End Get
        Set(value As Double)
            If RealSize <> value Then
                Dim before As New OnOff(Me)
                the_size.realSize = value
                RaiseEventStatusChanged(before)
            End If
        End Set
    End Property

    Public Function SizeToString(ByVal the_size As Long) As String
        If the_size < 1024 Then Return the_size.ToString & " o"
        If the_size < 1048576L Then Return (1.0 * the_size / 1024).ToString("0.00 ko")
        If the_size < 1073741824L Then Return (1.0 * the_size / 1048576L).ToString("0.00 Mo")
        Return (1.0 * the_size / 1073741824L).ToString("0.00 Go")
    End Function

    Public ReadOnly Property SizeDisplay As String
        Get
            If SelectedSize = 0 Then Return "- / " & SizeToString(RealSize)
            If SelectedSize = RealSize Then Return SizeToString(SelectedSize)
            Return SizeToString(SelectedSize) & " / " & SizeToString(RealSize)
        End Get
    End Property

    Public Overridable ReadOnly Property CountSelected As Integer
        Get
            If Selected = Windows.Forms.CheckState.Unchecked Then Return 0
            Return Count
        End Get
    End Property

    Private _count As Integer = 0
    Public Overridable Property Count As Integer
        Get
            Return _count
        End Get
        Set(value As Integer)
            _count = value
        End Set
    End Property

    Public Overridable ReadOnly Property DisplayedCount As String
        Get
            Return _count.ToString()
        End Get
    End Property

End Class
