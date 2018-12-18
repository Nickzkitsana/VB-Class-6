Public Class Form1
    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        Dim data As DateTimePicker = DateTimePicker1
        lblMinDate.Text = data.MinDate.ToString("MMMM dd yyyy")
        lblMaxDate.Text = data.MaxDate.ToString("MMMM dd yyyy")
        lblDate.Text = data.Value
        lblDay.Text = data.Value.Day
        lblMonth.Text = data.Value.Month
        lblYear.Text = data.Value.Year
        lblHour.Text = DateTime.Now.Hour
        lblMinute.Text = DateTime.Now.Minute
        lblSecond.Text = DateTime.Now.Second
    End Sub

    Private Sub lblYear_TextChanged(sender As Object, e As EventArgs) Handles lblYear.TextChanged, lblMonth.TextChanged, lblDay.TextChanged
        Dim data As DateTimePicker = DateTimePicker1
        lblMinDate.Text = data.MinDate.ToString("MMMM dd yyyy")
        lblMaxDate.Text = data.MaxDate.ToString("MMMM dd yyyy")
        lblDate.Text = data.Value
        lblDay.Text = data.Value.Day
        lblMonth.Text = data.Value.Month
        lblYear.Text = data.Value.Year
        lblHour.Text = DateTime.Now.Hour
        lblMinute.Text = DateTime.Now.Minute
        lblSecond.Text = DateTime.Now.Second
    End Sub
End Class
