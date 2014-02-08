<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRegistration
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.unitnobox = New System.Windows.Forms.TextBox
        Me.surnamebox = New System.Windows.Forms.TextBox
        Me.firstnamebox = New System.Windows.Forms.TextBox
        Me.ethnicitybox = New System.Windows.Forms.TextBox
        Me.occupationbox = New System.Windows.Forms.TextBox
        Me.address1boc = New System.Windows.Forms.TextBox
        Me.address2box = New System.Windows.Forms.TextBox
        Me.agebox = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.sexbox = New System.Windows.Forms.ComboBox
        Me.dobbox = New System.Windows.Forms.DateTimePicker
        Me.CloudButton1 = New CloudToolkitN6.CloudButton
        Me.CloudButton2 = New CloudToolkitN6.CloudButton
        Me.PatientRegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_UITH.HospitalDataSet
        Me.PatientRegistrationTableAdapter = New Hospital_UITH.HospitalDataSetTableAdapters.PatientRegistrationTableAdapter
        Me.TableAdapterManager = New Hospital_UITH.HospitalDataSetTableAdapters.TableAdapterManager
        CType(Me.agebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientRegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unit Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sex"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ethnicity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Occupation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 26)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Change " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Address"
        '
        'unitnobox
        '
        Me.unitnobox.Location = New System.Drawing.Point(101, 9)
        Me.unitnobox.Name = "unitnobox"
        Me.unitnobox.Size = New System.Drawing.Size(199, 20)
        Me.unitnobox.TabIndex = 10
        '
        'surnamebox
        '
        Me.surnamebox.Location = New System.Drawing.Point(101, 35)
        Me.surnamebox.Name = "surnamebox"
        Me.surnamebox.Size = New System.Drawing.Size(199, 20)
        Me.surnamebox.TabIndex = 11
        '
        'firstnamebox
        '
        Me.firstnamebox.Location = New System.Drawing.Point(101, 61)
        Me.firstnamebox.Name = "firstnamebox"
        Me.firstnamebox.Size = New System.Drawing.Size(199, 20)
        Me.firstnamebox.TabIndex = 12
        '
        'ethnicitybox
        '
        Me.ethnicitybox.Location = New System.Drawing.Point(100, 166)
        Me.ethnicitybox.Name = "ethnicitybox"
        Me.ethnicitybox.Size = New System.Drawing.Size(199, 20)
        Me.ethnicitybox.TabIndex = 13
        '
        'occupationbox
        '
        Me.occupationbox.Location = New System.Drawing.Point(101, 192)
        Me.occupationbox.Name = "occupationbox"
        Me.occupationbox.Size = New System.Drawing.Size(199, 20)
        Me.occupationbox.TabIndex = 14
        '
        'address1boc
        '
        Me.address1boc.Location = New System.Drawing.Point(101, 218)
        Me.address1boc.Multiline = True
        Me.address1boc.Name = "address1boc"
        Me.address1boc.Size = New System.Drawing.Size(223, 115)
        Me.address1boc.TabIndex = 15
        '
        'address2box
        '
        Me.address2box.Location = New System.Drawing.Point(100, 339)
        Me.address2box.Multiline = True
        Me.address2box.Name = "address2box"
        Me.address2box.Size = New System.Drawing.Size(223, 105)
        Me.address2box.TabIndex = 16
        '
        'agebox
        '
        Me.agebox.Location = New System.Drawing.Point(100, 140)
        Me.agebox.Name = "agebox"
        Me.agebox.Size = New System.Drawing.Size(109, 20)
        Me.agebox.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Years"
        '
        'sexbox
        '
        Me.sexbox.FormattingEnabled = True
        Me.sexbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexbox.Location = New System.Drawing.Point(100, 113)
        Me.sexbox.Name = "sexbox"
        Me.sexbox.Size = New System.Drawing.Size(199, 21)
        Me.sexbox.TabIndex = 19
        Me.sexbox.Text = "Male"
        '
        'dobbox
        '
        Me.dobbox.Location = New System.Drawing.Point(100, 87)
        Me.dobbox.Name = "dobbox"
        Me.dobbox.Size = New System.Drawing.Size(200, 20)
        Me.dobbox.TabIndex = 20
        '
        'CloudButton1
        '
        Me.CloudButton1.BackColor = System.Drawing.Color.Transparent
        Me.CloudButton1.ButtonText = "Save"
        Me.CloudButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudButton1.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CloudButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CloudButton1.Icon = Nothing
        Me.CloudButton1.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.CloudButton1.IconSpacingX = 5
        Me.CloudButton1.IconSpacingY = 5
        Me.CloudButton1.IconTransparency = 0.0!
        Me.CloudButton1.Location = New System.Drawing.Point(100, 467)
        Me.CloudButton1.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CloudButton1.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CloudButton1.Name = "CloudButton1"
        Me.CloudButton1.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CloudButton1.Size = New System.Drawing.Size(72, 25)
        Me.CloudButton1.TabIndex = 23
        Me.CloudButton1.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.CloudButton1.TextSpacingX = 5
        Me.CloudButton1.TextSpacingY = 5
        '
        'CloudButton2
        '
        Me.CloudButton2.BackColor = System.Drawing.Color.Transparent
        Me.CloudButton2.ButtonText = "Close"
        Me.CloudButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudButton2.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CloudButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CloudButton2.Icon = Nothing
        Me.CloudButton2.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.CloudButton2.IconSpacingX = 5
        Me.CloudButton2.IconSpacingY = 5
        Me.CloudButton2.IconTransparency = 0.0!
        Me.CloudButton2.Location = New System.Drawing.Point(251, 467)
        Me.CloudButton2.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CloudButton2.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CloudButton2.Name = "CloudButton2"
        Me.CloudButton2.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CloudButton2.Size = New System.Drawing.Size(72, 25)
        Me.CloudButton2.TabIndex = 24
        Me.CloudButton2.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.CloudButton2.TextSpacingX = 5
        Me.CloudButton2.TextSpacingY = 5
        '
        'PatientRegistrationBindingSource
        '
        Me.PatientRegistrationBindingSource.DataMember = "PatientRegistration"
        Me.PatientRegistrationBindingSource.DataSource = Me.HospitalDataSet
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientRegistrationTableAdapter
        '
        Me.PatientRegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.admissionsTableAdapter = Nothing
        Me.TableAdapterManager.appointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.diagnosisTableAdapter = Nothing
        Me.TableAdapterManager.PatientRegistrationTableAdapter = Me.PatientRegistrationTableAdapter
        Me.TableAdapterManager.UpdateOrder = Hospital_UITH.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.visitsTableAdapter = Nothing
        '
        'PatientRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(371, 504)
        Me.Controls.Add(Me.CloudButton2)
        Me.Controls.Add(Me.CloudButton1)
        Me.Controls.Add(Me.dobbox)
        Me.Controls.Add(Me.sexbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.agebox)
        Me.Controls.Add(Me.address2box)
        Me.Controls.Add(Me.address1boc)
        Me.Controls.Add(Me.occupationbox)
        Me.Controls.Add(Me.ethnicitybox)
        Me.Controls.Add(Me.firstnamebox)
        Me.Controls.Add(Me.surnamebox)
        Me.Controls.Add(Me.unitnobox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(379, 538)
        Me.MinimumSize = New System.Drawing.Size(379, 538)
        Me.Name = "PatientRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientRegistration"
        Me.TopMost = True
        CType(Me.agebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientRegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents unitnobox As System.Windows.Forms.TextBox
    Friend WithEvents surnamebox As System.Windows.Forms.TextBox
    Friend WithEvents firstnamebox As System.Windows.Forms.TextBox
    Friend WithEvents ethnicitybox As System.Windows.Forms.TextBox
    Friend WithEvents occupationbox As System.Windows.Forms.TextBox
    Friend WithEvents address1boc As System.Windows.Forms.TextBox
    Friend WithEvents address2box As System.Windows.Forms.TextBox
    Friend WithEvents agebox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sexbox As System.Windows.Forms.ComboBox
    Friend WithEvents dobbox As System.Windows.Forms.DateTimePicker
    Friend WithEvents HospitalDataSet As Hospital_UITH.HospitalDataSet
    Friend WithEvents PatientRegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientRegistrationTableAdapter As Hospital_UITH.HospitalDataSetTableAdapters.PatientRegistrationTableAdapter
    Friend WithEvents TableAdapterManager As Hospital_UITH.HospitalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CloudButton1 As CloudToolkitN6.CloudButton
    Friend WithEvents CloudButton2 As CloudToolkitN6.CloudButton
End Class
