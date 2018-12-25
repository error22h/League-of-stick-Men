Public Class Form1
    Private Sub start_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles start.MouseEnter
        start.ForeColor = Color.Red
    End Sub

    Private Sub start_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles start.MouseLeave
        start.ForeColor = Color.Black
    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        If TextBox1.Text = "" Then
            MsgBox("Please choose your fighter name!") '(MsgBoxStyle.Exclamation))
        Else
            fighter_name = TextBox1.Text
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class
