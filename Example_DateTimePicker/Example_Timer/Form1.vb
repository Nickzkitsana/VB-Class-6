Public Class Form1
    Dim sec As Integer = 0
    Dim min As Integer = 0
    Dim hr As Integer = 0

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec = sec + 1

        If sec = 60 Then
            sec = 0
            min = min + 1
            If min = 60 Then
                min = 0
                hr = hr + 1
            End If
        End If
        lblTime.Text = hr.ToString("00") & " : " & min.ToString("00") & " : " & sec.ToString("00")

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub
End Class
