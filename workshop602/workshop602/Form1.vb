Public Class Form1
    Dim word() As String = {"Apple", "Bird", "Cats", "Dogs", "Eggs", "Fish"}
    Dim txt As String
    Dim sec As Integer = 20
    Dim ans As Integer = 0
    Dim correct As Integer = 0
    Dim playcount As Integer = 0

    Private Sub lbltime_Click(sender As Object, e As EventArgs) Handles lbltime.Click

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
        Dim rand As Random = New Random
        ans = rand.Next(0, 5)
        lblCharStart.Text = word(ans)(0)
        lblLength.Text = word(ans).Length
        btnStart.Enabled = False


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblCharStart.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblLength.Click

    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        txt = txtguess.Text

        If txt = word(ans) Then
            correct += 1
            playcount += 1
            txtguess.Clear()
        Else
            playcount += 1
            txtguess.Clear()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Time
        sec = sec - 1
        If sec = 0 Then
            Timer1.Stop()
            btnStart.Enabled = True
            txtguess.Enabled = False
            lbltime.Text = "0"
            MessageBox.Show("Guess " & playcount & " words" & vbNewLine &
                            "Correct " & correct & " words")
            lblCharStart.Text = ""
            lblLength.Text = ""
            txtguess.Clear()
        End If

        lbltime.Text = sec
    End Sub
End Class
