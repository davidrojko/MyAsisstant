Public Class odstrani_stranko
    Private Sub odstrani_stranko_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ma_databaseDataSet1.stranke' table. You can move, or remove it, as needed.
        Me.StrankeTableAdapter.Fill(Me.Ma_databaseDataSet1.stranke)

    End Sub

    Private Sub odstrani_btn_Click(sender As Object, e As EventArgs) Handles odstrani_btn.Click
        Dim dataTable As New DataTable()
        DataGridView1.DataSource = dataTable
        ' Check if a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Find the corresponding DataRowView
            Dim selectedDataRowView As DataRowView = DirectCast(selectedRow.DataBoundItem, DataRowView)

            ' Get the DataRow from the DataRowView
            Dim selectedDataRow As DataRow = selectedDataRowView.Row

            ' Remove the DataRow from the DataTable
            DataTable.Rows.Remove(selectedDataRow)
        Else
            MessageBox.Show("Please select a row to delete.", "Delete Row", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class