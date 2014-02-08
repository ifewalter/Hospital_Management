Public Class RegisteredPatients

    Private Sub RegisteredPatients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.PatientRegistration' table. You can move, or remove it, as needed.
        Me.PatientRegistrationTableAdapter.Fill(Me.HospitalDataSet.PatientRegistration)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        PatientsViewer.Show()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        PatientRegistrationTableAdapter.DeleteQuery(PatientRegistrationDataGridView.CurrentRow.Cells(0).Value.ToString)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Me.PatientRegistrationTableAdapter.FillByunitno(HospitalDataSet.PatientRegistration, ToolStripTextBox1.Text)
        Catch ex As Exception

        End Try

    End Sub
End Class