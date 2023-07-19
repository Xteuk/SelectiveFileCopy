Public Class NameComparer
    Implements System.Collections.IComparer

    Public Sub New()
    End Sub

    Public Property SortOrder As SortOrder = SortOrder.Ascending

    Public Function Compare(x As Object, y As Object) _
    As Integer _
    Implements System.Collections.IComparer.Compare
        Dim result As Integer = 0
        If TypeOf (x) Is OnOff And TypeOf (y) Is OnOff Then
            result = x.Text.CompareTo(y.Text)
        Else
            result = String.Compare(x.Text, y.Text)
        End If

        If SortOrder = SortOrder.Ascending Then
            Return result
        Else
            Return -result
        End If
    End Function
End Class

