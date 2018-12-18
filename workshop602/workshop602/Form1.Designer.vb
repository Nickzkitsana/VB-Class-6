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
        Me.components = New System.ComponentModel.Container()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCharStart = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtguess = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(23, 50)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(91, 46)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lbltime
        '
        Me.lbltime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbltime.Location = New System.Drawing.Point(149, 50)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(216, 44)
        Me.lbltime.TabIndex = 1
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAnswer.Location = New System.Drawing.Point(247, 255)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(124, 39)
        Me.btnAnswer.TabIndex = 2
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hint: Start with"
        '
        'lblCharStart
        '
        Me.lblCharStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCharStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCharStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCharStart.Location = New System.Drawing.Point(149, 129)
        Me.lblCharStart.Name = "lblCharStart"
        Me.lblCharStart.Size = New System.Drawing.Size(51, 30)
        Me.lblCharStart.TabIndex = 4
        Me.lblCharStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLength
        '
        Me.lblLength.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblLength.Location = New System.Drawing.Point(258, 129)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(54, 30)
        Me.lblLength.TabIndex = 5
        Me.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(206, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Have"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(318, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "letters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(22, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Guess Word"
        '
        'txtguess
        '
        Me.txtguess.Location = New System.Drawing.Point(148, 199)
        Me.txtguess.Name = "txtguess"
        Me.txtguess.Size = New System.Drawing.Size(216, 20)
        Me.txtguess.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 327)
        Me.Controls.Add(Me.txtguess)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblCharStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lbltime As Label
    Friend WithEvents btnAnswer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCharStart As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtguess As TextBox
    Friend WithEvents Timer1 As Timer
End Class
