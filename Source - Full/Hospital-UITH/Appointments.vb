Public Class Appointments

    Private Sub quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.Click
        Me.Close()
    End Sub

    Private Sub savebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebutton.Click

        'using the try statement so that we can catch exception throw from executing the following
        'instructions to add a new row to the appointment table in the hospital database

        Try

            Dim newappointment As HospitalDataSet.appointmentsRow
            newappointment = HospitalDataSet.appointments.NewappointmentsRow

            newappointment.unitno = unitnobox.Text
            newappointment.surname = surnamebox.Text
            newappointment.firstname = firstnamebox.Text


            newappointment.days = daysbox.Value
            newappointment.months = monthsbox.Value
            newappointment.weeks = weeksbox.Value
            newappointment.startdate = DateTimePicker1.Text


            newappointment.whomtosee = whomtoseebox.Text
            newappointment.dept = deptbox.Text

            Me.HospitalDataSet.appointments.AddappointmentsRow(newappointment)
            Me.AppointmentsTableAdapter.Update(Me.HospitalDataSet.appointments)
            MsgBox("Appointment Scheduled Successfully", MsgBoxStyle.Information)


        Catch ex As Exception
            MsgBox("Error! Please confirm entry and try again", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Appointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'HospitalDataSet.appointments' table.
        Me.AppointmentsTableAdapter.Fill(Me.HospitalDataSet.appointments)

    End Sub
End Class