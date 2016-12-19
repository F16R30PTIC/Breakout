Public Class Settings
    Public ballSpeed, dropRate As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ballSpeed = cmboBallSpeed.SelectedItem
    End Sub

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick
        lblBallSpeed.Text = ballSpeed
        lblDropRate.Text = dropRate
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.Hide()
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtLevelCode.Text = "5721" Then
            Breakout_L1.Show()
            Me.Hide()
        ElseIf txtLevelCode.Text = "8432" Then
            Breakout_L2.Show()
            Me.Hide()
        End If
    End Sub
End Class