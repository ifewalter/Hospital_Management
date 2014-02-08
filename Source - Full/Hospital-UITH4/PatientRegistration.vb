Public Class PatientRegistration

    Private Sub PatientRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.PatientRegistration' table. You can move, or remove it, as needed.
        Me.PatientRegistrationTableAdapter.Fill(Me.HospitalDataSet.PatientRegistration)

    End Sub


    Private Sub PatientRegistrationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PatientRegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HospitalDataSet)


    End Sub

    Private Sub PatientRegistrationBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub CloudButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton2.Click
        Me.Close()

    End Sub

    Private Sub CloudButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloudButton1.Click
        Dim patcount As Integer

        patcount = PatientRegistrationTableAdapter.ScalarQuery(unitnobox.Text)

        If patcount < 1 Then

            Try
                Dim newpatient As HospitalDataSet.PatientRegistrationRow
                newpatient = HospitalDataSet.PatientRegistration.NewPatientRegistrationRow


                newpatient.unitno = unitnobox.Text
                newpatient.surname = surnamebox.Text
                newpatient.firstname = firstnamebox.Text
                newpatient.dob = dobbox.Text
                newpatient.sex = sexbox.Text
                newpatient.age = agebox.Value
                newpatient.ethnicity = ethnicitybox.Text
                newpatient.occupation = occupationbox.Text
                newpatient.address = address1boc.Text
                newpatient.address = address2box.Text


                Me.HospitalDataSet.PatientRegistration.AddPatientRegistrationRow(newpatient)
                Me.PatientRegistrationTableAdapter.Update(Me.HospitalDataSet.PatientRegistration)
                MsgBox("New Patient Registered Successfully", MsgBoxStyle.Information)
                Me.Close()


            Catch ex As Exception

            End Try

        Else

            MsgBox("Unit Number already exists. Please Check the Unit Number", MsgBoxStyle.Exclamation)

        End If


        
    End Sub
End Class