Public Class pregled_strank
    Private Sub pregled_strank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ma_databaseDataSet1.stranke' table. You can move, or remove it, as needed.
        Me.StrankeTableAdapter.Fill(Me.Ma_databaseDataSet1.stranke)

    End Sub
End Class