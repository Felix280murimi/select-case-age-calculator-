Public Class Form1
    Private Sub btnAgeSet_Click(sender As Object, e As EventArgs) Handles btnAgeSet.Click
        Dim years As Integer
        Dim jinalako As String
        jinalako = InputBox("Enter your name please")
        years = Val(InputBox(jinalako & " How old are you?"))
        Select Case (years)
            Case 0 To 3
                MessageBox.Show(jinalako & " you are a toddler")
            Case 4 To 10
                MessageBox.Show(jinalako & " you are a young child")
            Case 11 To 19
                MessageBox.Show(jinalako & " you are a tenager youth")
            Case 20 To 30
                MessageBox.Show(jinalako & " you are a X tenager youth")
            Case Is > 30
                MessageBox.Show(jinalako & " You are an Adult")

        End Select
    End Sub
End Class
