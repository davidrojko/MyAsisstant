Public Class glavni_meni
    Private Sub DodajStrankoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajStrankoToolStripMenuItem.Click
        Dim dodaj_stranko As New dodaj_stranko()
        dodaj_stranko.Show()
    End Sub

    Private Sub izhod_btn_Click(sender As Object, e As EventArgs) Handles izhod_btn.Click
        Application.Exit()
    End Sub

    Private Sub PregledStrankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PregledStrankToolStripMenuItem.Click
        Dim pregled_strank As New pregled_strank()
        pregled_strank.Show()
    End Sub

    Private Sub OdstraniStrankoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdstraniStrankoToolStripMenuItem.Click
        Dim odstrani_stranko As New odstrani_stranko()
        odstrani_stranko.Show()
    End Sub
End Class