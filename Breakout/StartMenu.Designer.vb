<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartMenu))
        Me.lblBreakout = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Timer(Me.components)
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Buttons = New System.Windows.Forms.Timer(Me.components)
        Me.lblDivider = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBreakout
        '
        Me.lblBreakout.Font = New System.Drawing.Font("Bauhaus 93", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakout.ForeColor = System.Drawing.Color.White
        Me.lblBreakout.Location = New System.Drawing.Point(20, 20)
        Me.lblBreakout.Name = "lblBreakout"
        Me.lblBreakout.Size = New System.Drawing.Size(697, 101)
        Me.lblBreakout.TabIndex = 0
        Me.lblBreakout.Text = "B R E A K O U T"
        Me.lblBreakout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Title
        '
        Me.Title.Enabled = True
        Me.Title.Interval = 10
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(50, 144)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(350, 43)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New Game"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = False
        Me.btnNew.Visible = False
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.Black
        Me.btnResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResume.ForeColor = System.Drawing.Color.White
        Me.btnResume.Location = New System.Drawing.Point(50, 210)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(350, 43)
        Me.btnResume.TabIndex = 2
        Me.btnResume.Text = "Resume Game"
        Me.btnResume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResume.UseVisualStyleBackColor = False
        Me.btnResume.Visible = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Black
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(50, 274)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(350, 43)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.UseVisualStyleBackColor = False
        Me.btnSettings.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Black
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(50, 338)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(350, 43)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuit.UseVisualStyleBackColor = False
        Me.btnQuit.Visible = False
        '
        'Buttons
        '
        Me.Buttons.Interval = 200
        '
        'lblDivider
        '
        Me.lblDivider.AutoSize = True
        Me.lblDivider.BackColor = System.Drawing.Color.Black
        Me.lblDivider.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivider.ForeColor = System.Drawing.Color.White
        Me.lblDivider.Location = New System.Drawing.Point(47, 115)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(791, 13)
        Me.lblDivider.TabIndex = 5
        Me.lblDivider.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "-----------------------------------"
        Me.lblDivider.Visible = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(689, 27)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(181, 101)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 6
        Me.picLogo.TabStop = False
        Me.picLogo.Visible = False
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(910, 465)
        Me.Controls.Add(Me.lblDivider)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblBreakout)
        Me.Controls.Add(Me.picLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartMenu"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBreakout As Label
    Friend WithEvents Title As Timer
    Friend WithEvents btnNew As Button
    Friend WithEvents btnResume As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Buttons As Timer
    Friend WithEvents lblDivider As Label
    Friend WithEvents picLogo As PictureBox
End Class
