Public Class MainForm
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnhombre.Click
        btnhombre.ForeColor = Color.SteelBlue
        btnmujer.ForeColor = Color.Black
        btncalzado.ForeColor = Color.Black
        btnaccesorio.ForeColor = Color.Black
    End Sub

    Private Sub btnmujer_Click(sender As Object, e As EventArgs) Handles btnmujer.Click
        btnmujer.ForeColor = Color.SteelBlue
        btnhombre.ForeColor = Color.Black
        btncalzado.ForeColor = Color.Black
        btnaccesorio.ForeColor = Color.Black
    End Sub

    Private Sub btncalzado_Click(sender As Object, e As EventArgs) Handles btncalzado.Click
        btncalzado.ForeColor = Color.SteelBlue
        btnaccesorio.ForeColor = Color.Black
        btnmujer.ForeColor = Color.Black
        btnhombre.ForeColor = Color.Black
    End Sub

    Private Sub btnaccesorio_Click(sender As Object, e As EventArgs) Handles btnaccesorio.Click

        btnaccesorio.ForeColor = Color.SteelBlue
        btnmujer.ForeColor = Color.Black
        btnhombre.ForeColor = Color.Black
        btncalzado.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PictureBox1.Image = hombres - 1.Images.Item(0)
    End Sub
End Class