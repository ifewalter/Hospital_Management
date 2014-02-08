Public Class visits

    Private Sub CloudButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton2.Click
        Me.Close()

    End Sub

    Private Sub CloudButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton1.Click

        Dim patcount As Integer
        patcount = PatientRegistrationTableAdapter.ScalarQuery(TextBox1.Text)

        If patcount < 1 Then
            MsgBox("Invalid Unit Number", MsgBoxStyle.Critical)

        Else
            Dim newvisit As HospitalDataSet.visitsRow
            newvisit = HospitalDataSet.visits.NewRow

            newvisit.unitno = TextBox1.Text
            newvisit.firstname = TextBox2.Text
            newvisit.lastname = TextBox3.Text
            newvisit.visitdate = DateTimePicker1.Text

            Me.HospitalDataSet.visits.AddvisitsRow(newvisit)
            Me.VisitsTableAdapter.Update(HospitalDataSet.visits)
            MsgBox("Visit Log Complete.", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub visits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.PatientRegistration' table. You can move, or remove it, as needed.
        Me.PatientRegistrationTableAdapter.Fill(Me.HospitalDataSet.PatientRegistration)
        'TODO: This line of code loads data into the 'HospitalDataSet.visits' table. You can move, or remove it, as needed.
        Me.VisitsTableAdapter.Fill(Me.HospitalDataSet.visits)

    End Sub
End Class