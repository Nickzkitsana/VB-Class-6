Public Class Form1
    Dim id As String
    Dim fullname As String
    Dim email As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id = txtId.Text
        fullname = txtName.Text
        email = txtEmail.Text
        TabControl1.SelectedIndex = 1
        lblFullname.Text = "ID : " & id & " / Name : " & fullname
    End Sub

    Private Sub listSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSubject.SelectedIndexChanged

    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubject.SelectedIndexChanged
        listSubject.Items.Add(cmbSubject.SelectedItem)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim subj As String = ""

        For Each item In listSubject.Items
            subj &= item & " / " & vbNewLine
        Next


        MessageBox.Show("ID : " & id & vbNewLine &
                        "Name : " & fullname & vbNewLine &
                        "E-mail : " & email & vbNewLine &
                        "List of Enroll Subject : " & subj)
    End Sub
End Class
