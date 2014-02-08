Public Class howdiagnosis

    Private Sub DiagnosisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DiagnosisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalDataSet)

    End Sub

    Private Sub howdiagnosis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.diagnosis' table. You can move, or remove it, as needed.
        Me.DiagnosisTableAdapter.Fill(Me.HospitalDataSet.diagnosis)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            DiagnosisTableAdapter.DeleteQuery(DiagnosisDataGridView.CurrentRow.Cells(0).Value.ToString)
            MsgBox("Delete Successfull")
        Catch ex As Exception
            MsgBox("Delete Unsuccessfull. Please select a row and try again")
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Me.DiagnosisTableAdapter.FillBydcu(HospitalDataSet.diagnosis, ToolStripTextBox2.Text, ToolStripTextBox2.Text, ToolStripTextBox2.Text)
        Catch ex As Exception

        End Try

    End Sub
End Class