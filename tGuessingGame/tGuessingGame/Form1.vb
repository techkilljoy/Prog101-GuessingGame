Public Class Form1
    'global variable declarations since they will be used in multiple procedures
    Dim intMax As Integer = 10
    Dim intMin As Integer = 1
    Dim intSecret As Integer

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        'get players guess
        Dim intGuess As Integer = Val(Me.txtGuess.Text)

        'compare the guess and secret num
        If intGuess = intSecret Then
            Me.lblAnswer.Text = "You guessed it!!!"
            Me.btnReset.Visible = True
        ElseIf intGuess > intMax Or intGuess < intMin Then
            Me.lblAnswer.Text = "Read the instructions, FOOL!"
        ElseIf intGuess > intSecret Then
            Me.lblAnswer.Text = "You are high, man."
        ElseIf intGuess < intSecret Then
            Me.lblAnswer.Text = "You are low, man."
        Else
            Me.lblAnswer.Text = "ERROR- I messed up my program and called the ELSE statement!"
        End If
    End Sub

    Private Sub txtGuess_TextChanged(sender As Object, e As EventArgs) Handles txtGuess.TextChanged
        'clear lblAnswer when new guess is typed in txtGuess
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'generate a random secret number
        Randomize()
        intSecret = Int((intMax - intMin + 1) * Rnd() + 1)
        Me.btnReset.Visible = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'generate a random secret number
        Randomize()
        intSecret = Int((intMax - intMin + 1) * Rnd() + 1)
        'clear the form txt and lbl
        Me.lblAnswer.Text = ""
        Me.txtGuess.Text = ""
        'reset the form
        Me.btnReset.Visible = False
    End Sub
End Class
