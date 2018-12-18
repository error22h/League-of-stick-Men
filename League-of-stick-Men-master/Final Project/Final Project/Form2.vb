Public Class Form2
    Dim xspeed As Double = 3
    Dim yspeed As Double
    Dim gravity As Double = 0.4
    Dim t As Integer
   
    Private Sub tmr_ghost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_ghost.Tick
        Dim ghost(3) As Point
        ghost(0) = ghost1.Location
        ghost(1) = ghost2.Location
        ghost(2) = ghost3.Location
        ghost(3) = ghost4.Location
        For j = 0 To 0
            yspeed += gravity
            For i = 0 To 3
                ghost(i).X += xspeed
                ghost(i).Y += yspeed
                If ghost(i).X < 0 Then
                    If xspeed < 0 Then
                        xspeed *= -1
                    End If
                ElseIf ghost(i).X + 55 > Me.Width Then
                    If xspeed > 0 Then
                        xspeed *= -1
                    End If
                End If
            Next

        Next
        ghost1.Location = ghost(0)
        ghost2.Location = ghost(1)
        ghost3.Location = ghost(2)
        ghost4.Location = ghost(3)

        For Each black_blocks In Me.Controls
            For Each ghosts In Me.Controls
                If black_blocks.name.ToString.Contains("black_block") Then
                    If ghosts.name.ToString.Contains("ghost") Then
                        If ghosts.Bounds.IntersectsWith(black_blocks.bounds) Then
                            If ghosts.Bottom > black_blocks.top Then
                                'ghosts.Top = black_blocks.top - ghost1.Height
                                ghosts.top += -20
                                yspeed = 3
                                'tmr_jump.Start()
                            End If
                        End If
                    End If
                End If
                If xspeed > 0 Then
                    ghosts.image = My.Resources.ghost_right
                Else
                    ghosts.image = My.Resources.ghost_left
                End If
            Next
        Next
    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            tmr_ghost.Start()
        End If
    End Sub
    
    Private Sub tmr_jump_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_jump.Tick
        t += 1
        If t < 5 Then
            yspeed -= 3
        Else
            t = 0
            tmr_jump.Stop()
            yspeed = 0
        End If
    End Sub
End Class