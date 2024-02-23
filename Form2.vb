Public Class Form2


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cboGrade.Items.Clear()
        cboGrade.Items.Add("1")
        cboGrade.Items.Add("2")
        cboGrade.Items.Add("3")



    End Sub






    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        ' Clear the text in lblRan1 and lblRan2
        lblRan1.Text = ""
        lblRan2.Text = ""

        ' Get the selected grade from the combo box
        Dim selectedGrade As Integer = cboGrade.SelectedIndex + 1

        ' Generate a random number based on the selected grade
        Dim rand As New Random()
        Dim num1, num2 As Integer

        If selectedGrade = 1 Then
            num1 = rand.Next(0, 10)
            num2 = rand.Next(0, 10)
        ElseIf selectedGrade = 2 OrElse selectedGrade = 3 Then
            num1 = rand.Next(10, 100)
            num2 = rand.Next(10, 100)
        End If

        ' Set the text of lblRan1 and lblRan2 to the generated numbers
        lblRan1.Text = num1.ToString()
        lblRan2.Text = num2.ToString()

        ' Copy the generated numbers to lblRanOne and lblRanTwo
        lblRanOne.Text = lblRan1.Text
        lblRanTwo.Text = lblRan2.Text
    End Sub


    Private Const MAX_TRIALS As Integer = 5 'maximum number of trials allowed
    Private trialsLeft As Integer = MAX_TRIALS 'number of trials left
    Private correctAns As Integer 'the correct answer

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' check if operation is empty
        If txtOp.Text.Trim() = "" Then
            MessageBox.Show("Operation cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' check if answer is empty
        If txtAns.Text.Trim() = "" Then
            MessageBox.Show("Answer cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' convert answer to integer
        Dim userAnswer As Integer
        If Not Integer.TryParse(txtAns.Text.Trim(), userAnswer) Then
            MessageBox.Show("Answer must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim num1 As Integer = Integer.Parse(lblRan1.Text)
        Dim num2 As Integer = Integer.Parse(lblRan2.Text)
        Dim op As String = txtOp.Text.Trim()

        ' calculate the correct answer based on the operation
        Dim correctAnswer As Integer
        Select Case txtOp.Text.Trim()
            Case "+"
                correctAnswer = num1 + num2
            Case "-"
                correctAnswer = num1 - num2
            Case "*"
                correctAnswer = num1 * num2
            Case "/"
                correctAnswer = num1 \ num2 ' use integer division to avoid decimal answers
            Case Else
                MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        ' check if answer is correct
        If userAnswer = correctAnswer Then
            lblStatus.Text = "Correct!"
            lblStatus.ForeColor = Color.Green
            btnSubmit.Enabled = True
        Else
            ' increment attempts and check if limit has been reached
            trialsLeft -= 1

            If trialsLeft = 0 Then
                MessageBox.Show("You have used all your attempts. The correct answer is " & correctAnswer & ".", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblStatus.Text = "Try again. Answer: " & correctAnswer
                lblStatus.ForeColor = Color.Red
                btnSubmit.Enabled = True
            Else
                MessageBox.Show("Incorrect. You have " & trialsLeft & " attempt(s) remaining.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblStatus.Text = "Try again. Attempts remaining: " & trialsLeft
                lblStatus.ForeColor = Color.Red
            End If
        End If
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'display a message box asking the user if they're sure they want to exit
        Dim result As DialogResult = MessageBox.Show("Do You Want To Quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then 'if the user clicks "Yes"
            Application.Exit() 'close the application
        End If
    End Sub

    Private Sub txtOp_Leave(sender As Object, e As EventArgs) Handles txtOp.Leave
        ' check if the txtOp control is not empty
        If Not String.IsNullOrEmpty(txtOp.Text) Then
            ' set the text of lblOp to the value of txtOp
            lblOp.Text = txtOp.Text
        End If
    End Sub




End Class