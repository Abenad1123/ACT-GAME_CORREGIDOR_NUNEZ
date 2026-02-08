Public Class rockpaperscissors_main
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

    Private Sub RockPaperScissorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.glove_idle_left
        PictureBox2.Image = My.Resources.glove_idle_right

        LoadFont("minecraft", My.Resources.minecraft_font)

        Label2.UseCompatibleTextRendering = True
        Label2.Font = GetFont("minecraft", 55)

        Label3.UseCompatibleTextRendering = True
        Label3.Font = GetFont("minecraft", 55)

        Label4.UseCompatibleTextRendering = True
        Label4.Font = GetFont("minecraft", 40)

        Dim btns() As Button = {Button1, Button2, Button3}
        For Each btn In btns
            btn.UseCompatibleTextRendering = True
            btn.Font = GetFont("minecraft", 25)
        Next


        MessageBox.Show("Welcome to Rock-Paper-Scissors! Choose your weapon and try to beat the AI. Good luck!", "Game")
        playerScore = 0
        aiScore = 0

        playerFace = 0
        aiFace = 0
    End Sub

    Dim playerScore As Integer = 0
    Dim aiScore As Integer = 0

    Dim playerFace As Integer = 0
    Dim aiFace As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.rock_left
        CheckTurn(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.paper_left
        CheckTurn(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.scissor_left
        CheckTurn(3)
    End Sub

    Private Sub CheckTurn(playerChoice As Integer)
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

        If playerChoice <> playerFace Then
            Select Case playerChoice
                Case 1 : Label4.Text = "You chose rock!"
                Case 2 : Label4.Text = "You chose paper!"
                Case 3 : Label4.Text = "You chose scissor!"
            End Select
        End If

        If playerChoice = playerFace Then
            Select Case playerChoice
                Case 1 : Label4.Text = "You chose rock again!"
                Case 2 : Label4.Text = "You chose paper again!"
                Case 3 : Label4.Text = "You chose scissor again!"
            End Select
        End If

        Turn(playerChoice)
    End Sub

    Private Async Sub Turn(playerChoice As Integer)
        Await Task.Delay(1000)
        Label4.Text = "The bot is choosing..."
        Await Task.Delay(1000)
        playerFace = playerChoice
        Dim rnd As New Random()
        Dim number As Integer = rnd.Next(1, 4)

        Select Case number
            Case 1
                PictureBox2.Image = My.Resources.rock_right
                Label4.Text = "AI chose rock!"
                aiFace = 1
            Case 2
                PictureBox2.Image = My.Resources.paper_right
                Label4.Text = "AI chose paper!"
                aiFace = 2
            Case 3
                PictureBox2.Image = My.Resources.scissor_right
                Label4.Text = "AI chose scissor!"
                aiFace = 3
        End Select
        CalcScore()
    End Sub

    Private Async Sub CalcScore()
        If playerFace = aiFace Then
            Label4.Text &= vbCrLf & "Draw"
        ElseIf (playerFace = 1 And aiFace = 2) Or (playerFace = 2 And aiFace = 3) Or (playerFace = 3 And aiFace = 1) Then
            Label4.Text &= vbCrLf & "AI Won"
            aiScore += 1
        ElseIf (playerFace = 2 And aiFace = 1) Or (playerFace = 3 And aiFace = 2) Or (playerFace = 1 And aiFace = 3) Then
            Label4.Text &= vbCrLf & "Player Won"
            playerScore += 1
        End If
        Await Task.Delay(1300)
        ScoreUpd()
    End Sub

    Private Sub ScoreUpd()
        Label2.Text = (playerScore).ToString
        Label3.Text = (aiScore).ToString
        Label4.Text = "Pick your weapon!"
        PictureBox1.Image = My.Resources.glove_idle_left
        PictureBox2.Image = My.Resources.glove_idle_right
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
    End Sub

End Class