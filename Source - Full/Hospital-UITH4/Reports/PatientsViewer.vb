Public Class PatientsViewer

    Private Sub PatientsViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.PatientRegistration' table. You can move, or remove it, as needed.
        Me.PatientRegistrationTableAdapter.Fill(Me.HospitalDataSet.PatientRegistration)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class