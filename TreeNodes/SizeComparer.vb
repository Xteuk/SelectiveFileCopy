Public Class SizeComparer
    Implements System.Collections.IComparer

    Private onRealSize As Boolean
    Public Sub New(Optional ByVal onRealSize As Boolean = False)
        Me.onRealSize = onRealSize
    End Sub

    Public Property SortOrder As SortOrder = SortOrder.Ascending

    Public Function Compare(x As Object, y As Object) _
    As Integer _
    Implements System.Collections.IComparer.Compare
        If TypeOf (x) Is OnOff And TypeOf (y) Is OnOff Then
            Dim delta As Double = 0
            If onRealSize Then
                delta = CType(y, OnOff).RealSize - CType(x, OnOff).RealSize
            Else
                delta = CType(y, OnOff).SelectedSize - CType(x, OnOff).SelectedSize
                If delta = 0 Then delta = CType(y, OnOff).RealSize - CType(x, OnOff).RealSize
            End If
            If delta = 0 Then delta = x.Text.CompareTo(y.Text)
            If delta < 0 Then
                Return If(SortOrder = SortOrder.Ascending, -1, 1)
            Else
                Return If(SortOrder = SortOrder.Ascending, 1, -1)
            End If
        End If
        Return String.Compare(x.Text, y.Text)
    End Function
End Class

