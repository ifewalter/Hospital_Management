<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visits
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.CloudButton2 = New CloudToolkitN6.CloudButton
        Me.CloudButton1 = New CloudToolkitN6.CloudButton
        Me.patregBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.visitsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalDataSet = New Hospital_UITH.HospitalDataSet
        Me.VisitsTableAdapter = New Hospital_UITH.HospitalDataSetTableAdapters.visitsTableAdapter
        Me.PatientRegistrationTableAdapter = New Hospital_UITH.HospitalDataSetTableAdapters.PatientRegistrationTableAdapter
        CType(Me.patregBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visitsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unit Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(199, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(101, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(199, 20)
        Me.TextBox3.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 150)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker1.TabIndex = 7
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
        Me.CloudButton2.Location = New System.Drawing.Point(238, 205)
        Me.CloudButton2.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CloudButton2.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CloudButton2.Name = "CloudButton2"
        Me.CloudButton2.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CloudButton2.Size = New System.Drawing.Size(62, 20)
        Me.CloudButton2.TabIndex = 10
        Me.CloudButton2.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.CloudButton2.TextSpacingX = 5
        Me.CloudButton2.TextSpacingY = 5
        '
        'CloudButton1
        '
        Me.CloudButton1.BackColor = System.Drawing.Color.Transparent
        Me.CloudButton1.ButtonText = "OK"
        Me.CloudButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloudButton1.DisabledColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer))}
        Me.CloudButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CloudButton1.Icon = Nothing
        Me.CloudButton1.IconAlign = CloudToolkitN6.CloudButton.IconBitmapAlign.Left
        Me.CloudButton1.IconSpacingX = 5
        Me.CloudButton1.IconSpacingY = 5
        Me.CloudButton1.IconTransparency = 0.0!
        Me.CloudButton1.Location = New System.Drawing.Point(101, 205)
        Me.CloudButton1.MouseDown_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(135, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(171, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(167, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(205, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(112, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(49, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(132, Byte), Integer))}
        Me.CloudButton1.MouseOn_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(113, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(182, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(133, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(77, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(151, Byte), Integer))}
        Me.CloudButton1.Name = "CloudButton1"
        Me.CloudButton1.Normal_Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(207, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(212, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(221, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(244, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))}
        Me.CloudButton1.Size = New System.Drawing.Size(62, 20)
        Me.CloudButton1.TabIndex = 11
        Me.CloudButton1.TextImageRelation = CloudToolkitN6.CloudButton.ButtonTextImageRelation.TextAboveImage
        Me.CloudButton1.TextSpacingX = 5
        Me.CloudButton1.TextSpacingY = 5
        '
        'patregBindingSource1
        '
        Me.patregBindingSource1.DataMember = "PatientRegistration"
        Me.patregBindingSource1.DataSource = Me.HospitalDataSet
        '
        'visitsBindingSource1
        '
        Me.visitsBindingSource1.DataMember = "visits"
        Me.visitsBindingSource1.DataSource = Me.HospitalDataSet
        '
        'HospitalDataSet
        '
        Me.HospitalDataSet.DataSetName = "HospitalDataSet"
        Me.HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitsTableAdapter
        '
        Me.VisitsTableAdapter.ClearBeforeFill = True
        '
        'PatientRegistrationTableAdapter
        '
        Me.PatientRegistrationTableAdapter.ClearBeforeFill = True
        '
        'visits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(329, 248)
        Me.Controls.Add(Me.CloudButton1)
        Me.Controls.Add(Me.CloudButton2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "visits"
        Me.Text = "Visits"
        Me.TopMost = True
        CType(Me.patregBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visitsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CloudButton2 As CloudToolkitN6.CloudButton
    Friend WithEvents CloudButton1 As CloudToolkitN6.CloudButton
    Friend WithEvents patregBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents visitsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HospitalDataSet As Hospital_UITH.HospitalDataSet
    Friend WithEvents VisitsTableAdapter As Hospital_UITH.HospitalDataSetTableAdapters.visitsTableAdapter
    Friend WithEvents PatientRegistrationTableAdapter As Hospital_UITH.HospitalDataSetTableAdapters.PatientRegistrationTableAdapter
End Class
