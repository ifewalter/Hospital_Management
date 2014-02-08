Public Class Diagnosisreport

    Private Sub Diagnosisreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.diagnosis' table. You can move, or remove it, as needed.
        Me.diagnosisTableAdapter.Fill(Me.HospitalDataSet.diagnosis)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class