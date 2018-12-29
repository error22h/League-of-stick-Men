Public Class Form2
    'Dim xspeed As Double = 3
    Dim yspeed As Double
    Dim player_yspeed As Double
    Dim gravity As Double = 0.5
    Dim x_speed(3) As Double
    Dim ghost_pb(3) As PictureBox
    Dim n As Integer = 1
    Dim blackblocks(10) As PictureBox
    Dim blackblocks_yspeed As Double
    Dim t(8) As Integer
    Dim u As Integer
    Dim l_ghost As Point
    Dim location1(2) As Point
    Dim location2(2) As Point
    Dim location3(2) As Point
    Dim location4(2) As Point
    Dim k As Integer


   
    Private Sub tmr_ghost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_ghost.Tick

        ghost_pb(0).Location = ghost1.Location
        ghost_pb(1).Location = ghost2.Location
        ghost_pb(2).Location = ghost3.Location
        ghost_pb(3).Location = ghost4.Location

        lbl_playerName.Top = player.Top - lbl_playerName.Height
        lbl_playerName.Left = player.Left - lbl_playerName.Width / 2 + player.Width / 2 - 10


        

        For Each black_blocks In Me.Controls
            For Each ghosts In Me.Controls
                If black_blocks.name.ToString.Contains("black_block") Then
                    If ghosts.name.ToString.Contains("ghost") Then
                        If ghosts.Bounds.IntersectsWith(black_blocks.bounds) Then
                            If ghosts.Bottom >= black_blocks.top Then
                                ghosts.Top = black_blocks.top - ghost1.Height
                                ' n = 0
                                'player_yspeed = 0
                                'ghosts.TOP += -20
                                yspeed = 3
                                'player_yspeed = 2

                                'tmr_jump.Start()
                            End If
                        End If
                    End If


                    'If player.Bounds.IntersectsWith(black_blocks.bounds) Then
                    '    n = 0
                    '    If player.Bottom >= black_blocks.top Then

                    '        player_yspeed = 0
                    '        player.Top = black_blocks.top - player.Height

                    '    End If

                    'Else
                    '    If player.Bottom < black_blocks.top - 1 Then
                    '        n = 1
                    '    End If

                    'End If




                End If
            Next
        Next

        yspeed += gravity
        player_yspeed += 0.7 * gravity * n
        For i = 0 To 3
            player.Top += player_yspeed


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




        For i = 0 To 10
            If player.Bounds.IntersectsWith(blackblocks(i).Bounds) Then
                n = 0
                If player.Bottom >= blackblocks(i).Top Then

                    player_yspeed = 0
                    player.Top = blackblocks(i).Top - player.Height
                End If

            Else
                If player.Bottom < blackblocks(i).Top - 1 Then
                    n = 1
                End If

            End If
        Next




    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            tmr_ghost.Start()
            tmr_blackblocks.Start()
        End If
        

        If e.KeyCode = Keys.D And tmr_ghost.Enabled = True Then
            If player.Left >= 1062 Then
                player.Left = 1062
            Else
                player.Left += 10
                lbl_playerName.Left += 10
            End If

        ElseIf e.KeyCode = Keys.A And tmr_ghost.Enabled Then
            If player.Left <= 140 Then
                player.Left = 140
            Else
                player.Left -= 10
                lbl_playerName.Left -= 10
            End If

        ElseIf e.KeyCode = Keys.W And tmr_ghost.Enabled Then
            If player_yspeed = 0 Then
                player_yspeed = -5

            End If
        End If


        If e.KeyCode = Keys.K Then
            'For Each ghosts In Me.Controls
            '    If ghosts.name.ToString.Contains("ghost") Then
            '        If player.Bounds.IntersectsWith(ghosts.Bounds) Then

            Randomize()
            k = Int((2 * Rnd()) + 0)
            If player.Bounds.IntersectsWith(ghost1.Bounds) Then
                If k = 0 Then
                    ghost1.Left = 1261
                ElseIf k = 1 Then
                    ghost1.Left = -56
                Else
                    ghost1.Left = -128
                End If
            End If
            Randomize()
            k = Int((2 * Rnd()) + 0)
            If player.Bounds.IntersectsWith(ghost2.Bounds) Then
                If k = 0 Then
                    ghost2.Left = 1469
                ElseIf k = 1 Then
                    ghost2.Left = -177
                Else
                    ghost2.Left = 1521
                End If
            End If
            Randomize()
            k = Int((2 * Rnd()) + 0)
            If player.Bounds.IntersectsWith(ghost3.Bounds) Then
                If k = 0 Then
                    ghost3.Left = 1625
                ElseIf k = 1 Then
                    ghost3.Left = -200
                Else
                    ghost3.Left = -270
                End If
            End If

            Randomize()
            k = Int((2 * Rnd()) + 0)
            If player.Bounds.IntersectsWith(ghost4.Bounds) Then
                If k = 0 Then
                    ghost4.Left = 1729
                ElseIf k = 1 Then
                    ghost4.Left = 1833
                Else
                    ghost4.Left = -320
                End If
            End If

        End If
        '        End If
        '    Next
        'End If

    End Sub
    
    Private Sub tmr_blackblocks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_blackblocks.Tick
        u += 1
        If u > 20 Then


            For Each F_black_blocks In Me.Controls
                If F_black_blocks.name.ToString.Contains("F_black_block") Then


                    For i = 0 To 8

                        If blackblocks(i).Top < 400 Then
                            blackblocks(i).Top = 400
                            t(i) += 1
                        ElseIf blackblocks(i).Top > 610 Then
                            blackblocks(i).Top = 610
                            t(i) += 1

                        End If

                        If (t(i) Mod 2) = 0 Then

                            Randomize()
                            blackblocks(i).Top -= Int((10 * Rnd()) + 1) * blackblocks_yspeed
                        Else

                            Randomize()
                            blackblocks(i).Top += Int((10 * Rnd()) + 1) * blackblocks_yspeed
                        End If

                    Next
                End If
            Next
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
        lbl_playerName.Text = fighter_name


        blackblocks(0) = F_black_block1
        blackblocks(1) = F_black_block2
        blackblocks(2) = F_black_block3
        blackblocks(3) = F_black_block4
        blackblocks(4) = F_black_block5
        blackblocks(5) = F_black_block6
        blackblocks(6) = F_black_block7
        blackblocks(7) = F_black_block10
        blackblocks(8) = F_black_block11
        blackblocks(9) = black_block8
        blackblocks(10) = black_block9

        blackblocks_yspeed = 0.06

        t(0) = 1
        t(1) = 1
        t(2) = 1
        t(3) = 1
        t(4) = 1
        t(5) = 1
        t(6) = 1
        t(7) = 1
        t(8) = 1

        location1(0).X = 1261
        location1(1).X = 1313
        location1(2).X = 1365
        location2(0).X = 1417
        location2(1).X = 1469
        location2(2).X = 1521
        location3(0).X = 1573
        location3(1).X = 1625
        location3(2).X = 1677
        location4(0).X = 1729
        location4(1).X = 1781
        location4(2).X = 1833

        lbl_playerName.Left = player.Left - lbl_playerName.Width / 2 + player.Width / 2 - 10

        Randomize()
        k = Int((3 * Rnd()) + 0)
        Label1.Text = k
        If player.Bounds.IntersectsWith(ghost1.Bounds) Then
            If k = 0 Then
                ghost1.Left = 1261
            ElseIf k = 1 Then
                ghost1.Left = -56
            Else
                ghost1.Left = -128
            End If
        End If
       
        If player.Bounds.IntersectsWith(ghost2.Bounds) Then
            If k = 0 Then
                ghost2.Left = 1469
            ElseIf k = 1 Then
                ghost2.Left = -177
            Else
                ghost2.Left = 1521
            End If
        End If
        
        If player.Bounds.IntersectsWith(ghost3.Bounds) Then
            If k = 0 Then
                ghost3.Left = 1625
            ElseIf k = 1 Then
                ghost3.Left = -200
            Else
                ghost3.Left = -270
            End If
        End If

        
        If player.Bounds.IntersectsWith(ghost4.Bounds) Then
            If k = 0 Then
                ghost4.Left = 1729
            ElseIf k = 1 Then
                ghost4.Left = 1833
            Else
                ghost4.Left = -320
            End If
        End If

    End Sub

    Private Sub tmr_k_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_k.Tick
        Randomize()
        k = Int((3 * Rnd()) + 0)
        Label1.Text = k
    End Sub
End Class