Public Class Form1
 
    Private Sub start_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles start.MouseEnter
        start.ForeColor = Color.Red
    End Sub

    Private Sub start_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles start.MouseLeave
        start.ForeColor = Color.Black
    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
