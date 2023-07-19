
Public Class SigmaOnOff
    Inherits OnOff

    Private total As Integer = 0
    Protected list As New List(Of OnOff)
    Private recomputing As Boolean = False

    Public Sub Add(ByVal one As OnOff, Optional ByVal with_node As Boolean = True)
        list.Add(one)
        If with_node Then
            SyncLock MyBase.Nodes
                MyBase.Nodes.Add(one)
            End SyncLock
        End If
        deltaSizes(one.SelectedSize, one.RealSize)
        AddHandler one.StatusChanged, AddressOf ElementChanged
    End Sub

    Public Sub Recompute(Optional ByVal recompute_children As Boolean = False)
        recomputing = True
        Dim total As New Binary
        Try
            For Each element As OnOff In list
                If recompute_children And TypeOf (element) Is SigmaOnOff Then
                    CType(element, SigmaOnOff).Recompute(True)
                End If
                total += element.Size
            Next
        Finally
            recomputing = False
        End Try
        setSizes(total.selectedSize, total.realSize)
    End Sub

    Private Sub ElementChanged(ByRef before As OnOff, ByRef now As OnOff)
        If Not recomputing Then _
            deltaSizes(now.SelectedSize - before.SelectedSize, now.RealSize - before.RealSize)
    End Sub

    Public Overrides Property Selected As System.Windows.Forms.CheckState
        Get
            Return MyBase.Selected
        End Get
        Set(value As System.Windows.Forms.CheckState)
            If value <> Selected Then
                recomputing = True
                Try
                    If value <> Windows.Forms.CheckState.Indeterminate Then
                        For Each child As OnOff In list
                            child.Selected = value
                        Next
                    End If
                Finally
                    recomputing = False
                End Try
                MyBase.Selected = value
            End If
        End Set
    End Property

    Public Overrides ReadOnly Property CountSelected As Integer
        Get
            If Selected = Windows.Forms.CheckState.Unchecked Then Return 0
            Return list.Sum(Function(x) x.CountSelected) + 1
        End Get
    End Property

End Class
