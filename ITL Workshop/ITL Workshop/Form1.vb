'John-Jeremy Williams
'ITL Workshop
'3/13/2025



Public Class Form1



    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click

        Dim customerName As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()

        ' Basic validation
        If customerName = "" Or email = "" Or phone = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Display customer details
        Dim customerDetails As String = "Customer Information:" & vbCrLf &
                                        "Name: " & customerName & vbCrLf &
                                        "Email: " & email & vbCrLf &
                                        "Phone: " & phone

        MessageBox.Show(customerDetails, "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Clear fields after submission
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()


    End Sub

End Class
