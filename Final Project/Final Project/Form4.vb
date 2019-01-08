Public Class Form4
    'Dim xspeed As Double = 3
    Dim robots_yspeed As Double
    Dim yspeed As Double
    Dim player_yspeed As Double
    Dim gravity As Double = 0.5
    Dim player_xspeed As Double
    Dim robots_xspeed(1) As Double
    Dim robot_pb(1) As PictureBox
    Dim x_speed(1) As Double
    Dim ghost_pb(1) As PictureBox
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
    Dim max As Double
    Dim min As Double
    'Dim ghosts_for_lvl(3) As PictureBox
    Dim tmr_ghostattac As Integer = 0
    Dim player_pb As Integer = 0
    Dim tmr_kick As Integer = 0
    Dim player_kick_pb As Integer '=0
    'Dim timer_tick As Integer = 0

    Private Sub tmr_ghost_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_ghost.Tick
        


        If player.Left >= 1123 - player.Width Then
            player.Left = 1123 - player.Width

        ElseIf player.Left <= 140 Then
            player.Left = 140

        End If



        ghost_pb(0).Location = ghost1.Location
        ghost_pb(1).Location = ghost2.Location
        robot_pb(0).Location = robot_elad.Location
        robot_pb(1).Location = robot_leon.Location

        lbl_playerName.Top = player.Top - lbl_playerName.Height
        lbl_playerName.Left = player.Left - lbl_playerName.Width / 2 + player.Width / 2 - 10
        lbl_EladName.Top = robot_elad.Top - lbl_EladName.Height
        lbl_EladName.Left = robot_elad.Left - lbl_EladName.Width / 2 + robot_elad.Width / 2 + 11
        lbl_LeonName.Top = robot_leon.Top - lbl_LeonName.Height
        lbl_LeonName.Left = robot_leon.Left - lbl_LeonName.Width / 2 + robot_leon.Width / 2 + 11
        lbl_MaorName.Top = ghost1.Top - lbl_MaorName.Height
        lbl_MaorName.Left = ghost1.Left - lbl_MaorName.Width / 2 + ghost1.Width / 2 + 4
        lbl_AmitName.Top = ghost2.Top - lbl_AmitName.Height
        lbl_AmitName.Left = ghost2.Left - lbl_AmitName.Width / 2 + ghost2.Width / 2 + 4

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
            For Each robots In Me.Controls
                If black_blocks.name.ToString.Contains("black_block") Then
                    If robots.name.ToString.Contains("robot") Then
                        If robots.bounds.intersectswith(black_blocks.bounds) Then
                            If robots.bottom >= black_blocks.top Then
                                robots.top = black_blocks.top - robot_elad.Height
                                robots_yspeed = 3
                            End If
                        End If
                    End If
                End If
            Next
        Next

        If player_xspeed > 0 Then
            player.Image = My.Resources.Stickman___Normal_stand_at_fight__right_
            player_xspeed -= 2
        ElseIf player_xspeed < 0 Then
            player.Image = My.Resources.Stickman___Normal_stand_at_fight__left_
            player_xspeed += 2

        End If
        player.Left += player_xspeed
        If player.Left >= 1123 - player.Width Then
            player.Left = 1123 - player.Width

        ElseIf player.Left <= 140 Then
            player.Left = 140

        End If
        robots_yspeed += gravity
        yspeed += gravity
        player_yspeed += 0.7 * gravity * n

        For i = 0 To 1
            player.Top += player_yspeed
            robot_pb(i).Left += robots_xspeed(i)
            robot_pb(i).Top += robots_yspeed
            ghost_pb(i).Left += x_speed(i)
            ghost_pb(i).Top += yspeed

            If x_speed(i) > 0 Then
                ghost_pb(i).Image = My.Resources.ghost_right
            ElseIf x_speed(i) < 0 Then
                ghost_pb(i).Image = My.Resources.ghost_left
            End If

            If robots_xspeed(i) > 0 Then
                robot_pb(i).Image = My.Resources.ghost_right
            ElseIf robots_xspeed(i) < 0 Then
                robot_pb(i).Image = My.Resources.ghost_left
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

            If robot_pb(i).Left < 0 Then
                If robots_xspeed(i) < 0 Then
                    If robots_xspeed(i) < -7 Then
                        robots_xspeed(i) *= -1
                    Else
                        robots_xspeed(i) -= 2
                        robots_xspeed(i) *= -1
                        robots_yspeed += 0.5
                    End If
                End If
            ElseIf robot_pb(i).Left + 114 > Me.Width Then
                If robots_xspeed(i) > 0 Then
                    If robots_xspeed(i) > 7 Then
                        robots_xspeed(i) *= -1
                    Else
                        robots_xspeed(i) += 2
                        robots_xspeed(i) *= -1
                        robots_yspeed += 0.5
                    End If
                End If
            End If
        Next

        ghost1.Location = ghost_pb(0).Location
        ghost2.Location = ghost_pb(1).Location
        robot_elad.Location = robot_pb(0).Location
        robot_leon.Location = robot_pb(1).Location

        For Each black_blocks2 In Me.Controls

            For i = 0 To 8
                If black_blocks2.name.ToString.Contains("F_black_block") Then
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
                End If
            Next
        Next

        Label2.Text = "(" & robot_elad.Left & "," & robot_elad.Top & ") ,  (" & robot_leon.Left & "," & robot_leon.Top & ")"
    End Sub

    Private Sub Form4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            tmr_ghostattack.Start()
            tmr_ghost.Start()
            tmr_blackblocks.Start()
        End If


        If e.KeyCode = Keys.D And tmr_ghost.Enabled = True And Not player.Left = 1123 - player.Width Then
            player_pb = 0
            player.Image = My.Resources.Stickman___Normal_stand_at_fight__right_
            player_xspeed = 10
            lbl_playerName.Left += 10


        ElseIf e.KeyCode = Keys.A And tmr_ghost.Enabled And Not player.Left = 140 Then
            player_pb = 1
            player.Image = My.Resources.Stickman___Normal_stand_at_fight__left_
            player_xspeed = -10
            lbl_playerName.Left -= 10


        ElseIf e.KeyCode = Keys.W And tmr_ghost.Enabled Then
            If player_yspeed = 0 Then
                player_yspeed = -5

            End If
        End If
        If e.KeyCode = Keys.K Then
            timer_kick.Start()
            If player_pb = 0 Then
                player_kick_pb = 0
                If player_kick_pb = 0 Then
                    player.Image = My.Resources.Stickman_kick_right
                End If
            ElseIf player_pb = 1 Then
                player_kick_pb = 1
                If player_kick_pb = 1 Then
                    player.Image = My.Resources.Stickman_kick_left
                End If
            End If
        End If

        For i = 0 To 1
            If ghost_pb(i).Bounds.IntersectsWith(player.Bounds) Then
                If Not e.KeyCode = Keys.K Then
                    If tmr_ghostattac > 3 Then
                        tmr_ghostattac = 0
                        ProgressBar1.Value -= 10
                        ' If ghost_pb(i).Left > player.Left Then
                        ' player.Left -= 15
                        '   ElseIf ghost_pb(i).Left < player.Left Then
                        'player.Left += 15
                        '  End If
                    End If
                ElseIf e.KeyCode = Keys.K Then
                    'For Each ghosts In Me.Controls
                    '    If ghosts.name.ToString.Contains("ghost") Then
                    '        If player.Bounds.IntersectsWith(ghosts.Bounds) Then
                    'If player.Bounds.IntersectsWith(ghost_pb(i).Bounds) Then
                    If player_pb = 0 Then
                        If ghost_pb(i).Left > player.Left + 0.375 * player.Width And ghost_pb(i).Left < player.Left + player.Width Then
                            hit()
                        ElseIf player_pb = 1 Then
                            If ghost_pb(i).Left > player.Left And ghost_pb(i).Left < player.Left + 0.375 * player.Width Then
                                hit()
                            End If

                            'For a = 0 To 3
                            '    If player.Bounds.IntersectsWith(ghost_pb(a).Bounds) Then
                            '        max -= 0.1 * ((Me.Height - 400) - player.Height)
                            '        min -= 0.1 * ((Me.Height - 400) - player.Height)

                            '        Label2.Text = max & " , " & min
                            '    End If
                            'Next

                            'Randomize()
                            'k = Int((2 * Rnd()) + 0)
                            'If player.Bounds.IntersectsWith(ghost1.Bounds) Then
                            '    If k = 0 Then
                            '        ghost1.Left = 1261
                            '    ElseIf k = 1 Then
                            '        ghost1.Left = -56
                            '    Else
                            '        ghost1.Left = -128
                            '    End If
                            'End If
                            'Randomize()
                            'k = Int((2 * Rnd()) + 0)
                            'If player.Bounds.IntersectsWith(ghost2.Bounds) Then
                            '    If k = 0 Then
                            '        ghost2.Left = 1469
                            '    ElseIf k = 1 Then
                            '        ghost2.Left = -177
                            '    Else
                            '        ghost2.Left = 1521
                            '    End If
                            'End If
                            'Randomize()
                            'k = Int((2 * Rnd()) + 0)
                            'If player.Bounds.IntersectsWith(ghost3.Bounds) Then
                            '    If k = 0 Then
                            '        ghost3.Left = 1625
                            '    ElseIf k = 1 Then
                            '        ghost3.Left = -200
                            '    Else
                            '        ghost3.Left = -270
                            '    End If
                            'End If

                            'Randomize()
                            'k = Int((2 * Rnd()) + 0)
                            'If player.Bounds.IntersectsWith(ghost4.Bounds) Then
                            '    If k = 0 Then
                            '        ghost4.Left = 1729
                            '    ElseIf k = 1 Then
                            '        ghost4.Left = 1833
                            '    Else
                            '        ghost4.Left = -320
                            '    End If
                            'End If
                        End If
                    End If
                End If
            End If
        Next

        '        End If
        '    Next
        'End If

    End Sub
    Private Sub hit()
        '    For a = 0 To 3
        '        If player.Bounds.IntersectsWith(ghost_pb(a).Bounds) Then
        '            max -= 0.1 * ((Me.Height - 400) - player.Height)
        '            min -= 0.1 * ((Me.Height - 400) - player.Height)

        '            Label2.Text = max & " , " & min
        '        End If
        '    Next

        '    Randomize()
        '    k = Int((2 * Rnd()) + 0)
        '    If player.Bounds.IntersectsWith(ghost1.Bounds) Then
        '        If k = 0 Then
        '            ghost1.Left = 1261
        '        ElseIf k = 1 Then
        '            ghost1.Left = -56
        '        Else
        '            ghost1.Left = -128
        '        End If
        '    End If
        '    Randomize()
        '    k = Int((2 * Rnd()) + 0)
        '    If player.Bounds.IntersectsWith(ghost2.Bounds) Then
        '        If k = 0 Then
        '            ghost2.Left = 1469
        '        ElseIf k = 1 Then
        '            ghost2.Left = -177
        '        Else
        '            ghost2.Left = 1521
        '        End If
        '    End If
        '    Randomize()
        '    k = Int((2 * Rnd()) + 0)
        '    If player.Bounds.IntersectsWith(ghost3.Bounds) Then
        '        If k = 0 Then
        '            ghost3.Left = 1625
        '        ElseIf k = 1 Then
        '            ghost3.Left = -200
        '        Else
        '            ghost3.Left = -270
        '        End If
        '    End If

        '    Randomize()
        '    k = Int((2 * Rnd()) + 0)
        '    If player.Bounds.IntersectsWith(ghost4.Bounds) Then
        '        If k = 0 Then
        '            ghost4.Left = 1729
        '        ElseIf k = 1 Then
        '            ghost4.Left = 1833
        '        Else
        '            ghost4.Left = -320
        '        End If
        '    End If
    End Sub
    Private Sub tmr_blackblocks_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_blackblocks.Tick

        u += 1
        If u > 20 Then


            For Each F_black_blocks In Me.Controls
                If F_black_blocks.name.ToString.Contains("F_black_block") Then


                    For i = 0 To 8

                        If blackblocks(i).Top < max Then
                            blackblocks(i).Top = max
                            t(i) += 1
                        ElseIf blackblocks(i).Top > min Then
                            blackblocks(i).Top = min
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

        'If max < 145 Then
        '    Me.Hide()
        '    Form3.Show()
        '    max = 400
        '    min = 610

        '    MsgBox("Congratulation! You defeated 11 ghosts and managed to get to the next level!")

        ' End If
    End Sub

    Private Sub Form4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'player_pb_right = My.Resources.Stickman___Normal_stand_at_fight__right_
        'player_pb_left = My.Resources.Stickman___Normal_stand_at_fight__left_
        max = 400
        min = 610

        'ghosts_for_lvl(0) = ghost1
        'ghosts_for_lvl(1) = ghost2
        'ghosts_for_lvl(2) = ghost3
        'ghosts_for_lvl(3) = ghost4


        x_speed(0) = 3
        x_speed(1) = 3
        robots_xspeed(0) = 1.5
        robots_xspeed(1) = 1.5
        ghost_pb(0) = ghost1
        ghost_pb(1) = ghost2
        robot_pb(0) = robot_elad
        robot_pb(1) = robot_leon

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

        'location1(0).X = 1261
        'location1(1).X = 1313
        'location1(2).X = 1365
        'location2(0).X = 1417
        'location2(1).X = 1469
        'location2(2).X = 1521
        'location3(0).X = 1573
        'location3(1).X = 1625
        'location3(2).X = 1677
        'location4(0).X = 1729
        'location4(1).X = 1781
        'location4(2).X = 1833

        lbl_playerName.Top = player.Top - lbl_playerName.Height
        lbl_playerName.Left = player.Left - lbl_playerName.Width / 2 + player.Width / 2 - 10
        lbl_EladName.Top = robot_elad.Top - lbl_EladName.Height
        lbl_EladName.Left = robot_elad.Left - lbl_EladName.Width / 2 + robot_elad.Width / 2 + 11
        lbl_LeonName.Top = robot_leon.Top - lbl_LeonName.Height
        lbl_LeonName.Left = robot_leon.Left - lbl_LeonName.Width / 2 + robot_leon.Width / 2 + 11
        lbl_MaorName.Top = ghost1.Top - lbl_MaorName.Height
        lbl_MaorName.Left = ghost1.Left - lbl_MaorName.Width / 2 + ghost1.Width / 2 + 4
        lbl_AmitName.Top = ghost2.Top - lbl_AmitName.Height
        lbl_AmitName.Left = ghost2.Left - lbl_AmitName.Width / 2 + ghost2.Width / 2 + 4


        'Randomize()
        'k = Int((3 * Rnd()) + 0)
        'Label1.Text = k
        'If player.Bounds.IntersectsWith(ghost1.Bounds) Then
        '    If k = 0 Then
        '        ghost1.Left = 1261
        '    ElseIf k = 1 Then
        '        ghost1.Left = -56
        '    Else
        '        ghost1.Left = -128
        '    End If
        'End If

        'If player.Bounds.IntersectsWith(ghost2.Bounds) Then
        '    If k = 0 Then
        '        ghost2.Left = 1469
        '    ElseIf k = 1 Then
        '        ghost2.Left = -177
        '    Else
        '        ghost2.Left = 1521
        '    End If
        'End If

        'If player.Bounds.IntersectsWith(ghost3.Bounds) Then
        '    If k = 0 Then
        '        ghost3.Left = 1625
        '    ElseIf k = 1 Then
        '        ghost3.Left = -200
        '    Else
        '        ghost3.Left = -270
        '    End If
        'End If


        'If player.Bounds.IntersectsWith(ghost4.Bounds) Then
        '    If k = 0 Then
        '        ghost4.Left = 1729
        '    ElseIf k = 1 Then
        '        ghost4.Left = 1833
        '    Else
        '        ghost4.Left = -320
        '    End If
        'End If

        'Label2.Text = max & " , " & min
        Label2.Text = "(" & robot_elad.Left & "," & robot_elad.Top & ") ,  (" & robot_leon.Left & "," & robot_leon.Top & ")"
    End Sub

    Private Sub tmr_k_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_k.Tick
        Randomize()
        k = Int((3 * Rnd()) + 0)
        Label1.Text = k
    End Sub

    Private Sub tmr_ghostattack_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_ghostattack.Tick
        tmr_ghostattac += 1
    End Sub

    Private Sub timer_kick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_kick.Tick
        tmr_kick += 1
        If tmr_kick > 1 Then
            If player_kick_pb = 0 Then 'Right
                tmr_kick = 0
                player.Image = My.Resources.Stickman___Normal_stand_at_fight__right_
                timer_kick.Stop()
            ElseIf player_kick_pb = 1 Then 'Left
                tmr_kick = 0
                player.Image = My.Resources.Stickman___Normal_stand_at_fight__left_
                timer_kick.Stop()
            End If
        End If
    End Sub


End Class