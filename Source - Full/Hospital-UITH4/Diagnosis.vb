Public Class Diagnosis

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codenobox.TextChanged

    End Sub

    Private Sub Diagnosis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.diagnosis' table. You can move, or remove it, as needed.
        Me.DiagnosisTableAdapter.Fill(Me.HospitalDataSet.diagnosis)

    End Sub

    Private Sub CloudButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton2.Click
        Me.Close()

    End Sub

    Private Sub CloudButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloudButton1.Click
        Try
            Dim newdiag As HospitalDataSet.diagnosisRow
            newdiag = HospitalDataSet.diagnosis.NewdiagnosisRow

            newdiag.diagnosis = diagnosisbox.Text
            newdiag.codeno = codenobox.Text
            newdiag.unitno = unitnobox.Text
            newdiag.sex = sexbox.Text
            newdiag.age = agebox.Value
            newdiag.dateofadmission = doabox.Text
            newdiag.dateofdischarge = dodbox.Text
            newdiag.lengthofstay = losbox.Value
            newdiag.healthstate = healthstatebox.Text
            newdiag.operationcode = operationcodebox.Text
            newdiag.consultant = consultantbox.Text

            Me.HospitalDataSet.diagnosis.AdddiagnosisRow(newdiag)
            Me.DiagnosisTableAdapter.Update(Me.HospitalDataSet.diagnosis)
            MsgBox("Diagnosis Saved Successfully", MsgBoxStyle.Information)


        Catch ex As Exception
            MsgBox("ERROR! Please verify entered data and try again.", MsgBoxStyle.Critical)
        End Try

    End Sub
End Class