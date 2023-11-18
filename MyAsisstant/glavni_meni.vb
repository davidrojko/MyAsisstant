Public Class glavni_meni
    Private Sub DodajStrankoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajStrankoToolStripMenuItem.Click
        Dim dodaj_stranko As New dodaj_stranko()
        dodaj_stranko.Show()
    End Sub

    Private Sub izhod_btn_Click(sender As Object, e As EventArgs) Handles izhod_btn.Click
        Application.Exit()
    End Sub
End Class