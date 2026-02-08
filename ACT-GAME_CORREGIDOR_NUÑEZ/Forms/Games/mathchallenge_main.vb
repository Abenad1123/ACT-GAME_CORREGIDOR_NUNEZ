Imports System.Reflection.Emit

Public Class mathchallenge_main
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

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        OpenForm(Of mathchallenge_settings)(Me)
    End Sub

    Dim Level As Integer = 0
    Dim currentQuestion As Integer = 0
    Dim prevQuestions As New List(Of Integer)
    Dim rand As New Random()
    Dim lives As Integer = 3
    Private Sub Initializer(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFont("minecraft", My.Resources.minecraft_font)

        Dim btns() As Button = {Button1, Button2, Button3, Button4}
        For Each btn In btns
            btn.UseCompatibleTextRendering = True
            btn.Font = GetFont("minecraft", 18)
        Next

        Label1.UseCompatibleTextRendering = True
        Label1.Font = GetFont("minecraft", 22)

        Label2.UseCompatibleTextRendering = True
        Label2.Font = GetFont("minecraft", 60)

        InitalText()
    End Sub

    Private Sub InitalText()
        Label1.Text = "Click any answer button to start"
        UpdateMap()
        Button1.Text = "Start"
        Button2.Text = "Start"
        Button3.Text = "Start"
        Button4.Text = "Start"

    End Sub

    Private Sub LoadQuestion()
        currentQuestion = rand.Next(0, question.questions.Count)
        If prevQuestions.Contains(currentQuestion) Then
            LoadQuestion()
            Exit Sub
        End If

        Label1.Text = question.questions(currentQuestion)
        Button1.Text = question.choices(currentQuestion)(0)
        Button2.Text = question.choices(currentQuestion)(1)
        Button3.Text = question.choices(currentQuestion)(2)
        Button4.Text = question.choices(currentQuestion)(3)
        prevQuestions.Add(currentQuestion)
    End Sub

    Private Sub UpdateMap()
        Dim MapImages() As Image = {My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18, My.Resources._19, My.Resources._20}
        If Level >= 0 And Level < MapImages.Length Then
            PictureBox1.Image = MapImages(Level)
        End If
    End Sub


    Private Sub checkanswerEvent(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Dim btn As Button = CType(sender, Button)

        If lives = 0 Then
            MsgBox("Game Over! You have no more lives left. Restarting the game.")
            lives = 3
            Level = 0
            heart1.Image = My.Resources.heart
            heart2.Image = My.Resources.heart
            heart3.Image = My.Resources.heart
            InitalText()
            Exit Sub
        End If


        If Level = 0 Then
            Level = 1
            InitalText()
            LoadQuestion()
            UpdateMap()
            Exit Sub
        ElseIf Level = 8 Then
            MessageBox.Show("Congratulations! You've completed the game. Restarting.", "Game Complete")
            lives = 3
            Level = 0
            InitalText()
            UpdateMap()
            heart1.Image = My.Resources.heart
            heart2.Image = My.Resources.heart
            heart3.Image = My.Resources.heart
            Exit Sub
        End If

        Dim correct As Boolean = False

        If btn.Text = question.answers(currentQuestion) Then correct = True

        If correct Then
            MessageBox.Show("Correct!", "Annoucement")
            Level += 1
            If Level = 8 Then
                UpdateMap()
                checkanswerEvent(Nothing, Nothing)
                Exit Sub
            End If
            UpdateMap()
            LoadQuestion()
        Else
            lives -= 1
            Select Case lives
                Case 0 : heart1.Image = My.Resources.heart_dead
                Case 1 : heart2.Image = My.Resources.heart_dead
                Case 2 : heart3.Image = My.Resources.heart_dead
            End Select
            MessageBox.Show("Wrong answer. Try again.", "Annoucement")
        End If
    End Sub
End Class