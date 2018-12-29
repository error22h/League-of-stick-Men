Public Class Form1
    Dim t(17) As Integer
    Dim blackblocks(17) As PictureBox
    Dim F_blackblocks_yspeed As Double = 0.06
    Dim T_blackblocks_yspeed As Double = -0.06
    Private Sub start_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles start.MouseEnter
        start.ForeColor = Color.Red
    End Sub

    Private Sub start_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles start.MouseLeave
        start.ForeColor = Color.Black
    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        If TextBox1.Text = "" Then
            MsgBox("Please choose your fighter name!")
        ElseIf TextBox1.Text = "MC-Maor" Then
            MsgBox("Good Luck Maor!!!")
            fighter_name = TextBox1.Text
            Me.Hide()
            Form2.Show()
        ElseIf TextBox1.Text.Length > 10 Then
            MsgBox("This name is too long :( Please choose shorter name")
            'ElseIf TextBox1.Text.Contains "h" Then

        Else
            fighter_name = TextBox1.Text
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blackblocks(0) = F_black_block1
        blackblocks(1) = F_black_block2
        blackblocks(2) = F_black_block3
        blackblocks(3) = F_black_block4
        blackblocks(4) = F_black_block5
        blackblocks(5) = F_black_block6
        blackblocks(6) = F_black_block7
        blackblocks(7) = F_black_block10
        blackblocks(8) = F_black_block11
        blackblocks(9) = T_black_block12
        blackblocks(10) = T_black_block13
        blackblocks(11) = T_black_block14
        blackblocks(12) = T_black_block15
        blackblocks(13) = T_black_block16
        blackblocks(14) = T_black_block17
        blackblocks(15) = T_black_block18
        blackblocks(16) = T_black_block19
        blackblocks(17) = T_black_block20
       
        t(0) = 1
        t(1) = 1
        t(2) = 1
        t(3) = 1
        t(4) = 1
        t(5) = 1
        t(6) = 1
        t(7) = 1
        t(8) = 1
        t(9) = 1
        t(10) = 1
        t(11) = 1
        t(12) = 1
        t(13) = 1
        t(14) = 1
        t(15) = 1
        t(16) = 1
        t(17) = 1
    End Sub

    Private Sub tmr_blackblocks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_blackblocks.Tick



        For Each F_black_blocks In Me.Controls
            If F_black_blocks.name.ToString.Contains("F_black_block") Then


                For i = 0 To 8

                    If blackblocks(i).Top < 400 Then
                        blackblocks(i).Top = 400
                        t(i) += 1
                    ElseIf blackblocks(i).Top > 550 Then
                        blackblocks(i).Top = 550
                        t(i) += 1

                    End If

                    If (t(i) Mod 2) = 0 Then

                        Randomize()
                        blackblocks(i).Top -= Int((10 * Rnd()) + 1) * F_blackblocks_yspeed
                    Else

                        Randomize()
                        blackblocks(i).Top += Int((10 * Rnd()) + 1) * F_blackblocks_yspeed
                    End If

                Next
            End If
        Next

        For Each F_black_blocks In Me.Controls
            If F_black_blocks.name.ToString.Contains("T_black_block") Then


                For i = 9 To 17

                    If blackblocks(i).Bottom < 100 Then
                        blackblocks(i).Top = 100 - blackblocks(i).Height
                        t(i) += 1
                    ElseIf blackblocks(i).Bottom > 200 Then
                        blackblocks(i).Top = 200 - blackblocks(i).Height
                        t(i) += 1

                    End If

                    If (t(i) Mod 2) = 0 Then

                        Randomize()
                        blackblocks(i).Top -= Int((10 * Rnd()) + 1) * T_blackblocks_yspeed
                    Else

                        Randomize()
                        blackblocks(i).Top += Int((10 * Rnd()) + 1) * T_blackblocks_yspeed
                    End If

                Next
            End If
        Next

    End Sub
End Class
