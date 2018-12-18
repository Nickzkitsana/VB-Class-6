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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar1.MaxSelectionCount = 10
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.Snow
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(257, 70)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(308, 28)
        Me.lblStart.TabIndex = 10
        Me.lblStart.Text = "Show Start Date"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnShowDate
        '
        Me.btnShowDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDate.Location = New System.Drawing.Point(257, 18)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(308, 37)
        Me.btnShowDate.TabIndex = 14
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'lblEnd
        '
        Me.lblEnd.BackColor = System.Drawing.Color.Snow
        Me.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(257, 112)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(308, 28)
        Me.lblEnd.TabIndex = 15
        Me.lblEnd.Text = "Show End Date"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRange
        '
        Me.lblRange.BackColor = System.Drawing.Color.Snow
        Me.lblRange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRange.Location = New System.Drawing.Point(257, 152)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(308, 28)
        Me.lblRange.TabIndex = 16
        Me.lblRange.Text = "Show Range"
        Me.lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 196)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lblStart As Label
    Friend WithEvents btnShowDate As Button
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblRange As Label
End Class
