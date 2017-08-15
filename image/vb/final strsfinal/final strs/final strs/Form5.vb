Public Class Form5
    Dim waitTime As Integer = 500 'ms

    Dim speed As Integer = 60 'ms

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label4.Visible = True
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Visible = False
        My.Computer.Audio.Play(My.Resources.Mw3credits, AudioPlayMode.Background)
        ani.Interval = speed

        wait.Interval = waitTime

        wait.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.Audio.Stop()
        Me.Close()

    End Sub

    Private Sub wait_Tick(sender As Object, e As EventArgs) Handles wait.Tick
        wait.Enabled = False

        ani.Enabled = True
    End Sub

    Private Sub ani_Tick(sender As Object, e As EventArgs) Handles ani.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + 1)
        PictureBox2.Location = New Point(PictureBox2.Location.X, PictureBox2.Location.Y + 1)


        If PictureBox1.Location.Y = 205 Then ani.Enabled = False
    End Sub
End Classass Class