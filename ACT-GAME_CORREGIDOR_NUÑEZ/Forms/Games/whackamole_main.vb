Public Class whackamole_main
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

    Dim timeDuration As Integer
    Dim playerScore As Integer

    Dim inactiveMoles As New List(Of PictureBox)
    Dim activeMoles As New List(Of PictureBox)

    Dim rnd As New Random()

    Dim hammer_click As New Cursor(New IO.MemoryStream(My.Resources.hammer_click))
    Dim hammer_idle As New Cursor(New IO.MemoryStream(My.Resources.hammer_idle))

    Dim GameRunning As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFont("minecraft", My.Resources.minecraft_font)

        Label1.UseCompatibleTextRendering = True
        Label1.Font = GetFont("minecraft", 22)

        Label2.UseCompatibleTextRendering = True
        Label2.Font = GetFont("minecraft", 22)

        Label3.UseCompatibleTextRendering = True
        Label3.Font = GetFont("minecraft", 22)

        Label4.UseCompatibleTextRendering = True
        Label4.Font = GetFont("minecraft", 70)

        Button7.UseCompatibleTextRendering = True
        Button7.Font = GetFont("minecraft", 22)

        Me.Cursor = hammer_idle
        InitialData()
        MessageBox.Show("Welcome to Whack-A-Mole! Click on the moles as they appear to score points. You have 60 seconds. Good luck!", "Game")
    End Sub

    Private Async Sub Start_Game(sender As Object, e As EventArgs) Handles Button7.Click
        If GameRunning = False Then
            Await Task.Delay(500)
            Label4.Text = "3"
            Await Task.Delay(1000)
            Label4.Text = "2"
            Await Task.Delay(1000)
            Label4.Text = "1"
            Await Task.Delay(1000)
            Label4.Text = "START!"
            Await Task.Delay(500)
            Label4.Text = ""
            GameRunning = True
            TimerTick()
            SpawnMoles()
            Button7.Visible = False
        End If
    End Sub
    Private Async Sub TimerTick()
        Label2.Text = "TIME LEFT : " & timeDuration & "s"
        While GameRunning
            Await Task.Delay(1000)
            timeDuration -= 1
            Label2.Text = "TIME LEFT : " & timeDuration & "s"
            If timeDuration <= 0 Then
                GameRunning = False
                If playerScore > game_var.wam_highestPlayerScore Then
                    MessageBox.Show("Time's up! Your score: " & playerScore & vbCrLf & ". Wow! you achieved the highest score", "Game")
                Else
                    MessageBox.Show("Time's up! Your score: " & playerScore, "Game")
                End If

                InitialData()
                Button7.Visible = True
            End If
        End While
    End Sub

    Private Async Sub SpawnMoles()
        While GameRunning
            If inactiveMoles.Count > 0 Then
                Await Task.Delay(rnd.Next(900, 1500))
                Dim index As Integer = rnd.Next(0, inactiveMoles.Count)
                Dim block As PictureBox = inactiveMoles(index)

                inactiveMoles.RemoveAt(index)
                activeMoles.Add(block)

                block.Image = My.Resources.mole_show
                IndivMoleDespawn(block)
            End If

        End While
    End Sub

    Private Async Sub IndivMoleDespawn(mole As PictureBox)
        If activeMoles.Contains(mole) Then
            Await Task.Delay(rnd.Next(game_var.wam_mole_despawnTime * 2, game_var.wam_mole_despawnTime * 4))
            activeMoles.Remove(mole)
            inactiveMoles.Add(mole)
            mole.Image = My.Resources.mole_empty
        End If
    End Sub

    Private Sub InitialData()
        inactiveMoles = New List(Of PictureBox) From {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6}
        timeDuration = game_var.standard_timeDuration
        playerScore = 0
        Label1.Text = "SCORE : " & playerScore
        Label3.Text = "HIGHEST SCORE : " & game_var.wam_highestPlayerScore
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click
        Dim Btn As PictureBox = CType(sender, PictureBox)

        ScoreAdd(Btn)
    End Sub

    Private Sub Mouse_Relase(sender As Object, e As EventArgs) Handles PictureBox1.MouseUp, PictureBox2.MouseUp, PictureBox3.MouseUp, PictureBox4.MouseUp, PictureBox5.MouseUp, PictureBox6.MouseUp
        Me.Cursor = hammer_idle
    End Sub

    Private Sub Mouse_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown, PictureBox5.MouseDown, PictureBox6.MouseDown
        Me.Cursor = hammer_click
    End Sub


    Private Sub ScoreAdd(mole As PictureBox)
        If activeMoles.Contains(mole) Then
            playerScore += 1
            Label1.Text = "SCORE : " & playerScore
            If playerScore > game_var.wam_highestPlayerScore Then
                game_var.wam_highestPlayerScore = playerScore
                Label3.Text = "HIGHEST SCORE : " & game_var.wam_highestPlayerScore
            End If
            MoleAnimate(mole)

            activeMoles.Remove(mole)
            inactiveMoles.Add(mole)
        End If
    End Sub

    Private Async Sub MoleAnimate(mole As PictureBox)
        mole.Image = My.Resources.mole_hit
        Await Task.Delay(40)
        mole.Image = My.Resources.mole_hit_2
        Await Task.Delay(50)
        mole.Image = My.Resources.mole_hit_3
        Await Task.Delay(60)
        mole.Image = My.Resources.mole_empty
    End Sub
End Class