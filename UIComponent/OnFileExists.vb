Public Class OnFileExists

    Enum Choice
        Overwrite
        AlwaysOverwrite
        DontOverwrite
        NeverOverwrite
        StopEverything
    End Enum

    Private the_selection As Choice = Choice.Overwrite

    Public Property Selection As Choice
        Get
            Return the_selection
        End Get
        Set(value As Choice)
            the_selection = value
        End Set
    End Property

    Public Property Message As String
        Get
            Return TextBox1.Text
        End Get
        Set(value As String)
            TextBox1.Text = value
        End Set
    End Property

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Selection = Choice.Overwrite
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Selection = Choice.AlwaysOverwrite
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Selection = Choice.DontOverwrite
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Selection = Choice.NeverOverwrite
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Selection = Choice.StopEverything
        Me.Hide()
    End Sub

    Private Sub OnFileExists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.iconfinder_move_to_folder_64482
    End Sub
End Class
