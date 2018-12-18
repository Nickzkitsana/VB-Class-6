Public Class Form1
    Dim word() As String = {"Apple", "Bird", "Cats", "Dogs", "Eggs", "Fish", "Test"}
    Dim txt As String
    Dim sec As Integer = 0
    Dim milisec As Integer = 0
    Dim ans As Integer = 0
    Dim correct As Integer = 0
    Dim playcount As Integer = 0
    Dim rand As Random = New Random

    Private Sub lbltime_Click(sender As Object, e As EventArgs) Handles lbltime.Click

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
        ans = rand.Next(0, word.Length)
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

        If txt.ToLower = word(ans).ToLower Then
            correct += 1
            playcount += 1
            txtguess.Clear()
            ans = rand.Next(0, word.Length)
            lblCharStart.Text = word(ans)(0)
            lblLength.Text = word(ans).Length

        Else
            playcount += 1
            txtguess.Clear()
            ans = rand.Next(0, word.Length)
            lblCharStart.Text = word(ans)(0)
            lblLength.Text = word(ans).Length
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Time
        milisec = milisec + 1
        If milisec = 60 Then
            milisec = 0
            sec = sec + 1
            If sec = 20 Then
                Timer1.Stop()
                btnStart.Enabled = True
                txtguess.Enabled = False
                sec = 0
                milisec = 0
                lbltime.Text = sec.ToString("00") & ":" & milisec.ToString("00")
                lblCharStart.Text = ""
                lblLength.Text = ""
                txtguess.Clear()
                MessageBox.Show("Guess " & playcount & " words" & vbNewLine &
                                "Correct " & correct & " words")
                txtguess.Enabled = True

            End If
        End If

        lbltime.Text = sec.ToString("00") & ":" & milisec.ToString("00")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltime.Text = sec.ToString("00") & ":" & milisec.ToString("00")
    End Sub
End Class
