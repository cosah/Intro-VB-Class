Public Class Form1
    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KarateDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.MembersTableAdapter.FillBy(Me.KarateDataSet.Members, New System.Nullable(Of Date)(CType(DateJoinedToolStripTextBox.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.MembersTableAdapter.FillBy(Me.KarateDataSet.Members, DateTimePicker1.Value)
    End Sub
End Class
