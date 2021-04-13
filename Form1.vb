Public Class Form1
    Dim a, b, c, det As Single
    Dim root1, root2 As Single
    Dim real, img As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        det = (b ^ 2) - (4 * a * c)
        If (det > 0) Then
            root1 = (-b + Math.Sqrt(det)) / 2 * a
            root2 = (-b - Math.Sqrt(det)) / 2 * a
            TextBox4.Text = root1
            TextBox5.Text = root2
            TextBox6.Text = "Real"
        ElseIf (det < 0) Then
            real = (-b / (2 * a))
            img = Math.Sqrt(-det) / (2 * a)
            TextBox4.Text = real + img
            TextBox5.Text = (real - img)
            TextBox6.Text = "Imaginary"
        ElseIf (det = 0) Then
            root1 = -b / (2 * a)
            TextBox4.Text = root1
            TextBox5.Text = root1
            TextBox6.Text = "Singular"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class
