Public Class game_welcome
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles continue_btn.Click
        OpenForm(Of game_main)(Me)
    End Sub

    Private Sub Initializer(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(continue_btn, My.Resources.cont_btn, My.Resources.cont_btn_hover)
    End Sub
End Class