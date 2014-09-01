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
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lblInstr = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(87, 87)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 0
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lblInstr
        '
        Me.lblInstr.AutoSize = True
        Me.lblInstr.Location = New System.Drawing.Point(27, 54)
        Me.lblInstr.Name = "lblInstr"
        Me.lblInstr.Size = New System.Drawing.Size(131, 13)
        Me.lblInstr.TabIndex = 1
        Me.lblInstr.Text = "Pick a number from 1 - 10:"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(164, 51)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtGuess.TabIndex = 2
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(105, 142)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 3
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(87, 227)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblInstr)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "Form1"
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents lblInstr As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
