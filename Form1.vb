Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' get the selected date from the datetime picker
        Dim selectedDate As Date = dtpOne.Value

        ' calculate the age
        Dim age As Integer = Today.Year - selectedDate.Year
        If Today < selectedDate.AddYears(age) Then
            age -= 1
        End If

        ' determine if the age is within the range
        If age < 4 Then
            ' too young
            MessageBox.Show("Oops! You are too young for this.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf age > 8 Then
            ' too old
            MessageBox.Show("Ooh, this is too basic for you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' open form2
            Dim frm2 As New Form2()
            frm2.Show()
            Me.Hide()
        End If
    End Sub

End Class
