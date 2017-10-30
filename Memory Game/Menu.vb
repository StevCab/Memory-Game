Public Class Menu
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Me.Hide()
        Memory_Game.Game.Show()
    End Sub
End Class