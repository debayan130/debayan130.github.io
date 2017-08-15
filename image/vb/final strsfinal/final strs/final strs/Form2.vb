Public Class Form2
    Dim f As Integer
    Dim fare As Integer
    ' Dim i, j, k As Integer
    Dim found As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Flight_registrationDataSet.search' table. You can move, or remove it, as needed.
        Me.SearchTableAdapter.Fill(Me.Flight_registrationDataSet.search)
        Button2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        Label2.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        rd.Visible = False
        rdd.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        rd.Visible = True
        rdd.Visible = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.Text = ComboBox2.Text Then
            MsgBox("ORIGIN DESTINATION CANNOT BE SAME")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, k As Integer
        i = 0
        j = 0
        k = 0

        For i = 0 To 500
            If ComboBox1.Text = TextBox1.Text Then
                For j = 0 To 500
                    If ComboBox2.Text = TextBox2.Text Then
                        For k = 0 To 500
                            If ComboBox3.Text = TextBox4.Text Then
                                ' MsgBox("found")

                                found = True

                                Exit For
                            Else
                                SearchBindingSource.MoveNext()
                            End If
                        Next
                        Exit For
                    Else
                        SearchBindingSource.MoveNext()
                    End If
                Next
                Exit For
            Else
                SearchBindingSource.MoveNext()

            End If
        Next i
        ' found = False
        If found = False Then
            MsgBox("Not found")
            Button2.Visible = False
            TextBox5.Visible = False
            Me.Close()
        Else

            MsgBox("foumd")
            fare = Math.Abs((ComboBox1.SelectedIndex - ComboBox2.SelectedIndex) * (-1000) + ComboBox3.SelectedIndex * (-300))
            TextBox5.Text = fare
            Button2.Visible = True
            TextBox5.Visible = True
            Label2.Visible = True
        End If
        i = 0
        j = 0
        k = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class