<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.btnGo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGame = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmboBallSpeed = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmboDropRate = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tabExteras = New System.Windows.Forms.TabPage()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLevelCode = New System.Windows.Forms.TextBox()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.picKeys = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabExit = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDropRate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBallSpeed = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabGame.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabExteras.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabExit.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.Black
        Me.btnGo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGo.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(3, 405)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(879, 52)
        Me.btnGo.TabIndex = 84
        Me.btnGo.Text = "GO!!!!"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.tabGame)
        Me.TabControl1.Controls.Add(Me.tabExteras)
        Me.TabControl1.Controls.Add(Me.tabAbout)
        Me.TabControl1.Controls.Add(Me.tabExit)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(912, 468)
        Me.TabControl1.TabIndex = 85
        '
        'tabGame
        '
        Me.tabGame.BackColor = System.Drawing.Color.White
        Me.tabGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabGame.Controls.Add(Me.GroupBox4)
        Me.tabGame.Controls.Add(Me.btnSave)
        Me.tabGame.ForeColor = System.Drawing.Color.Black
        Me.tabGame.Location = New System.Drawing.Point(23, 4)
        Me.tabGame.Name = "tabGame"
        Me.tabGame.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGame.Size = New System.Drawing.Size(885, 460)
        Me.tabGame.TabIndex = 0
        Me.tabGame.Text = "Game"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.cmboBallSpeed)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.cmboDropRate)
        Me.GroupBox4.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(265, 184)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SETTINGS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ball Speed:"
        '
        'cmboBallSpeed
        '
        Me.cmboBallSpeed.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboBallSpeed.FormattingEnabled = True
        Me.cmboBallSpeed.Items.AddRange(New Object() {"Slow", "Medium", "Fast", "Super Fast"})
        Me.cmboBallSpeed.Location = New System.Drawing.Point(23, 89)
        Me.cmboBallSpeed.Name = "cmboBallSpeed"
        Me.cmboBallSpeed.Size = New System.Drawing.Size(162, 23)
        Me.cmboBallSpeed.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Drop Rate:"
        '
        'cmboDropRate
        '
        Me.cmboDropRate.Font = New System.Drawing.Font("Bauhaus 93", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboDropRate.FormattingEnabled = True
        Me.cmboDropRate.Items.AddRange(New Object() {"Default", "Slow", "Medium", "Fast"})
        Me.cmboDropRate.Location = New System.Drawing.Point(23, 144)
        Me.cmboDropRate.Name = "cmboDropRate"
        Me.cmboDropRate.Size = New System.Drawing.Size(162, 23)
        Me.cmboDropRate.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Gray
        Me.btnSave.Font = New System.Drawing.Font("Bauhaus 93", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(9, 418)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(866, 36)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE ALL"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tabExteras
        '
        Me.tabExteras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabExteras.Controls.Add(Me.btnEnter)
        Me.tabExteras.Controls.Add(Me.Label5)
        Me.tabExteras.Controls.Add(Me.txtLevelCode)
        Me.tabExteras.Location = New System.Drawing.Point(23, 4)
        Me.tabExteras.Name = "tabExteras"
        Me.tabExteras.Size = New System.Drawing.Size(885, 460)
        Me.tabExteras.TabIndex = 3
        Me.tabExteras.Text = "Exteras"
        Me.tabExteras.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(885, -11)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(10, 10)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Button2"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bauhaus 93", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(255, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 73)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Level Code:"
        '
        'txtLevelCode
        '
        Me.txtLevelCode.BackColor = System.Drawing.Color.Gray
        Me.txtLevelCode.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.txtLevelCode.Font = New System.Drawing.Font("Bauhaus 93", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelCode.ForeColor = System.Drawing.Color.White
        Me.txtLevelCode.Location = New System.Drawing.Point(13, 172)
        Me.txtLevelCode.Name = "txtLevelCode"
        Me.txtLevelCode.Size = New System.Drawing.Size(858, 148)
        Me.txtLevelCode.TabIndex = 0
        Me.txtLevelCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLevelCode.UseWaitCursor = True
        '
        'tabAbout
        '
        Me.tabAbout.BackColor = System.Drawing.Color.White
        Me.tabAbout.Controls.Add(Me.GroupBox1)
        Me.tabAbout.Controls.Add(Me.GroupBox3)
        Me.tabAbout.Location = New System.Drawing.Point(23, 4)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(885, 460)
        Me.tabAbout.TabIndex = 4
        Me.tabAbout.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 451)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM DROPS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(127, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 28)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "EXTERA LIFE"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(23, 347)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(98, 98)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(127, 270)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 56)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "MULTI-BALL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(COMING SOON)"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 151)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 98)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(23, 249)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(98, 98)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(127, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 28)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "SLOW DOWN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(127, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 28)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "SPEED UP"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.picKeys)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(339, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(330, 451)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONTROLS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(121, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 84)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "PADDLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RIGHT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picKeys
        '
        Me.picKeys.Image = CType(resources.GetObject("picKeys.Image"), System.Drawing.Image)
        Me.picKeys.Location = New System.Drawing.Point(18, 56)
        Me.picKeys.Name = "picKeys"
        Me.picKeys.Size = New System.Drawing.Size(97, 351)
        Me.picKeys.TabIndex = 8
        Me.picKeys.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(121, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 56)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "PADDLE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LEFT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(121, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 28)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "SHOOT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 56)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "NOT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ASSIGNED"
        '
        'tabExit
        '
        Me.tabExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabExit.Controls.Add(Me.GroupBox2)
        Me.tabExit.Controls.Add(Me.btnGo)
        Me.tabExit.Location = New System.Drawing.Point(23, 4)
        Me.tabExit.Name = "tabExit"
        Me.tabExit.Size = New System.Drawing.Size(885, 460)
        Me.tabExit.TabIndex = 2
        Me.tabExit.Text = "Exit"
        Me.tabExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblDropRate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblBallSpeed)
        Me.GroupBox2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 164)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHANGES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 33)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Ball Speed:"
        '
        'lblDropRate
        '
        Me.lblDropRate.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDropRate.ForeColor = System.Drawing.Color.DimGray
        Me.lblDropRate.Location = New System.Drawing.Point(184, 116)
        Me.lblDropRate.Name = "lblDropRate"
        Me.lblDropRate.Size = New System.Drawing.Size(141, 31)
        Me.lblDropRate.TabIndex = 88
        Me.lblDropRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 33)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Drop Rate:"
        '
        'lblBallSpeed
        '
        Me.lblBallSpeed.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBallSpeed.ForeColor = System.Drawing.Color.DimGray
        Me.lblBallSpeed.Location = New System.Drawing.Point(184, 57)
        Me.lblBallSpeed.Name = "lblBallSpeed"
        Me.lblBallSpeed.Size = New System.Drawing.Size(141, 31)
        Me.lblBallSpeed.TabIndex = 87
        Me.lblBallSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        '
        'Settings
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelButton = Me.btnGo
        Me.ClientSize = New System.Drawing.Size(910, 465)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.tabGame.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabExteras.ResumeLayout(False)
        Me.tabExteras.PerformLayout()
        Me.tabAbout.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.picKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabExit.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGo As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabGame As TabPage
    Friend WithEvents tabExit As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cmboDropRate As ComboBox
    Friend WithEvents cmboBallSpeed As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblDropRate As Label
    Friend WithEvents lblBallSpeed As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents tabExteras As TabPage
    Friend WithEvents btnEnter As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLevelCode As TextBox
    Friend WithEvents tabAbout As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents picKeys As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class
