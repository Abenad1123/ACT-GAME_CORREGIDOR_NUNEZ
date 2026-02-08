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

    Dim Level As Integer = 0
    Dim currentQuestion As Integer = 0
    Dim rand As New Random()
    Private Sub Initializer(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Click any answer button to start"
        UpdateMap()
        Button1.Text = "Start"
        Button2.Text = "Start"
        Button3.Text = "Start"
        Button4.Text = "Start"
    End Sub

    Private Sub LoadQuestion()
        currentQuestion = rand.Next(0, question.questions.Count)
        Label1.Text = question.questions(currentQuestion)
        Button1.Text = question.choices(currentQuestion)(0)
        Button2.Text = question.choices(currentQuestion)(1)
        Button3.Text = question.choices(currentQuestion)(2)
        Button4.Text = question.choices(currentQuestion)(3)

    End Sub

    Private Sub UpdateMap()
        Dim MapImages() As Image = {My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18, My.Resources._19, My.Resources._20}
        If Level >= 0 And Level < MapImages.Length Then
            PictureBox1.Image = MapImages(Level)
        End If
    End Sub


    Private Sub checkanswerEvent(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        Dim btn As Button = CType(sender, Button)

        If Level = 0 Or Level = 8 Then
            Level = 1
            LoadQuestion()
            UpdateMap()
            Exit Sub
        End If

        Dim correct As Boolean = False

        If btn.Text = question.answers(currentQuestion) Then
            correct = True
        End If

        If correct Then
            MessageBox.Show("Correct!")
            Level += 1
            UpdateMap()
            LoadQuestion()
        Else
            MessageBox.Show("Wrong answer. Try again.")
        End If
    End Sub
End Class