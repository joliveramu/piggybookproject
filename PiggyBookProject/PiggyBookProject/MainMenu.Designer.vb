'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 11 Jan 2019
' Time: 2:28 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainMenu
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
		Me.btnPiggeryManagement = New System.Windows.Forms.Button()
		Me.btnSowManagement = New System.Windows.Forms.Button()
		Me.btnProfile = New System.Windows.Forms.Button()
		Me.btnLogout = New System.Windows.Forms.Button()
		Me.lblCurrentUser = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.btnFattenerManagement = New System.Windows.Forms.Button()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.btnSowHistory = New System.Windows.Forms.Button()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'btnPiggeryManagement
		'
		Me.btnPiggeryManagement.BackColor = System.Drawing.Color.OldLace
		Me.btnPiggeryManagement.BackgroundImage = CType(resources.GetObject("btnPiggeryManagement.BackgroundImage"),System.Drawing.Image)
		Me.btnPiggeryManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnPiggeryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPiggeryManagement.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPiggeryManagement.ForeColor = System.Drawing.Color.DarkRed
		Me.btnPiggeryManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnPiggeryManagement.Location = New System.Drawing.Point(33, 135)
		Me.btnPiggeryManagement.Name = "btnPiggeryManagement"
		Me.btnPiggeryManagement.Size = New System.Drawing.Size(190, 91)
		Me.btnPiggeryManagement.TabIndex = 0
		Me.btnPiggeryManagement.Text = "Boar Management"
		Me.btnPiggeryManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnPiggeryManagement.UseVisualStyleBackColor = false
		AddHandler Me.btnPiggeryManagement.Click, AddressOf Me.BtnPiggeryManagementClick
		'
		'btnSowManagement
		'
		Me.btnSowManagement.BackColor = System.Drawing.Color.OldLace
		Me.btnSowManagement.BackgroundImage = CType(resources.GetObject("btnSowManagement.BackgroundImage"),System.Drawing.Image)
		Me.btnSowManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnSowManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSowManagement.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSowManagement.ForeColor = System.Drawing.Color.DarkRed
		Me.btnSowManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSowManagement.Location = New System.Drawing.Point(260, 135)
		Me.btnSowManagement.Name = "btnSowManagement"
		Me.btnSowManagement.Size = New System.Drawing.Size(190, 91)
		Me.btnSowManagement.TabIndex = 1
		Me.btnSowManagement.Text = "Sow Management"
		Me.btnSowManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSowManagement.UseVisualStyleBackColor = false
		AddHandler Me.btnSowManagement.Click, AddressOf Me.BtnSowManagementClick
		'
		'btnProfile
		'
		Me.btnProfile.BackColor = System.Drawing.Color.OldLace
		Me.btnProfile.BackgroundImage = CType(resources.GetObject("btnProfile.BackgroundImage"),System.Drawing.Image)
		Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProfile.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnProfile.ForeColor = System.Drawing.Color.DarkRed
		Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnProfile.Location = New System.Drawing.Point(260, 240)
		Me.btnProfile.Name = "btnProfile"
		Me.btnProfile.Size = New System.Drawing.Size(190, 91)
		Me.btnProfile.TabIndex = 2
		Me.btnProfile.Text = "Profile Management"
		Me.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnProfile.UseVisualStyleBackColor = false
		AddHandler Me.btnProfile.Click, AddressOf Me.BtnProfileClick
		'
		'btnLogout
		'
		Me.btnLogout.BackColor = System.Drawing.Color.OldLace
		Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"),System.Drawing.Image)
		Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLogout.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLogout.ForeColor = System.Drawing.Color.DarkRed
		Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLogout.Location = New System.Drawing.Point(145, 337)
		Me.btnLogout.Name = "btnLogout"
		Me.btnLogout.Size = New System.Drawing.Size(190, 91)
		Me.btnLogout.TabIndex = 3
		Me.btnLogout.Text = "Logout"
		Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLogout.UseVisualStyleBackColor = false
		AddHandler Me.btnLogout.Click, AddressOf Me.BtnLogoutClick
		'
		'lblCurrentUser
		'
		Me.lblCurrentUser.Location = New System.Drawing.Point(120, 33)
		Me.lblCurrentUser.Name = "lblCurrentUser"
		Me.lblCurrentUser.Size = New System.Drawing.Size(100, 23)
		Me.lblCurrentUser.TabIndex = 4
		Me.lblCurrentUser.Text = "USer "
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(120, 10)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 5
		Me.label1.Text = "Logged as: "
		'
		'btnFattenerManagement
		'
		Me.btnFattenerManagement.BackColor = System.Drawing.Color.OldLace
		Me.btnFattenerManagement.BackgroundImage = CType(resources.GetObject("btnFattenerManagement.BackgroundImage"),System.Drawing.Image)
		Me.btnFattenerManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnFattenerManagement.Enabled = false
		Me.btnFattenerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnFattenerManagement.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnFattenerManagement.ForeColor = System.Drawing.Color.DarkRed
		Me.btnFattenerManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnFattenerManagement.Location = New System.Drawing.Point(33, 240)
		Me.btnFattenerManagement.Name = "btnFattenerManagement"
		Me.btnFattenerManagement.Size = New System.Drawing.Size(190, 91)
		Me.btnFattenerManagement.TabIndex = 6
		Me.btnFattenerManagement.Text = "Fattener Management"
		Me.btnFattenerManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnFattenerManagement.UseVisualStyleBackColor = false
		Me.btnFattenerManagement.Visible = false
		AddHandler Me.btnFattenerManagement.Click, AddressOf Me.BtnFattenerManagementClick
		'
		'pictureBox1
		'
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(9, 10)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(105, 81)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 11
		Me.pictureBox1.TabStop = false
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.OldLace
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.pictureBox1)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Controls.Add(Me.lblCurrentUser)
		Me.panel1.Location = New System.Drawing.Point(0, 1)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(489, 125)
		Me.panel1.TabIndex = 12
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(120, 56)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(353, 52)
		Me.label2.TabIndex = 12
		Me.label2.Text = "Pig Book Management System Main Menu"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnSowHistory
		'
		Me.btnSowHistory.BackColor = System.Drawing.Color.OldLace
		Me.btnSowHistory.BackgroundImage = CType(resources.GetObject("btnSowHistory.BackgroundImage"),System.Drawing.Image)
		Me.btnSowHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.btnSowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSowHistory.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSowHistory.ForeColor = System.Drawing.Color.DarkRed
		Me.btnSowHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnSowHistory.Location = New System.Drawing.Point(33, 240)
		Me.btnSowHistory.Name = "btnSowHistory"
		Me.btnSowHistory.Size = New System.Drawing.Size(190, 91)
		Me.btnSowHistory.TabIndex = 13
		Me.btnSowHistory.Text = "Sow History"
		Me.btnSowHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSowHistory.UseVisualStyleBackColor = false
		AddHandler Me.btnSowHistory.Click, AddressOf Me.BtnSowHistoryClick
		'
		'MainMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(486, 446)
		Me.Controls.Add(Me.btnSowHistory)
		Me.Controls.Add(Me.btnLogout)
		Me.Controls.Add(Me.btnProfile)
		Me.Controls.Add(Me.btnSowManagement)
		Me.Controls.Add(Me.btnPiggeryManagement)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.btnFattenerManagement)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MainMenu"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MainMenu"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private btnSowHistory As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private btnFattenerManagement As System.Windows.Forms.Button
	Public label1 As System.Windows.Forms.Label
	Public lblCurrentUser As System.Windows.Forms.Label
	Private btnLogout As System.Windows.Forms.Button
	Private btnProfile As System.Windows.Forms.Button
	Private btnSowManagement As System.Windows.Forms.Button
	Private btnPiggeryManagement As System.Windows.Forms.Button
	
	
End Class
