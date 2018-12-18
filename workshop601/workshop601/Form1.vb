Public Class Form1
    Private Sub lblStartDate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        TabControl1.SelectedIndex = 2
        lblResult.Text = "เลขบัตรประชาชน : " & txtID.Text & vbNewLine &
                         "ชื่อ - นามสกุล : " & txtFullname.Text & vbNewLine &
                         "เบอร์โทรศัพท์ : " & txtPhone.Text & vbNewLine &
                         "จองตั้งแต่วันที่ : " & lblStartDate.Text & vbNewLine &
                         "จองจนถึงวันที่ : " & lblEndDate.Text & vbNewLine &
                         "จำนวนวันรวม : " & lblCount.Text & " วัน"
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        lblStartDate.Text = MonthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy")
        lblEndDate.Text = MonthCalendar1.SelectionEnd.ToString("dd-MMMM-yyyy")
        lblCount.Text = (MonthCalendar1.SelectionEnd - MonthCalendar1.SelectionStart).Days + 1
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If txtID.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนเลขรหัสประชาชน")
        ElseIf txtFullname.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนชื่อ - นามสกุล")
        ElseIf txtPhone.TextLength = 0 Then
            MessageBox.Show("กรุณาป้อนเลขโทรศัพท์")
        Else
            TabControl1.SelectedIndex = 1
        End If
    End Sub
End Class
