Public Class game_main
    Private Sub Initializer(sender As Object, e As EventArgs) Handles MyBase.Load
        Basic.ImgHover(etm_btn, My.Resources.evadethemissles_icon_256, My.Resources.evadethemissles_icon_256_hover)
        Basic.ImgHover(rps_btn, My.Resources.rockpaperscissors_icon_256, My.Resources.rockpaperscissors_icon_256_hover)
        Basic.ImgHover(wam_btn, My.Resources.whackamole_icon_256, My.Resources.whackamole_icon_256_hover)
        Basic.ImgHover(mch_btn, My.Resources.mathchallenge_icon_256, My.Resources.mathchallenge_icon_256_hover)
    End Sub

    Private Sub Etm_btn_Click(sender As Object, e As EventArgs) Handles etm_btn.Click
        OpenForm(Of evadethemissiles_main)(Me)
    End Sub

    Private Sub Wam_btn_Click(sender As Object, e As EventArgs) Handles wam_btn.Click
        OpenForm(Of whackamole_main)(Me)
    End Sub

    Private Sub Mch_btn_Click(sender As Object, e As EventArgs) Handles mch_btn.Click
        OpenForm(Of mathchallenge_main)(Me)
    End Sub

    Private Sub Rps_btn_Click(sender As Object, e As EventArgs) Handles rps_btn.Click
        OpenForm(Of rockpaperscissors_main)(Me)
    End Sub
End Class