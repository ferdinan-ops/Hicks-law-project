Public Class Hick_Law_Game

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        lbl_time.Text = Val(lbl_time.Text) + 1
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        lbl_petunjuk.Visible = True
        Timer1.Enabled = True
        klik20.Show()
        klik16.Show()
        klik7.Show()
        lbl_petunjuk.Text = "Click The Smallest Red Button"
        lbl_petunjuk.ForeColor = Color.Red
        lbl_ronde.Text = "1/10"
    End Sub

    Private Sub Hick_Law_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        klik1.Hide()
        klik2.Hide()
        klik3.Hide()
        klik4.Hide()
        klik5.Hide()
        klik6.Hide()
        klik7.Hide()
        klik8.Hide()
        klik9.Hide()
        klik10.Hide()
        klik11.Hide()
        klik12.Hide()
        klik13.Hide()
        klik14.Hide()
        klik15.Hide()
        klik16.Hide()
        klik17.Hide()
        klik18.Hide()
        klik19.Hide()
        klik20.Hide()
        klik21.Hide()
        klik22.Hide()
        klik23.Hide()
        klik24.Hide()
        klik25.Hide()
        GunaCircleButton1.Hide()
        GunaCircleButton2.Hide()
        GunaCircleButton3.Hide()
        GunaCircleButton4.Hide()
        GunaCircleButton5.Hide()
        GunaCircleButton6.Hide()
        lbl_petunjuk.Visible = False
    End Sub

    Private Sub klik20_Click(sender As Object, e As EventArgs) Handles klik20.Click
        lbl_petunjuk.Text = "Click The Bigest Red Circle"
        lbl_petunjuk.ForeColor = Color.Red
        klik12.Show()
        klik1.Show()
        klik11.Show()
        klik5.Show()
        klik2.Show()
        klik3.Show()
        klik22.Show()
        klik20.Hide()
        klik16.Hide()
        klik7.Hide()
        lbl_ronde.Text = "2/10"
        Hick_Law_Hasil.Time_1.Text = Val(lbl_time.Text)
    End Sub

    Private Sub klik1_Click(sender As Object, e As EventArgs) Handles klik1.Click
        lbl_petunjuk.Text = "Click The Bigest Blue Circle"
        lbl_petunjuk.ForeColor = Color.Blue
        klik14.Show()
        klik17.Show()
        klik6.Show()
        klik13.Show()
        klik7.Show()

        klik12.Hide()
        klik1.Hide()
        klik11.Hide()
        klik5.Hide()
        klik2.Hide()
        klik3.Hide()
        klik22.Hide()
        lbl_ronde.Text = "3/10"
        Hick_Law_Hasil.Time_2.Text = Val(lbl_time.Text) - Val(Hick_Law_Hasil.Time_1.Text)
    End Sub

    Private Sub klik6_Click(sender As Object, e As EventArgs) Handles klik6.Click
        lbl_petunjuk.Text = "Click The Smallest Orange Circle"
        lbl_petunjuk.ForeColor = Color.Orange
        klik5.Show()
        klik22.Show()
        klik2.Show()
        klik19.Show()
        klik15.Show()
        klik4.Show()
        klik13.Show()


        klik14.Hide()
        klik17.Hide()
        klik6.Hide()
        klik13.Hide()
        klik7.Hide()
        lbl_ronde.Text = "4/10"
        Hick_Law_Hasil.Time_3.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text))
    End Sub

    Private Sub klik15_Click(sender As Object, e As EventArgs) Handles klik15.Click
        lbl_petunjuk.Text = "Click The Smallest Blue Circle"
        lbl_petunjuk.ForeColor = Color.Blue
        klik9.Show()
        klik10.Show()
        klik11.Show()
        klik1.Show()
        klik3.Show()
        klik17.Show()
        klik18.Show()
        klik14.Show()

        klik5.Hide()
        klik22.Hide()
        klik2.Hide()
        klik19.Hide()
        klik15.Hide()
        klik4.Hide()
        klik13.Hide()
        lbl_ronde.Text = "5/10"
        Hick_Law_Hasil.Time_4.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text) + Val(Hick_Law_Hasil.Time_3.Text))
    End Sub

    Private Sub klik14_Click(sender As Object, e As EventArgs) Handles klik14.Click
        lbl_petunjuk.Text = "Click The Bigest Orange Circle"
        lbl_petunjuk.ForeColor = Color.Orange

        klik9.Show()
        klik11.Show()
        klik5.Show()
        klik2.Show()
        klik4.Show()
        klik8.Show()
        klik3.Show()
        klik6.Show()
        klik13.Show()

        klik10.Hide()
        klik1.Hide()
        klik17.Hide()
        klik18.Hide()
        klik14.Hide()
        lbl_ronde.Text = "6/10"
        Hick_Law_Hasil.Time_5.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text) + Val(Hick_Law_Hasil.Time_3.Text) + Val(Hick_Law_Hasil.Time_4.Text))
    End Sub

    Private Sub klik2_Click(sender As Object, e As EventArgs) Handles klik2.Click
        lbl_petunjuk.Text = "Click The Smallest Green Circle"
        lbl_petunjuk.ForeColor = Color.Green

        klik3.Show()
        klik25.Show()
        klik22.Show()
        klik23.Show()
        klik11.Show()
        klik5.Show()
        klik2.Show()
        klik1.Show()
        klik6.Show()
        klik8.Show()

        klik9.Hide()
        klik4.Hide()
        klik6.Hide()
        klik13.Hide()
        lbl_ronde.Text = "7/10"
        Hick_Law_Hasil.Time_6.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text) + Val(Hick_Law_Hasil.Time_3.Text) + Val(Hick_Law_Hasil.Time_4.Text) + Val(Hick_Law_Hasil.Time_5.Text))
    End Sub

    Private Sub klik25_Click(sender As Object, e As EventArgs) Handles klik25.Click
        lbl_petunjuk.Text = "Click The Bigest Green Circle"
        lbl_petunjuk.ForeColor = Color.Green
        klik3.Show()
        klik25.Show()
        klik22.Show()
        klik23.Show()
        klik11.Show()
        klik5.Show()
        klik2.Show()
        klik1.Show()
        klik6.Show()
        klik8.Show()
        klik24.Show()
        klik9.Show()
        klik4.Show()
        klik6.Show()
        klik13.Show()

        lbl_ronde.Text = "8/10"
        Hick_Law_Hasil.Time_7.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text) + Val(Hick_Law_Hasil.Time_3.Text) + Val(Hick_Law_Hasil.Time_4.Text) + Val(Hick_Law_Hasil.Time_5.Text) + Val(Hick_Law_Hasil.Time_6.Text))
    End Sub

    Private Sub klik3_Click(sender As Object, e As EventArgs) Handles klik3.Click
        lbl_petunjuk.Text = "Click The Smallest Black Circle"
        lbl_petunjuk.ForeColor = Color.Black

        GunaCircleButton1.Show()
        GunaCircleButton2.Show()
        GunaCircleButton5.Show()
        GunaCircleButton6.Show()
        klik3.Show()
        klik25.Show()
        klik22.Show()
        klik23.Show()
        klik11.Show()
        klik5.Show()
        klik2.Show()
        klik1.Show()
        klik6.Show()
        klik8.Show()
        klik24.Show()
        klik9.Show()

        klik4.Hide()
        klik6.Hide()
        klik13.Hide()
        lbl_ronde.Text = "9/10"
        Hick_Law_Hasil.Time_8.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text) + Val(Hick_Law_Hasil.Time_3.Text) + Val(Hick_Law_Hasil.Time_4.Text) + Val(Hick_Law_Hasil.Time_5.Text) + Val(Hick_Law_Hasil.Time_6.Text) + Val(Hick_Law_Hasil.Time_7.Text))
    End Sub

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles GunaCircleButton5.Click
        lbl_petunjuk.Text = "Click The Bigest Black Circle"
        lbl_petunjuk.ForeColor = Color.Black

        GunaCircleButton1.Show()
        GunaCircleButton2.Show()
        GunaCircleButton3.Show()
        GunaCircleButton4.Show()
        GunaCircleButton5.Show()
        GunaCircleButton6.Show()
        klik3.Show()
        klik25.Show()
        klik22.Show()
        klik23.Show()
        klik11.Show()
        klik5.Show()
        klik2.Show()
        klik1.Show()
        klik6.Show()
        klik8.Show()
        klik24.Show()
        klik9.Show()
        klik4.Show()
        klik6.Show()
        klik13.Show()

        lbl_ronde.Text = "10/10"
        Hick_Law_Hasil.Time_9.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text) + Val(Hick_Law_Hasil.Time_3.Text) + Val(Hick_Law_Hasil.Time_4.Text) + Val(Hick_Law_Hasil.Time_5.Text) + Val(Hick_Law_Hasil.Time_6.Text) + Val(Hick_Law_Hasil.Time_7.Text) + Val(Hick_Law_Hasil.Time_8.Text))
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Hick_Law_Hasil.Time_10.Text = Val(lbl_time.Text) - (Val(Hick_Law_Hasil.Time_1.Text) + Val(Hick_Law_Hasil.Time_2.Text) + Val(Hick_Law_Hasil.Time_3.Text) + Val(Hick_Law_Hasil.Time_4.Text) + Val(Hick_Law_Hasil.Time_5.Text) + Val(Hick_Law_Hasil.Time_6.Text) + Val(Hick_Law_Hasil.Time_7.Text) + Val(Hick_Law_Hasil.Time_8.Text) + Val(Hick_Law_Hasil.Time_9.Text))
        Timer1.Stop()
        Dim tanya
        tanya = MessageBox.Show("Anda Telah Menyelesaikan Permainan. Ingin Melihat Hasil ??", "Selamat !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Me.Hide()
            Hick_Law_Hasil.Show()
        Else
            Timer1.Enabled = False
            lbl_ronde.Text = "0/10"
            lbl_time.Text = 0
        End If
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        Hick_Law___Petunjuk.Show()
    End Sub
End Class