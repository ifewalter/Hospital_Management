<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diagnosis
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
        Me.diagnosisbox = New System.Windows.Forms.TextBox
        Me.codenobox = New System.Windows.Forms.TextBox
        Me.unitnobox = New System.Windows.Forms.TextBox
        Me.healthstatebox = New System.Windows.Forms.TextBox
        Me.sexbox = New System.Windows.Forms.ComboBox
        Me.agebox = New System.Windows.Forms.NumericUpDown
        Me.doabox = New System.Windows.Forms.DateTimePicker
        Me.dodbox = New System.Windows.Forms.DateTimePicker
        Me.losbox = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.operationcodebox = New System.Windows.Forms.TextBox
        Me.consultantbox = New System.Windows.Forms.TextBox
        Me.CloudButton1 = New CloudToolkitN6.CloudButton
        Me.CloudButton2 = New CloudToolkitN6.CloudButton
        Me.DiagnosticBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_UITH.HospitalDataSet
        Me.DiagnosisTableAdapter = New Hospital_UITH.HospitalDataSetTableAdapters.diagnosisTableAdapter
        CType(Me.agebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.losbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiagnosticBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diagnosis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date of Admission"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date of Discharge"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Length of Stay"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Health State"
        '
        'diagnosisbox
        '
        Me.diagnosisbox.Location = New System.Drawing.Point(128, 12)
        Me.diagnosisbox.Name = "diagnosisbox"
        Me.diagnosisbox.Size = New System.Drawing.Size(239, 20)
        Me.diagnosisbox.TabIndex = 16
        '
        'codenobox
        '
        Me.codenobox.Location = New System.Drawing.Point(128, 38)
        Me.codenobox.Name = "codenobox"
        Me.codenobox.Size = New System.Drawing.Size(239, 20)
        Me.codenobox.TabIndex = 17
        '
        'unitnobox
        '
        Me.unitnobox.Location = New System.Drawing.Point(128, 67)
        Me.unitnobox.Name = "unitnobox"
        Me.unitnobox.Size = New System.Drawing.Size(239, 20)
        Me.unitnobox.TabIndex = 18
        '
        'healthstatebox
        '
        Me.healthstatebox.Location = New System.Drawing.Point(127, 234)
        Me.healthstatebox.Name = "healthstatebox"
        Me.healthstatebox.Size = New System.Drawing.Size(239, 20)
        Me.healthstatebox.TabIndex = 19
        '
        'sexbox
        '
        Me.sexbox.FormattingEnabled = True
        Me.sexbox.Items.AddRange(New Object() {"Male", "Female"})
        Me.sexbox.Location = New System.Drawing.Point(127, 93)
        Me.sexbox.Name = "sexbox"
        Me.sexbox.Size = New System.Drawing.Size(121, 21)
        Me.sexbox.TabIndex = 20
        '
        'agebox
        '
        Me.agebox.Location = New System.Drawing.Point(127, 120)
        Me.agebox.Name = "agebox"
        Me.agebox.Size = New System.Drawing.Size(120, 20)
        Me.agebox.TabIndex = 21
        '
        'doabox
        '
        Me.doabox.Location = New System.Drawing.Point(128, 146)
        Me.doabox.Name = "doabox"
        Me.doabox.Size = New System.Drawing.Size(239, 20)
        Me.doabox.TabIndex = 22
        '
        'dodbox
        '
        Me.dodbox.Location = New System.Drawing.Point(128, 172)
        Me.dodbox.Name = "dodbox"
        Me.dodbox.Size = New System.Drawing.Size(239, 20)
        Me.dodbox.TabIndex = 23
        '
        'losbox
        '
        Me.losbox.Location = New System.Drawing.Point(128, 203)
        Me.losbox.Name = "losbox"
        Me.losbox.Size = New System.Drawing.Size(120, 20)
        Me.losbox.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(254, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Days"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Operation Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 305)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Consultant"
        '
        'operationcodebox
        '
        Me.operationcodebox.Location = New System.Drawing.Point(127, 266)
        Me.operationcodebox.Name = "operationcodebox"
        Me.operationcodebox.Size = New System.Drawing.Size(240, 20)
        Me.operationcodebox.TabIndex = 29
        '
        'consultantbox
        '
        Me.consultantbox.Location = New System.Drawing.Point(127, 302)
        Me.consultantbox.Name = "consultantbox"
        Me.consultantbox.Size = New System.Drawing.Size(240, 20)
        Me.consultantbox.TabIndex = 31
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
        Me.CloudButton1.Location = New System.Drawing.Point(128, 345)
        Me.CloudButton1.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CloudButton1.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CloudButton1.Name = "CloudButton1"
        Me.CloudButton1.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CloudButton1.Size = New System.Drawing.Size(63, 20)
        Me.CloudButton1.TabIndex = 32
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
        Me.CloudButton2.Location = New System.Drawing.Point(304, 345)
        Me.CloudButton2.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CloudButton2.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CloudButton2.Name = "CloudButton2"
        Me.CloudButton2.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CloudButton2.Size = New System.Drawing.Size(63, 20)
        Me.CloudButton2.TabIndex = 33
        Me.CloudButton2.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.CloudButton2.TextSpacingX = 5
        Me.CloudButton2.TextSpacingY = 5
        '
        'DiagnosticBindingSource1
        '
        Me.DiagnosticBindingSource1.DataMember = "diagnosis"
        Me.DiagnosticBindingSource1.DataSource = Me.HospitalDataSet
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiagnosisTableAdapter
        '
        Me.DiagnosisTableAdapter.ClearBeforeFill = True
        '
        'Diagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(385, 377)
        Me.Controls.Add(Me.CloudButton2)
        Me.Controls.Add(Me.CloudButton1)
        Me.Controls.Add(Me.consultantbox)
        Me.Controls.Add(Me.operationcodebox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.losbox)
        Me.Controls.Add(Me.dodbox)
        Me.Controls.Add(Me.doabox)
        Me.Controls.Add(Me.agebox)
        Me.Controls.Add(Me.sexbox)
        Me.Controls.Add(Me.healthstatebox)
        Me.Controls.Add(Me.unitnobox)
        Me.Controls.Add(Me.codenobox)
        Me.Controls.Add(Me.diagnosisbox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(393, 411)
        Me.MinimumSize = New System.Drawing.Size(393, 411)
        Me.Name = "Diagnosis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diagnosis"
        Me.TopMost = True
        CType(Me.agebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.losbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiagnosticBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents diagnosisbox As System.Windows.Forms.TextBox
    Friend WithEvents codenobox As System.Windows.Forms.TextBox
    Friend WithEvents unitnobox As System.Windows.Forms.TextBox
    Friend WithEvents healthstatebox As System.Windows.Forms.TextBox
    Friend WithEvents sexbox As System.Windows.Forms.ComboBox
    Friend WithEvents agebox As System.Windows.Forms.NumericUpDown
    Friend WithEvents doabox As System.Windows.Forms.DateTimePicker
    Friend WithEvents dodbox As System.Windows.Forms.DateTimePicker
    Friend WithEvents losbox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents operationcodebox As System.Windows.Forms.TextBox
    Friend WithEvents consultantbox As System.Windows.Forms.TextBox
    Friend WithEvents DiagnosticBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HospitalDataSet As Hospital_UITH.HospitalDataSet
    Friend WithEvents DiagnosisTableAdapter As Hospital_UITH.HospitalDataSetTableAdapters.diagnosisTableAdapter
    Friend WithEvents CloudButton1 As CloudToolkitN6.CloudButton
    Friend WithEvents CloudButton2 As CloudToolkitN6.CloudButton
End Class
