Public Class StartMenu
    Private Sub btn_off_Click(sender As Object, e As EventArgs) Handles btn_off.Click
        Close()
    End Sub

    Private Sub btn_ie_Click(sender As Object, e As EventArgs) Handles btn_ie.Click
        iexplore.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_mspaint.Click
        mspaint.Show()
        Close()
    End Sub

    Private Sub btn_hxd_Click(sender As Object, e As EventArgs) Handles btn_hxd.Click
        HxD.Show()
        Close()
    End Sub
End Class