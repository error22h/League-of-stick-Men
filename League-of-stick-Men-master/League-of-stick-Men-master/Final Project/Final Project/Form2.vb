Public Class Form2
    'Dim xspeed As Double = 3
    Dim yspeed As Double
    Dim player_yspeed As Double
    Dim gravity As Double = 0.5
    Dim x_speed(3) As Double
    Dim ghost_pb(3) As PictureBox
    Dim n As Integer = 1

    Dim t As Integer
   
    Private Sub tmr_ghost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_ghost.Tick

        ghost_pb(0).Location = ghost1.Location
        ghost_pb(1).Location = ghost2.Location
        ghost_pb(2).Location = ghost3.Location
        ghost_pb(3).Location = ghost4.Location

        

        

        For Each black_blocks In Me.Controls
            For Each ghosts In Me.Controls
                If black_blocks.name.ToString.Contains("black_block") Then
                    If ghosts.name.ToString.Contains("ghost") Then
                        If ghosts.Bounds.IntersectsWith(black_blocks.bounds) Then
                            If ghosts.Bottom >= black_blocks.top Then
                                'ghosts.Top = black_blocks.top - ghost1.Height
                                n = 0

                                ghosts.TOP += -20
                                yspeed = 3
                                'player_yspeed = 2

                                'tmr_jump.Start()


                            End If

                        End If

                    End If
                End If

            Next
        Next

        yspeed += gravity
        player_yspeed += 0.7 * gravity * n
        For i = 0 To 3
            ghost_buster.Top += player_yspeed


            ghost_pb(i).Left += x_speed(i)
            ghost_pb(i).Top += yspeed

            If x_speed(i) > 0 Then
                ghost_pb(i).Image = My.Resources.ghost_right
            ElseIf x_speed(i) < 0 Then
                ghost_pb(i).Image = My.Resources.ghost_left
            End If


            If ghost_pb(i).Left < 0 Then
                If x_speed(i) < 0 Then
                    If x_speed(i) < -7 Then
                        x_speed(i) *= -1
                    Else
                        x_speed(i) -= 2
                        x_speed(i) *= -1
                        yspeed += 0.5
                    End If
                End If
            ElseIf ghost_pb(i).Left + 55 > Me.Width Then
                If x_speed(i) > 0 Then
                    If x_speed(i) > 7 Then
                        x_speed(i) *= -1
                    Else
                        x_speed(i) += 2
                        x_speed(i) *= -1
                        yspeed += 0.5
                    End If
                End If
            End If
        Next

        ghost1.Location = ghost_pb(0).Location
        ghost2.Location = ghost_pb(1).Location
        ghost3.Location = ghost_pb(2).Location
        ghost4.Location = ghost_pb(3).Location

    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            tmr_ghost.Start()
        End If

       
        If e.KeyCode = Keys.D Then
            ghost_buster.Left += 10

        ElseIf e.KeyCode = Keys.A Then
            ghost_buster.Left -= 10
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

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        x_speed(0) = 3
        x_speed(1) = 3
        x_speed(2) = 3
        x_speed(3) = 3
        ghost_pb(0) = ghost1
        ghost_pb(1) = ghost2
        ghost_pb(2) = ghost3
        ghost_pb(3) = ghost4
        Label1.Text = fighter_name
    End Sub
End Class