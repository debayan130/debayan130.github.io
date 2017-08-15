Public Class Form3
    Dim a As Integer
    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            '  TextBox1.BackColor And TextBox2.BackColor And TextBox9.BackColor And TextBox8.BackColor=Color.AliceBlue
            TextBox1.BackColor = Color.Red
            TextBox2.BackColor = Color.Red
            ' TextBox8.BackColor = Color.Red
            ' TextBox9.BackColor = Color.Red

            MsgBox("Field reqquired")



        Else
            For i = 0 To TextBox1.TextLength
                a = CInt(Math.Floor((9999 - 1111 + 1) * Rnd())) + 1111
            Next
            TextBox9.Text = TextBox2.Text + a.ToString
            TextBox8.Text = "AC" + TextBox4.Text + TextBox5.Text
            FbookBindingSource.EndEdit()
            FbookTableAdapter.Update(Flight_registrationDataSet.fbook)
            MsgBox("booked.Note down customer id")
            TextBox8.Visible = True
            TextBox9.Visible = True
            Label20.Visible = True
            Label19.Visible = True
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        TextBox8.Visible = False
        TextBox9.Visible = False
        Label20.Visible = False
        Label19.Visible = False
        'TODO: This line of code loads data into the 'Flight_registrationDataSet.fbook' table. You can move, or remove it, as needed.
        Me.FbookTableAdapter.Fill(Me.Flight_registrationDataSet.fbook)
        FbookBindingSource.AddNew()
        ORI.Text = Form2.ComboBox1.Text
        DES.Text = Form2.ComboBox2.Text
        clas.Text = Form2.ComboBox3.Text
        fare.Text = Form2.TextBox5.Text


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles DES.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class