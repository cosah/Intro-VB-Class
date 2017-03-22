Public Class frmGradeReport
    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        For intCount = 0 To 2
            Dim strStudent As String = String.Empty
            strStudent = CStr(InputBox("Enter the name of student number " & intCount + 1, "Student Name"))
            If strStudent = "" Then
                Exit Sub
            End If
            Dim intAvg As Integer = 0
            For intCount2 = 0 To 2
                Dim intScore As Integer = -1
                Dim strScore As String
                Do
                    Try
                        strScore = InputBox("Enter a score between 0 and 110", "Test Score Number " & intCount2 + 1)
                        If strScore <> "" Then
                            intScore = CInt(strScore)
                        Else
                            Exit Sub
                        End If
                    Catch
                    End Try
                Loop While intScore < 0 Or intScore > 110
                intAvg += intScore
            Next
            intAvg /= 3
            Dim strGrade As String = " "
            Select Case intAvg
                Case >= 90
                    strGrade = "A"
                Case >= 80
                    strGrade = "B"
                Case >= 70
                    strGrade = "C"
                Case >= 60
                    strGrade = "D"
                Case Else
                    strGrade = "F"
            End Select
            lstGrades.Items.Add(strStudent & ", Average: " & intAvg & ", Grade: " & strGrade)
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
