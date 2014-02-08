Public Class Home

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        PatientRegistration.Show()

    End Sub

    Private Sub LinkLabel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel2.Click
        RegisteredPatients.Show()

    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Appointments.Show()

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Show_Appointments.Show()


    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        howdiagnosis.Show()

    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Diagnosis.Show()

    End Sub

    Private Sub Home_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UploadToDatabankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadToDatabankToolStripMenuItem.Click

        SaveFileDialog1.Title = "Save Database to databank"

        SaveFileDialog1.DefaultExt = "*.mdf"
        SaveFileDialog1.FileName = "Hospital.mdf"
        SaveFileDialog1.ShowDialog()



    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim savedbpath As String
        savedbpath = SaveFileDialog1.FileName
        Dim opendbpath As String = Application.StartupPath.ToString & "\Hospital.mdf"
        Try
            IO.File.Copy(opendbpath, savedbpath, False)
            MsgBox("Database saved successfully")
        Catch ex As AccessViolationException
            MsgBox("Make sure you have permission to access the selected directory")
        Catch ex2 As Exception
            MsgBox("File name already exists")
        End Try
    End Sub
    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Admissions.Show()

    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        DischargeForm.Show()
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        showadmissions.Show()
    End Sub

    Private Sub ResetDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetDatabaseToolStripMenuItem.Click
        Try
            MsgBox("All existing data will be erased", MsgBoxStyle.Information = MsgBoxStyle.OkCancel, "Reset program")

            IO.File.Copy(Application.StartupPath & " \backup\Hospital.mdf", Application.StartupPath & " \Hospital.mdf", True)
            MsgBox("Reset Successfull")
        Catch ex2 As AccessViolationException
            MsgBox("Access Permission error. Please run the program with admin rights")
        Catch ex As Exception
            MsgBox(ex)

        End Try
        
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        visits.Show()
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click
        MsgBox("please load existing database file named 'Hospital.mdf'")

        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog1.Filter = "Hospital DB(Hospital.mdf)|Hospital.mdf "

        OpenFileDialog1.FileName = "Hospital.mdf"
        OpenFileDialog1.ShowDialog()


    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            IO.File.Copy(OpenFileDialog1.FileName.ToString, Application.StartupPath & "\Hospital.mdf", True)
            MsgBox("Database Successfully loaded", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex)

        End Try
    End Sub
End Class