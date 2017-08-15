Public Class Form4
    Dim i As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Flight_registrationDataSet.fbook' table. You can move, or remove it, as needed.
        Me.FbookTableAdapter.Fill(Me.Flight_registrationDataSet.fbook)
        TextBox2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MsgBox("give a valid id")
        Else
            For i = 0 To 500
                If TextBox1.Text = TextBox2.Text Then
                    MsgBox("found")
                    Exit For
                Else
                    FbookBindingSource.MoveNext()

                End If
            Next

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FbookBindingSource.RemoveCurrent()
        FbookTableAdapter.Update(Flight_registrationDataSet.fbook)
        MsgBox("deleted")
        TextBox1.Text = Nothing

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form4_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub
End Class