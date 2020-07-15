Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2DataGridView1.Rows.Add(4)
        Guna2DataGridView1.Rows(0).Cells(0).Value = Image.FromFile("img\\music_26px.png")
        Guna2DataGridView1.Rows(0).Cells(1).Value = "Blink 182 - Dogs Eating Dogs"
        Guna2DataGridView1.Rows(0).Cells(2).Value = "03.44"

        Guna2DataGridView1.Rows(1).Cells(0).Value = Image.FromFile("img\\music_26px.png")
        Guna2DataGridView1.Rows(1).Cells(1).Value = "Jason Ranti - Variasi Pink"
        Guna2DataGridView1.Rows(1).Cells(2).Value = "04.44"

        Guna2DataGridView1.Rows(2).Cells(0).Value = Image.FromFile("img\\music_26px.png")
        Guna2DataGridView1.Rows(2).Cells(1).Value = "Simple Plan"
        Guna2DataGridView1.Rows(2).Cells(2).Value = "02.44"

        Guna2DataGridView1.Rows(3).Cells(0).Value = Image.FromFile("img\\music_26px.png")
        Guna2DataGridView1.Rows(3).Cells(1).Value = "Dj Slebor 2020"
        Guna2DataGridView1.Rows(3).Cells(2).Value = "59.44"
    End Sub
End Class
