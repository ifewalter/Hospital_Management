Public Class showadmissions

    Private Sub AdmissionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.AdmissionsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.HospitalDataSet)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub showadmissions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.admissions' table. You can move, or remove it, as needed.
        Me.AdmissionsTableAdapter.Fill(Me.HospitalDataSet.admissions)


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
450:

        DischargeForm.unitno = AdmissionsDataGridView.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub AdmissionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AdmissionsDataGridView.CellContentClick

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            AdmissionsTableAdapter.DeleteQuery(AdmissionsDataGridView.CurrentRow.Cells(0).Value.ToString)
            MsgBox("Delete Successfull")
        Catch ex As Exception
            MsgBox("Delete Error. Please select a record")
        End Try


    End Sub
End Class