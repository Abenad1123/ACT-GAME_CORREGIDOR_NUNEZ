Public Class evadethemissiles_settings
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
        Dim speed As Integer
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Easy"
                speed = 20
            Case "Normal"
                speed = 10
            Case "Meduim"
                speed = 8
            Case "Hard"
                speed = 6
            Case "Extreme"
                speed = 2
        End Select
        game_var.eam_difficulty_level = speed

        MessageBox.Show("Difficulty set to " & ComboBox1.SelectedItem.ToString() & "!", "Settings")
    End Sub
End Class