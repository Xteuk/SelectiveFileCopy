Public Class Helper

    Public Shared Function GetRelativePath(root As String, path As String) As String
        If path.StartsWith(root, StringComparison.InvariantCultureIgnoreCase) Then
            path = path.Substring(root.Length)
            If path.StartsWith("\") Then
                path = path.Substring(1)
                Return path
            End If
        End If
        Return path
    End Function


End Class
