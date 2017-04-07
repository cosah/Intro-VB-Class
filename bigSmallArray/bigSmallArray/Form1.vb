Public Class frmLargeSmall
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim intTimes As Integer
        Dim arrValues(9) As Integer
        lstValues.Items.Clear()
        lblMinMax.Text = ""
        For intTimes = 0 To 9
            Dim strTitle = "Input #" + (intTimes + 1).ToString()
            arrValues(intTimes) = InputBox("Input Integer", strTitle)
            lstValues.Items.Add(arrValues(intTimes))
        Next
        Array.Sort(arrValues)
        lstValues.Items.Clear()
        For Each intValue As Integer In arrValues
            lstValues.Items.Add(intValue)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstValues.Items.Clear()
        lblMinMax.Text = ""
    End Sub

    Private Sub btnMinMax_Click(sender As Object, e As EventArgs) Handles btnMinMax.Click
        lblMinMax.Text = "Max: " + lstValues.Items.Item(9).ToString() + ", Min: " + lstValues.Items.Item(0).ToString()
    End Sub
End Class
