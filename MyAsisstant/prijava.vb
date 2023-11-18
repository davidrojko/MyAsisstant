Imports System.Data.SqlClient

Public Class prijava
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=ma_database;User Id=sa;Password=R0jk0d131998;"

    Private Sub prijava_btn_Click(sender As Object, e As EventArgs) Handles prijava_btn.Click
        Dim username As String = username_vnos.Text.Trim()
        Dim password As String = pass_vnos.Text.Trim()


        If AuthenticateUser(username, password) Then
            Dim glavni_meni As New glavni_meni()
            glavni_meni.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND pass = @pass"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@pass", password)

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return result > 0
            End Using
        End Using
    End Function
End Class