Public Class whackamole_settings
    Private Sub rockpaperscissors_btn_Click(sender As Object, e As EventArgs) Handles rockpaperscissors_btn.Click
        OpenForm(Of rockpaperscissors_main)(Me)
    End Sub

    Private Sub fallingblock_btn_Click(sender As Object, e As EventArgs) Handles evadethemissiles_btn.Click
        OpenForm(Of evadethemissiles_main)(Me)
    End Sub

    Private Sub whackamole_btn_Click(sender As Object, e As EventArgs) Handles whackamole_btn.Click
        OpenForm(Of whackamole_main)(Me)
    End Sub

    Private Sub mathchallenge_btn_Click(sender As Object, e As EventArgs) Handles mathchallenge_btn.Click
        OpenForm(Of mathchallenge_main)(Me)
    End Sub

    Private Sub go_back_Click(sender As Object, e As EventArgs) Handles go_back.Click
        OpenForm(Of game_main)(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter a valid time duration.")
            Exit Sub
        End If

        game_var.standard_timeDuration = (TextBox1.Text).ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Whack-A-Mole high score has been reset.")
        game_var.wam_highestPlayerScore = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case ComboBox1.SelectedItem.ToString
            Case "Easy"
                game_var.wam_mole_despawnTime = 1300
            Case "Normal"
                game_var.wam_mole_despawnTime = 1000
            Case "Meduim"
                game_var.wam_mole_despawnTime = 800
            Case "Hard"
                game_var.wam_mole_despawnTime = 700
            Case "Extreme"
                game_var.wam_mole_despawnTime = 400
            Case Else
                MsgBox("Please select a valid difficulty level.")
                Exit Sub
        End Select
    End Sub

End Class