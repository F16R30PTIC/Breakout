Public Class Breakout_L2
    Dim ballMovex As Integer
    Dim ballMovey As Integer = 10
    'Amount the paddle moves
    Dim move As Integer
    'Number of blocks hit
    Dim hitCnt As Integer = 18    'Wheter or not ball is in play
    Dim shot As Boolean = False
    'The randomly selected item that is dropped on 30' interval
    Dim dropItem As PictureBox
    Dim lives As Integer = 6
    'When 'Quit' is selected in File menu
    Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        Settings.Close()
        StartMenu.Close()
        Me.Close()
    End Sub
    'Form cancel button
    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        StartMenu.Show()
        StartMenu.BringToFront()
    End Sub
    'Key press event handler
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        Select Case keyData
            Case Keys.Left
                move = 30
                Call paddleMove(move)
            Case Keys.Right
                move = -30
                Call paddleMove(move)
            Case Keys.Up
                If shot = False Then
                    shot = True
                End If
            Case Keys.Down
                Drop.Enabled = True
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    'Moves the paddle when called
    Sub paddleMove(ByRef paddleMove As Integer)
        picPaddle.Location = New Point(picPaddle.Location.X - paddleMove, picPaddle.Location.Y)
    End Sub
    'Moves ball and checks/accounts for boundaries.
    Private Sub ballMove_Tick(sender As Object, e As EventArgs) Handles ballMove.Tick
        If shot = True Then
            If Not ball.Location.X <= 0 Then
                If Not ball.Location.X + ball.Width >= Me.Width Then
                    If Not ball.Bounds.IntersectsWith(MenuStrip1.Bounds) Then
                        If Not ball.Location.Y + ball.Height >= Me.Height Then
                            If ball.Bounds.IntersectsWith(picPaddle.Bounds) Then
                                ballMovex += 0.075 * move
                                ballMovey *= -1
                            End If
                        Else
                            picPaddle.Location = New Point(397, 438)
                            move = 0
                            ball.Location = New Point(450, 427)
                            ballMovex = 0
                            ballMovey = 10
                            shot = False
                            lives -= 1
                        End If
                    Else
                        ballMovey *= -1
                    End If
                Else
                    ballMovex *= -1
                End If
            Else
                ballMovex *= -1
            End If

            ball.Location = New Point(ball.Location.X - ballMovex, ball.Location.Y - ballMovey)
        Else
            ball.Location = New Point(picPaddle.Location.X + (0.5 * picPaddle.Width) - (0.5 * ball.Width), ball.Location.Y)
        End If

        If lives = 0 Then
            life1.Visible = False
            gameEnd()
        Else
            If lives = 5 Then
                life6.Visible = False
            ElseIf lives = 4 Then
                life5.Visible = False
            ElseIf lives = 3 Then
                life4.Visible = False
            ElseIf lives = 2 Then
                life3.Visible = False
            ElseIf lives = 1 Then
                life2.Visible = False
            End If
        End If
    End Sub
    'When 'Settings' is selected in File menu
    Private Sub mnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
        Settings.ShowDialog()
    End Sub
    'Checks for collisions with bricks
    Private Sub collisionChk_Tick(sender As Object, e As EventArgs) Handles collisionChk.Tick
        If ballMovex >= 15 Then
            ballMovex -= 1
        End If

        If ball.Bounds.IntersectsWith(A1.Bounds) And A1.Visible Then
            A1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A2.Bounds) And A2.Visible Then
            A2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A3.Bounds) And A3.Visible Then
            A3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A4.Bounds) And A4.Visible Then
            A4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A5.Bounds) And A5.Visible Then
            A5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A6.Bounds) And A6.Visible Then
            A6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A7.Bounds) And A7.Visible Then
            A7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A8.Bounds) And A8.Visible Then
            A8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A9.Bounds) And A9.Visible Then
            A9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A10.Bounds) And A10.Visible Then
            A10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(A11.Bounds) And A11.Visible Then
            A11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'B row
        ElseIf ball.Bounds.IntersectsWith(B1.Bounds) And B1.Visible Then
            B1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B2.Bounds) And B2.Visible Then
            B2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B3.Bounds) And B3.Visible Then
            B3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B4.Bounds) And B4.Visible Then
            B4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B5.Bounds) And B5.Visible Then
            B5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B6.Bounds) And B6.Visible Then
            B6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B7.Bounds) And B7.Visible Then
            B7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B8.Bounds) And B8.Visible Then
            B8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B9.Bounds) And B9.Visible Then
            B9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B10.Bounds) And B10.Visible Then
            B10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(B11.Bounds) And B11.Visible Then
            B11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'C row
        ElseIf ball.Bounds.IntersectsWith(C1.Bounds) And C1.Visible Then
            C1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C2.Bounds) And C2.Visible Then
            C2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C3.Bounds) And C3.Visible Then
            C3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C4.Bounds) And C4.Visible Then
            C4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C5.Bounds) And C5.Visible Then
            C5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C6.Bounds) And C6.Visible Then
            C6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C7.Bounds) And C7.Visible Then
            C7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C8.Bounds) And C8.Visible Then
            C8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C9.Bounds) And C9.Visible Then
            C9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C10.Bounds) And C10.Visible Then
            C10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(C11.Bounds) And C11.Visible Then
            C11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'D row
        ElseIf ball.Bounds.IntersectsWith(D1.Bounds) And D1.Visible Then
            D1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D2.Bounds) And D2.Visible Then
            D2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D3.Bounds) And D3.Visible Then
            D3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D4.Bounds) And D4.Visible Then
            D4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D5.Bounds) And D5.Visible Then
            D5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D6.Bounds) And D6.Visible Then
            D6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D7.Bounds) And D7.Visible Then
            D7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D8.Bounds) And D8.Visible Then
            D8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D9.Bounds) And D9.Visible Then
            D9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D10.Bounds) And D10.Visible Then
            D10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(D11.Bounds) And D11.Visible Then
            D11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'E row
        ElseIf ball.Bounds.IntersectsWith(E1.Bounds) And E1.Visible Then
            E1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E2.Bounds) And E2.Visible Then
            E2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E3.Bounds) And E3.Visible Then
            E3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E4.Bounds) And E4.Visible Then
            E4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E5.Bounds) And E5.Visible Then
            E5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E6.Bounds) And E6.Visible Then
            E6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E7.Bounds) And E7.Visible Then
            E7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E8.Bounds) And E8.Visible Then
            E8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E9.Bounds) And E9.Visible Then
            E9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E10.Bounds) And E10.Visible Then
            E10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(E11.Bounds) And E11.Visible Then
            E11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'F row
        ElseIf ball.Bounds.IntersectsWith(F1.Bounds) And F1.Visible Then
            F1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F2.Bounds) And F2.Visible Then
            F2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F3.Bounds) And F3.Visible Then
            F3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F4.Bounds) And F4.Visible Then
            F4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F5.Bounds) And F5.Visible Then
            F5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F6.Bounds) And F6.Visible Then
            F6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F7.Bounds) And F7.Visible Then
            F7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F8.Bounds) And F8.Visible Then
            F8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F9.Bounds) And F9.Visible Then
            F9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F10.Bounds) And F10.Visible Then
            F10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(F11.Bounds) And F11.Visible Then
            F11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'G row
        ElseIf ball.Bounds.IntersectsWith(G1.Bounds) And G1.Visible Then
            G1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G2.Bounds) And G2.Visible Then
            G2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G3.Bounds) And G3.Visible Then
            G3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G4.Bounds) And G4.Visible Then
            G4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G5.Bounds) And G5.Visible Then
            G5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G6.Bounds) And G6.Visible Then
            G6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G7.Bounds) And G7.Visible Then
            G7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G8.Bounds) And G8.Visible Then
            G8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G9.Bounds) And G9.Visible Then
            G9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G10.Bounds) And G10.Visible Then
            G10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(G11.Bounds) And G11.Visible Then
            G11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'H row
        ElseIf ball.Bounds.IntersectsWith(H1.Bounds) And H1.Visible Then
            H1.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H2.Bounds) And H2.Visible Then
            H2.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H3.Bounds) And H3.Visible Then
            H3.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H4.Bounds) And H4.Visible Then
            H4.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H5.Bounds) And H5.Visible Then
            H5.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H6.Bounds) And H6.Visible Then
            H6.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H7.Bounds) And H7.Visible Then
            H7.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H8.Bounds) And H8.Visible Then
            H8.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H9.Bounds) And H9.Visible Then
            H9.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H10.Bounds) And H10.Visible Then
            H10.Visible = False
            ballMovey *= -1
            hitCnt += 1
        ElseIf ball.Bounds.IntersectsWith(H11.Bounds) And H11.Visible Then
            H11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            'I row
        ElseIf ball.Bounds.IntersectsWith(I1.Bounds) And I1.Visible Then
            I1.Visible = False
            ballMovey *= -1
            hitCnt += 1
            B3.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I2.Bounds) And I2.Visible Then
            I2.Visible = False
            ballMovey *= -1
            hitCnt += 1
            B4.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I3.Bounds) And I3.Visible Then
            I3.Visible = False
            ballMovey *= -1
            hitCnt += 1
            C3.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I4.Bounds) And I4.Visible Then
            I4.Visible = False
            ballMovey *= -1
            hitCnt += 1
            C4.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I5.Bounds) And I5.Visible Then
            I5.Visible = False
            ballMovey *= -1
            hitCnt += 1
            C5.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I6.Bounds) And I6.Visible Then
            I6.Visible = False
            ballMovey *= -1
            hitCnt += 1
            C6.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I7.Bounds) And I7.Visible Then
            I7.Visible = False
            ballMovey *= -1
            hitCnt += 1
            D3.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I8.Bounds) And I8.Visible Then
            I8.Visible = False
            ballMovey *= -1
            hitCnt += 1
            D4.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I9.Bounds) And I9.Visible Then
            I9.Visible = False
            ballMovey *= -1
            hitCnt += 1
            D5.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I10.Bounds) And I10.Visible Then
            I10.Visible = False
            ballMovey *= -1
            hitCnt += 1
            D6.Visible = True
        ElseIf ball.Bounds.IntersectsWith(I11.Bounds) And I11.Visible Then
            I11.Visible = False
            ballMovey *= -1
            hitCnt += 1
            E3.Visible = True
        End If

        If hitCnt = 99 Then
            gameEnd()
        End If
    End Sub
    'When all bricks have been hit
    Sub gameEnd()
        If lives <> 0 Then
            ballMove.Enabled = False
            collisionChk.Enabled = False
            MsgBox("Level 1 Complete!")
            Me.Close()
        Else
            ballMove.Enabled = False
            collisionChk.Enabled = False
            MsgBox("You lost!")
            StartMenu.Show()
            Me.Close()
        End If
    End Sub
    'Makes sure paddle does not exceed boundaries
    Private Sub tmrPaddleChk_Tick(sender As Object, e As EventArgs) Handles tmrPaddleChk.Tick
        If picPaddle.Location.X <= 0 Then
            picPaddle.Location = New Point(0, picPaddle.Location.Y)
            move *= -1
        ElseIf picPaddle.Location.X + picPaddle.Width >= Me.Width Then
            picPaddle.Location = New Point(Me.Width - picPaddle.Width, picPaddle.Location.Y)
            move *= -1
        End If
    End Sub
    'Drops items at 30' intervals
    Private Sub Drop_Tick(sender As Object, e As EventArgs) Handles Drop.Tick
        Randomize()
        Dim randomItem = Int((2 * Rnd()) + 1)

        If randomItem = 1 Then
            dropItem = dropSlow
        ElseIf randomItem = 2 Then
            dropItem = dropFast
        End If

        Randomize()
        Dim randomLocation = Int((800 * Rnd()) + 1)

        dropItem.Location = New Point(randomLocation, 0)
        dropItem.Visible = True
        dropItemsMove.Enabled = True
    End Sub
    'Moves dropped items
    Private Sub dropItemsMove_Tick(sender As Object, e As EventArgs) Handles dropItemsMove.Tick
        If Not dropItem.Bounds.IntersectsWith(picPaddle.Bounds) And Not dropItem.Location.Y + dropItem.Height >= Me.Height Then
            'lblDebug.Text = "(" & dropItem.Location.X & " , " & dropItem.Location.Y & ")"
            dropItem.Location = New Point(dropItem.Location.X, dropItem.Location.Y + 8)
        ElseIf dropItem.Bounds.IntersectsWith(picPaddle.Bounds) Then
            If dropItem Is dropSlow Then
                ballMovex *= 0.5
                ballMovey *= 0.5
            ElseIf dropItem Is dropFast Then
                ballMovex *= 2
                ballMovey *= 2
            End If

            dropItem.Visible = False
            dropItemsMove.Enabled = False
        Else
            dropItem.Visible = False
            dropItemsMove.Enabled = False
        End If
    End Sub
    Private Sub picEsc_Click(sender As Object, e As EventArgs) Handles picEsc.Click
        StartMenu.Show()
        StartMenu.BringToFront()
    End Sub
End Class