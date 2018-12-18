<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblMinDate = New System.Windows.Forms.Label()
        Me.lblMaxDate = New System.Windows.Forms.Label()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblMinute = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 25)
        Me.DateTimePicker1.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(227, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'lblMinDate
        '
        Me.lblMinDate.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblMinDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinDate.Location = New System.Drawing.Point(24, 106)
        Me.lblMinDate.Name = "lblMinDate"
        Me.lblMinDate.Size = New System.Drawing.Size(308, 28)
        Me.lblMinDate.TabIndex = 2
        Me.lblMinDate.Text = "Show MinDate"
        Me.lblMinDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaxDate
        '
        Me.lblMaxDate.BackColor = System.Drawing.Color.MistyRose
        Me.lblMaxDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDate.Location = New System.Drawing.Point(24, 149)
        Me.lblMaxDate.Name = "lblMaxDate"
        Me.lblMaxDate.Size = New System.Drawing.Size(308, 28)
        Me.lblMaxDate.TabIndex = 3
        Me.lblMaxDate.Text = "Show MaxDate"
        Me.lblMaxDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnShowDate
        '
        Me.btnShowDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDate.Location = New System.Drawing.Point(24, 56)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(308, 37)
        Me.btnShowDate.TabIndex = 4
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Snow
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(24, 192)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(308, 28)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Show Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.Color.LightGreen
        Me.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(24, 236)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(80, 28)
        Me.lblDay.TabIndex = 7
        Me.lblDay.Text = "Day"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.LightGreen
        Me.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(119, 236)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(116, 28)
        Me.lblMonth.TabIndex = 8
        Me.lblMonth.Text = "Month"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.LightGreen
        Me.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(252, 236)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(80, 28)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Year"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSecond
        '
        Me.lblSecond.BackColor = System.Drawing.Color.Thistle
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(252, 276)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(80, 28)
        Me.lblSecond.TabIndex = 12
        Me.lblSecond.Text = "Second"
        Me.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMinute
        '
        Me.lblMinute.BackColor = System.Drawing.Color.Thistle
        Me.lblMinute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.Location = New System.Drawing.Point(119, 276)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(116, 28)
        Me.lblMinute.TabIndex = 11
        Me.lblMinute.Text = "Minute"
        Me.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHour
        '
        Me.lblHour.BackColor = System.Drawing.Color.Thistle
        Me.lblHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.Location = New System.Drawing.Point(24, 276)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(80, 28)
        Me.lblHour.TabIndex = 10
        Me.lblHour.Text = "Hour"
        Me.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 329)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblMinute)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.lblMaxDate)
        Me.Controls.Add(Me.lblMinDate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblMinDate As Label
    Friend WithEvents lblMaxDate As Label
    Friend WithEvents btnShowDate As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblMinute As Label
    Friend WithEvents lblHour As Label
End Class
