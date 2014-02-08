Public Class DischargeForm

    Public unitno, dischargedate, healthstate As String

   
    Private Sub DischargeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.admissions' table. You can move, or remove it, as needed.
        Me.AdmissionsTableAdapter.Fill(Me.HospitalDataSet.admissions)
        TextBox1.Enabled = False

    End Sub


    Private Sub CloudButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton2.Click
        Me.Close()

    End Sub

    Private Sub CloudButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton1.Click
        Try

            AdmissionsTableAdapter.UpdateQuery(DateTimePicker1.Text, TextBox2.Text, TextBox1.Text)
            AdmissionsTableAdapter.Update(HospitalDataSet.admissions)
            MsgBox("Patient Discharged", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Please Make Sure the Case Number is correct, then try again", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class