Public Class Show_Appointments

    Private Sub AppointmentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AppointmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalDataSet)

    End Sub

    Private Sub Show_Appointments_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Show_Appointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.HospitalDataSet.appointments)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        appointmentviewer.Show()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            AppointmentsTableAdapter.DeleteQuery(AppointmentsDataGridView.CurrentRow.Cells(0).Value.ToString)
            MsgBox("Delete Successfull")
        Catch ex As Exception
            MsgBox("Delete Error")
        End Try


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Me.AppointmentsTableAdapter.FillBy(HospitalDataSet.appointments, ToolStripTextBox1.Text)

        Catch ex As Exception

        End Try
    End Sub
End Class