Imports System.Data.SqlClient

Public Class dodaj_stranko
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=ma_database;User Id=sa;Password=R0jk0d131998;"

    Private Async Sub vnesi_btn_Click(sender As Object, e As EventArgs) Handles vnesi_btn.Click
        ' Retrieve values from textboxes
        Dim ime As String = ime_vnos.Text.Trim()
        Dim priimek As String = priimek_vnos.Text.Trim()
        Dim naslov As String = naslov_vnos.Text.Trim()
        Dim eposta As String = eposta_vnos.Text.Trim()

        ' Insert data into the database asynchronously
        Dim success As Boolean = Await VnesiPodatkeAsync(ime, priimek, naslov, eposta)

        ' Display a message based on the result
        If success Then
            MessageBox.Show("Data successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Async Function VnesiPodatkeAsync(ime As String, priimek As String, naslov As String, eposta As String) As Task(Of Boolean)
        Using connection As New SqlConnection(connectionString)
            Await connection.OpenAsync()

            Dim query As String = "INSERT INTO stranke (ime, priimek, naslov, eposta) VALUES (@ime, @priimek, @naslov, @eposta)"
            Using command As New SqlCommand(query, connection)
                ' Add parameters to the SqlCommand
                command.Parameters.AddWithValue("@ime", ime)
                command.Parameters.AddWithValue("@priimek", priimek)
                command.Parameters.AddWithValue("@naslov", naslov)
                command.Parameters.AddWithValue("@eposta", eposta)

                ' Execute the query asynchronously
                Dim rowsAffected As Integer = Await command.ExecuteNonQueryAsync()

                ' Check if the insert was successful
                Return rowsAffected > 0
            End Using
        End Using
    End Function
End Class