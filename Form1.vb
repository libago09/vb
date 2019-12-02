Public Class Factorial
    Dim startNumber As Integer
    Dim endNumber As Integer
    Dim finalAnswer As Integer

    Private Sub Solve_Click(sender As Object, e As EventArgs) Handles Solve.Click
        TextBox3.Clear()

        Dim errorFound As Boolean
        Dim exitLoop As Boolean
        Dim listOfErrors As String
        errorFound = True
        exitLoop = False

        While exitLoop = False
            If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Then
                listOfErrors = listOfErrors & "No text box should be empty" & vbCrLf
                If TextBox1.Text = String.Empty Then
                    listOfErrors = listOfErrors & "     First text box is empty" & vbCrLf
                End If

                If TextBox2.Text = String.Empty Then
                    listOfErrors = listOfErrors & "     Second text box is empty" & vbCrLf
                End If

            ElseIf IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
                listOfErrors = listOfErrors & "No text box should be using letters" & vbCrLf
                If Not IsNumeric(TextBox1.Text) Then
                    listOfErrors = listOfErrors & "     First text box is using letters" & vbCrLf
                End If

                If Not IsNumeric(TextBox2.Text) Then
                    listOfErrors = listOfErrors & "     Second text box is using letters" & vbCrLf
                End If

            ElseIf Integer.Parse(TextBox1.Text) < 0 Or Integer.Parse(TextBox2.Text) < 0 Then
                listOfErrors = listOfErrors & "No text box should be lesser than zero or negative values" & vbCrLf
                If Integer.Parse(TextBox1.Text) < 0 Then
                    listOfErrors = listOfErrors & "     First text box should be greater than zero" & vbCrLf
                End If
                If Integer.Parse(TextBox2.Text) < 0 Then
                    listOfErrors = listOfErrors & "     Second text box should be greater than zero" & vbCrLf
                End If

            ElseIf Integer.Parse(TextBox1.Text) > 1000 Or Integer.Parse(TextBox2.Text) > 1000 Then
                listOfErrors = listOfErrors & "No text box should be greater than 1000" & vbCrLf
                If Integer.Parse(TextBox1.Text) > 1000 Then
                    listOfErrors = listOfErrors & "     First text box is more than 1000" & vbCrLf
                End If
                If Integer.Parse(TextBox2.Text) > 1000 Then
                    listOfErrors = listOfErrors & "     Second text box is more than 1000" & vbCrLf
                End If

            ElseIf Integer.Parse(TextBox1.Text) Mod 1 <> 0 Or Integer.Parse(TextBox2.Text) Mod 1 <> 0 Then
                listOfErrors = listOfErrors & "No text box should be in decimal value" & vbCrLf
                If Integer.Parse(TextBox1.Text) Mod 1 <> 0 Then
                    listOfErrors = listOfErrors & "      First text box is using decimal value" & vbCrLf
                End If
                If Integer.Parse(TextBox2.Text) Mod 1 <> 0 Then
                    listOfErrors = listOfErrors & "      Second text box is using decimal value" & vbCrLf
                End If

            ElseIf Integer.Parse(TextBox1.Text) > Integer.Parse(TextBox2.Text) Then
                listOfErrors = listOfErrors & "First Text Box Should be Lesser Than the Second Text Box" & vbCrLf
            Else
                errorFound = False
            End If

            exitLoop = True

        End While

        If errorFound = False Then
            endNumber = Integer.Parse(TextBox2.Text)

            For startNumber = Integer.Parse(TextBox1.Text) To endNumber
                finalAnswer = finalAnswer + startNumber
            Next startNumber

            TextBox3.Text = finalAnswer

        ElseIf errorFound = True Then
            MessageBox.Show(listOfErrors, "ERRORS")
        End If

        startNumber = 0
        endNumber = 0
        finalAnswer = 0
    End Sub

End Class
