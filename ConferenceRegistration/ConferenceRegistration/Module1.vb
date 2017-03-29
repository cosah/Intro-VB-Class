Module Module1

    Public Sub getTotal(ByVal boolDinner As Boolean, ByVal intSelect As Integer)
        Dim total As Integer = 895
        If boolDinner Then
            total += 30
        End If
        Select Case intSelect
            Case 0, 1
                total += 295
            Case 2, 3
                total += 395
        End Select
        frmConfReg.txtTotal.Text = total.ToString("c")
    End Sub

End Module
