Public Class Admissions
   

    Private Sub Admissions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.AdmissionsTableAdapter.Fill(Me.HospitalDataSet.admissions)

    End Sub

    Private Sub CloudButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton1.Click


        Dim leng As TimeSpan
        Dim newadmission As HospitalDataSet.admissionsRow


        Try
            newadmission = HospitalDataSet.admissions.NewadmissionsRow

            newadmission.unitno = unitnobox.Text
            newadmission.surname = surnamebox.Text
            newadmission.firstname = firstnamebox.Text
            newadmission.admissiondate = admissiondatebox.Text
            newadmission.dischargedate = ""

            'legthofstay converted to Healthstate

            '

            Me.HospitalDataSet.admissions.AddadmissionsRow(newadmission)
            Me.AdmissionsTableAdapter.Update(Me.HospitalDataSet.admissions)
            MsgBox("Patient Admitted Successfully")
        Catch ex As Exception
            MsgBox("Error! Please Confirm Entry and try again", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub CloudButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton2.Click
        Me.Close()

    End Sub

    Private Sub unitnobox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unitnobox.TextChanged

    End Sub
End Class