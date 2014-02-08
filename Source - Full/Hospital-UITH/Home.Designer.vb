<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.CloudGroup1 = New CloudToolkitN6.CloudGroup
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel
        Me.CloudGroup2 = New CloudToolkitN6.CloudGroup
        Me.CloudGroup3 = New CloudToolkitN6.CloudGroup
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UploadToDatabankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.CloudGroup4 = New CloudToolkitN6.CloudGroup
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.CloudGroup1.SuspendLayout()
        Me.CloudGroup2.SuspendLayout()
        Me.CloudGroup3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.CloudGroup4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 653)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 24, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.StatusStrip1.Size = New System.Drawing.Size(1270, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 39)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(163, 17)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register New Patient"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel2.Location = New System.Drawing.Point(18, 73)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(194, 17)
        Me.LinkLabel2.TabIndex = 2
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Show Registered Patients"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel3.Location = New System.Drawing.Point(5, 41)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(170, 17)
        Me.LinkLabel3.TabIndex = 3
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Schedule Appointment"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel4.Location = New System.Drawing.Point(5, 77)
        Me.LinkLabel4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(151, 17)
        Me.LinkLabel4.TabIndex = 4
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Show Appointments"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel5.Location = New System.Drawing.Point(5, 50)
        Me.LinkLabel5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(169, 17)
        Me.LinkLabel5.TabIndex = 5
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Record New Diagnosis"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel6.Location = New System.Drawing.Point(5, 87)
        Me.LinkLabel6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(175, 17)
        Me.LinkLabel6.TabIndex = 6
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Show Disgnosis Record"
        '
        'CloudGroup1
        '
        Me.CloudGroup1.AnimationEnabled = True
        Me.CloudGroup1.AnimationSpeed = 4
        Me.CloudGroup1.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup1.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup1.BorderWidth = 1.0!
        Me.CloudGroup1.Controls.Add(Me.LinkLabel1)
        Me.CloudGroup1.Controls.Add(Me.LinkLabel9)
        Me.CloudGroup1.Controls.Add(Me.LinkLabel2)
        Me.CloudGroup1.FillColor1 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CloudGroup1.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CloudGroup1.FillColor2_2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup1.FontColorMouseOn = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloudGroup1.FontColorNormal = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.CloudGroup1.HeaderText = "GOPD"
        Me.CloudGroup1.Icon = Nothing
        Me.CloudGroup1.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudGroup1.IconPadding = 5
        Me.CloudGroup1.ImageHeader = False
        Me.CloudGroup1.IsOpen = True
        Me.CloudGroup1.Location = New System.Drawing.Point(53, 134)
        Me.CloudGroup1.MaximumHeight = 126
        Me.CloudGroup1.Name = "CloudGroup1"
        Me.CloudGroup1.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup1.Size = New System.Drawing.Size(329, 145)
        Me.CloudGroup1.TabIndex = 10
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Location = New System.Drawing.Point(18, 110)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(131, 17)
        Me.LinkLabel9.TabIndex = 3
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Log Patient Visit"
        '
        'CloudGroup2
        '
        Me.CloudGroup2.AnimationEnabled = True
        Me.CloudGroup2.AnimationSpeed = 4
        Me.CloudGroup2.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup2.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup2.BorderWidth = 1.0!
        Me.CloudGroup2.Controls.Add(Me.LinkLabel3)
        Me.CloudGroup2.Controls.Add(Me.LinkLabel4)
        Me.CloudGroup2.FillColor1 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CloudGroup2.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CloudGroup2.FillColor2_2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup2.FontColorMouseOn = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloudGroup2.FontColorNormal = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.CloudGroup2.HeaderText = "Appointments"
        Me.CloudGroup2.Icon = Nothing
        Me.CloudGroup2.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudGroup2.IconPadding = 5
        Me.CloudGroup2.ImageHeader = False
        Me.CloudGroup2.IsOpen = True
        Me.CloudGroup2.Location = New System.Drawing.Point(53, 339)
        Me.CloudGroup2.MaximumHeight = 129
        Me.CloudGroup2.Name = "CloudGroup2"
        Me.CloudGroup2.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup2.Size = New System.Drawing.Size(329, 129)
        Me.CloudGroup2.TabIndex = 11
        '
        'CloudGroup3
        '
        Me.CloudGroup3.AnimationEnabled = True
        Me.CloudGroup3.AnimationSpeed = 4
        Me.CloudGroup3.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup3.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup3.BorderWidth = 1.0!
        Me.CloudGroup3.Controls.Add(Me.LinkLabel5)
        Me.CloudGroup3.Controls.Add(Me.LinkLabel6)
        Me.CloudGroup3.FillColor1 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CloudGroup3.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CloudGroup3.FillColor2_2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup3.FontColorMouseOn = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CloudGroup3.FontColorNormal = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.CloudGroup3.HeaderText = "Diagnosis"
        Me.CloudGroup3.Icon = Nothing
        Me.CloudGroup3.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudGroup3.IconPadding = 5
        Me.CloudGroup3.ImageHeader = False
        Me.CloudGroup3.IsOpen = True
        Me.CloudGroup3.Location = New System.Drawing.Point(717, 341)
        Me.CloudGroup3.MaximumHeight = 127
        Me.CloudGroup3.Name = "CloudGroup3"
        Me.CloudGroup3.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup3.Size = New System.Drawing.Size(329, 127)
        Me.CloudGroup3.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1270, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MToolStripMenuItem, Me.ToolStripTextBox1, Me.UploadToDatabankToolStripMenuItem, Me.ResetDatabaseToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MToolStripMenuItem
        '
        Me.MToolStripMenuItem.Name = "MToolStripMenuItem"
        Me.MToolStripMenuItem.Size = New System.Drawing.Size(179, 6)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripTextBox1.Text = "Open Database"
        '
        'UploadToDatabankToolStripMenuItem
        '
        Me.UploadToDatabankToolStripMenuItem.Name = "UploadToDatabankToolStripMenuItem"
        Me.UploadToDatabankToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UploadToDatabankToolStripMenuItem.Text = "Upload To Databank"
        '
        'ResetDatabaseToolStripMenuItem
        '
        Me.ResetDatabaseToolStripMenuItem.Name = "ResetDatabaseToolStripMenuItem"
        Me.ResetDatabaseToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ResetDatabaseToolStripMenuItem.Text = "Reset Database"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaveFileDialog1
        '
        '
        'CloudGroup4
        '
        Me.CloudGroup4.AnimationEnabled = True
        Me.CloudGroup4.AnimationSpeed = 4
        Me.CloudGroup4.BackColor = System.Drawing.Color.Transparent
        Me.CloudGroup4.BorderColor = System.Drawing.Color.DarkGray
        Me.CloudGroup4.BorderWidth = 1.0!
        Me.CloudGroup4.Controls.Add(Me.LinkLabel7)
        Me.CloudGroup4.Controls.Add(Me.LinkLabel10)
        Me.CloudGroup4.Controls.Add(Me.LinkLabel8)
        Me.CloudGroup4.FillColor1 = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup4.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CloudGroup4.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CloudGroup4.FillColor2_2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CloudGroup4.FontColorMouseOn = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloudGroup4.FontColorNormal = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.CloudGroup4.HeaderText = "GIPD"
        Me.CloudGroup4.Icon = Nothing
        Me.CloudGroup4.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudGroup4.IconPadding = 5
        Me.CloudGroup4.ImageHeader = False
        Me.CloudGroup4.IsOpen = True
        Me.CloudGroup4.Location = New System.Drawing.Point(717, 134)
        Me.CloudGroup4.MaximumHeight = 126
        Me.CloudGroup4.Name = "CloudGroup4"
        Me.CloudGroup4.PanelColor = System.Drawing.Color.Black
        Me.CloudGroup4.Size = New System.Drawing.Size(329, 145)
        Me.CloudGroup4.TabIndex = 11
        '
        'LinkLabel7
        '
        Me.LinkLabel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel7.Location = New System.Drawing.Point(18, 39)
        Me.LinkLabel7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(193, 17)
        Me.LinkLabel7.TabIndex = 1
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Admit Registered Patient"
        '
        'LinkLabel10
        '
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.Location = New System.Drawing.Point(18, 110)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(188, 17)
        Me.LinkLabel10.TabIndex = 3
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "Show Admissions Record"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel8.Location = New System.Drawing.Point(18, 73)
        Me.LinkLabel8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(216, 17)
        Me.LinkLabel8.TabIndex = 2
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Discharge Admitted Patients"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hospital_UITH.My.Resources.Resources.Home_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1270, 675)
        Me.Controls.Add(Me.CloudGroup4)
        Me.Controls.Add(Me.CloudGroup3)
        Me.Controls.Add(Me.CloudGroup2)
        Me.Controls.Add(Me.CloudGroup1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Bodoni MT Black", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CloudGroup1.ResumeLayout(False)
        Me.CloudGroup1.PerformLayout()
        Me.CloudGroup2.ResumeLayout(False)
        Me.CloudGroup2.PerformLayout()
        Me.CloudGroup3.ResumeLayout(False)
        Me.CloudGroup3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.CloudGroup4.ResumeLayout(False)
        Me.CloudGroup4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents CloudGroup1 As CloudToolkitN6.CloudGroup
    Friend WithEvents CloudGroup2 As CloudToolkitN6.CloudGroup
    Friend WithEvents CloudGroup3 As CloudToolkitN6.CloudGroup
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadToDatabankToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CloudGroup4 As CloudToolkitN6.CloudGroup
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel10 As System.Windows.Forms.LinkLabel
    Friend WithEvents MToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
