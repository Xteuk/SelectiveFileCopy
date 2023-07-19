Public Class ActionToolstripMenuItem

    Private _action As CustomAction

    Public Property Action As CustomAction
        Get
            Return _action
        End Get
        Set(value As CustomAction)
            If _action IsNot Nothing Then
                _action.UnregisterFrom(Me)
            End If
            _action = value
            If value IsNot Nothing Then
                value.RegisterTo(Me)
            End If
        End Set
    End Property

End Class
