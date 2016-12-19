Public Class StartMenu
    Public currentLvl As Form = Me
    Private Sub StartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBreakout.Location = New Point(926, lblBreakout.Location.Y)
        Breakout_L1.Hide()
    End Sub
    Private Sub Title_Tick(sender As Object, e As EventArgs) Handles Title.Tick
        If lblBreakout.Location.X > 20 Then
            lblBreakout.Location = New Point(lblBreakout.Location.X - 5, lblBreakout.Location.Y)
        Else
            Title.Enabled = False
            Buttons.Enabled = True
            lblDivider.Visible = True
            picLogo.Visible = True
        End If

    End Sub
    Private Sub Buttons_Tick(sender As Object, e As EventArgs) Handles Buttons.Tick
        If Not btnNew.Visible Then
            btnNew.Visible = True
        ElseIf Not btnResume.Visible Then
            btnResume.Visible = True
        ElseIf Not btnSettings.Visible Then
            btnSettings.Visible = True
        ElseIf Not btnQuit.Visible Then
            btnQuit.Visible = True
        Else
            Buttons.Enabled = False
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.Hide()
        Breakout_L1.Close()
        Breakout_L2.Close()
        Breakout_L1.Show()
        currentLvl = Breakout_L1
    End Sub
    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click

        If Not currentLvl Is Me Then
            Me.Hide()
            currentLvl.Show()
        Else
            MsgBox("No current game")
        End If
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Settings.Show()
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Settings.Close()
        Breakout_L1.Close()
        Breakout_L2.Close()
        Me.Close()
    End Sub
End Class