Public Class Form1
    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblStart.Text = MonthCalendar1.SelectionStart.ToString("dd MMMM yyyy")
        lblEnd.Text = MonthCalendar1.SelectionEnd.ToString("dd MMMM yyyy")
        lblRange.Text = MonthCalendar1.SelectionStart.ToString("dd MMMM") & (" - ") & MonthCalendar1.SelectionEnd.ToString("dd MMMM") &
                        ("   (") & (MonthCalendar1.SelectionEnd - MonthCalendar1.SelectionStart).Days + 1 & (" Days)")
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        lblStart.Text = MonthCalendar1.SelectionStart.ToString("dd MMMM yyyy")
        lblEnd.Text = MonthCalendar1.SelectionEnd.ToString("dd MMMM yyyy")
        lblRange.Text = MonthCalendar1.SelectionStart.ToString("dd MMMM") & (" - ") & MonthCalendar1.SelectionEnd.ToString("dd MMMM") &
                        ("   (") & (MonthCalendar1.SelectionEnd - MonthCalendar1.SelectionStart).Days + 1 & (" Days)")
    End Sub
End Class
