Public Class Form1
    Dim op1 As Integer
    Dim op2 As Integer
    Dim resultado As Integer



    Private Sub Sumabtn_Click(sender As Object, e As EventArgs) Handles Sumabtn.Click


        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 + op2

        Label2.Text = resultado.ToString()

    End Sub

    Private Sub Restarbtb_Click(sender As Object, e As EventArgs) Handles Restarbtb.Click


        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 - op2

        Label2.Text = resultado.ToString()
    End Sub
End Class
