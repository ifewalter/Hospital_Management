<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.unitnobox = New System.Windows.Forms.TextBox
        Me.surnamebox = New System.Windows.Forms.TextBox
        Me.firstnamebox = New System.Windows.Forms.TextBox
        Me.whomtoseebox = New System.Windows.Forms.TextBox
        Me.deptbox = New System.Windows.Forms.TextBox
        Me.monthsbox = New System.Windows.Forms.NumericUpDown
        Me.weeksbox = New System.Windows.Forms.NumericUpDown
        Me.daysbox = New System.Windows.Forms.NumericUpDown
        Me.quit = New System.Windows.Forms.Button
        Me.savebutton = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_UITH.HospitalDataSet
        Me.AppointmentsTableAdapter = New Hospital_UITH.HospitalDataSetTableAdapters.appointmentsTableAdapter
        CType(Me.monthsbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weeksbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daysbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unit Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Weeks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(303, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Months"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Whom to see"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Department"
        '
        'unitnobox
        '
        Me.unitnobox.Location = New System.Drawing.Point(104, 26)
        Me.unitnobox.Name = "unitnobox"
        Me.unitnobox.Size = New System.Drawing.Size(241, 20)
        Me.unitnobox.TabIndex = 9
        '
        'surnamebox
        '
        Me.surnamebox.Location = New System.Drawing.Point(104, 75)
        Me.surnamebox.Name = "surnamebox"
        Me.surnamebox.Size = New System.Drawing.Size(241, 20)
        Me.surnamebox.TabIndex = 10
        '
        'firstnamebox
        '
        Me.firstnamebox.Location = New System.Drawing.Point(104, 121)
        Me.firstnamebox.Name = "firstnamebox"
        Me.firstnamebox.Size = New System.Drawing.Size(241, 20)
        Me.firstnamebox.TabIndex = 11
        '
        'whomtoseebox
        '
        Me.whomtoseebox.Location = New System.Drawing.Point(104, 261)
        Me.whomtoseebox.Name = "whomtoseebox"
        Me.whomtoseebox.Size = New System.Drawing.Size(241, 20)
        Me.whomtoseebox.TabIndex = 13
        '
        'deptbox
        '
        Me.deptbox.Location = New System.Drawing.Point(104, 305)
        Me.deptbox.Name = "deptbox"
        Me.deptbox.Size = New System.Drawing.Size(241, 20)
        Me.deptbox.TabIndex = 14
        '
        'monthsbox
        '
        Me.monthsbox.Location = New System.Drawing.Point(238, 216)
        Me.monthsbox.Name = "monthsbox"
        Me.monthsbox.Size = New System.Drawing.Size(59, 20)
        Me.monthsbox.TabIndex = 15
        '
        'weeksbox
        '
        Me.weeksbox.Location = New System.Drawing.Point(126, 215)
        Me.weeksbox.Name = "weeksbox"
        Me.weeksbox.Size = New System.Drawing.Size(59, 20)
        Me.weeksbox.TabIndex = 16
        '
        'daysbox
        '
        Me.daysbox.Location = New System.Drawing.Point(26, 215)
        Me.daysbox.Name = "daysbox"
        Me.daysbox.Size = New System.Drawing.Size(54, 20)
        Me.daysbox.TabIndex = 17
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(270, 356)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(75, 23)
        Me.quit.TabIndex = 19
        Me.quit.Text = "Close"
        Me.quit.UseVisualStyleBackColor = True
        '
        'savebutton
        '
        Me.savebutton.Location = New System.Drawing.Point(104, 356)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(75, 23)
        Me.savebutton.TabIndex = 18
        Me.savebutton.Text = "Save"
        Me.savebutton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Start Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(104, 166)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "appointments"
        Me.AppointmentBindingSource.DataSource = Me.HospitalDataSet
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'Appointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(374, 391)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.daysbox)
        Me.Controls.Add(Me.weeksbox)
        Me.Controls.Add(Me.monthsbox)
        Me.Controls.Add(Me.deptbox)
        Me.Controls.Add(Me.whomtoseebox)
        Me.Controls.Add(Me.firstnamebox)
        Me.Controls.Add(Me.surnamebox)
        Me.Controls.Add(Me.unitnobox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(382, 425)
        Me.MinimumSize = New System.Drawing.Size(382, 425)
        Me.Name = "Appointments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointments"
        Me.TopMost = True
        CType(Me.monthsbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weeksbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daysbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents unitnobox As System.Windows.Forms.TextBox
    Friend WithEvents surnamebox As System.Windows.Forms.TextBox
    Friend WithEvents firstnamebox As System.Windows.Forms.TextBox
    Friend WithEvents whomtoseebox As System.Windows.Forms.TextBox
    Friend WithEvents deptbox As System.Windows.Forms.TextBox
    Friend WithEvents monthsbox As System.Windows.Forms.NumericUpDown
    Friend WithEvents weeksbox As System.Windows.Forms.NumericUpDown
    Friend WithEvents daysbox As System.Windows.Forms.NumericUpDown
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents AppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HospitalDataSet As Hospital_UITH.HospitalDataSet
    Friend WithEvents AppointmentsTableAdapter As Hospital_UITH.HospitalDataSetTableAdapters.appointmentsTableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
