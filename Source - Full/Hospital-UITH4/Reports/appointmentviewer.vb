Public Class appointmentviewer

    Private Sub appointmentviewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.appointments' table. You can move, or remove it, as needed.
        Me.appointmentsTableAdapter.Fill(Me.HospitalDataSet.appointments)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class