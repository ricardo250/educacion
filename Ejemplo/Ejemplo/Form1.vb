Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "ricardo" And TextBox2.Text = "1234" Then
            MsgBox("Contraseña insertada correcta")
            Form2.Show()
        Else
            MsgBox("Usuario o contraseña incorrecta")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
