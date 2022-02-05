Imports System.Windows.Forms.DataVisualization.Charting
Public Class Hick_Law_Hasil

    Private Sub Hick_Law_Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Titles.Add("HICK LAW GRAPHIC") 'Judul grafik
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add("Default")
        With Chart1.ChartAreas("Default")
            .AxisX.Title = "Round"
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = "Round Time (ms)"
        End With
        'Menambahkan series pada chart
        Chart1.Series.Clear()
        Chart1.Series.Add("Round")
        Chart1.Series("Round").Color = Color.Gray
        Chart1.Series("Round").ChartType =
       DataVisualization.Charting.SeriesChartType.Line

        Chart1.Series.Add("Times")
        Chart1.Series("Times").Color = Color.Chocolate
        Chart1.Series("Times").ChartType =
       DataVisualization.Charting.SeriesChartType.Line

        Chart1.Series("Round").Points.AddXY(1, Val(Distance_1.Text))
        Chart1.Series("Round").Points.AddXY(2, Val(Distance_2.Text))
        Chart1.Series("Round").Points.AddXY(3, Val(Distance_3.Text))
        Chart1.Series("Round").Points.AddXY(4, Val(Distance_4.Text))
        Chart1.Series("Round").Points.AddXY(5, Val(Distance_5.Text))
        Chart1.Series("Round").Points.AddXY(6, Val(Distance_6.Text))
        Chart1.Series("Round").Points.AddXY(7, Val(Distance_7.Text))
        Chart1.Series("Round").Points.AddXY(8, Val(Distance_8.Text))
        Chart1.Series("Round").Points.AddXY(9, Val(Distance_9.Text))
        Chart1.Series("Round").Points.AddXY(10, Val(Distance_10.Text))

        Chart1.Series("Times").Points.AddXY(1, Val(Time_1.Text))
        Chart1.Series("Times").Points.AddXY(2, Val(Time_2.Text))
        Chart1.Series("Times").Points.AddXY(3, Val(Time_3.Text))
        Chart1.Series("Times").Points.AddXY(4, Val(Time_4.Text))
        Chart1.Series("Times").Points.AddXY(5, Val(Time_5.Text))
        Chart1.Series("Times").Points.AddXY(6, Val(Time_6.Text))
        Chart1.Series("Times").Points.AddXY(7, Val(Time_7.Text))
        Chart1.Series("Times").Points.AddXY(8, Val(Time_8.Text))
        Chart1.Series("Times").Points.AddXY(9, Val(Time_9.Text))
        Chart1.Series("Times").Points.AddXY(10, Val(Time_10.Text))

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        End
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
        Hick__Law.Show()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Hick_Law_Game.Timer1.Enabled = False
        Hick_Law_Game.lbl_ronde.Text = "0/10"
        Hick_Law_Game.lbl_time.Text = 0
        Me.Hide()
        Hick_Law_Game.Show()
    End Sub
End Class