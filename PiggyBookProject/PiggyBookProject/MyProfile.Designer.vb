'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 11 Jan 2019
' Time: 2:56 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MyProfile
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyProfile))
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtPassword1 = New System.Windows.Forms.TextBox()
		Me.txtPassword2 = New System.Windows.Forms.TextBox()
		Me.lblProfileUser = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label5 = New System.Windows.Forms.Label()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.SuspendLayout
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.Color.OldLace
		Me.label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(46, 206)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 39)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Re-enter Password"
		'
		'txtPassword1
		'
		Me.txtPassword1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPassword1.Location = New System.Drawing.Point(165, 161)
		Me.txtPassword1.Name = "txtPassword1"
		Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword1.Size = New System.Drawing.Size(256, 27)
		Me.txtPassword1.TabIndex = 3
		'
		'txtPassword2
		'
		Me.txtPassword2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPassword2.Location = New System.Drawing.Point(165, 209)
		Me.txtPassword2.Name = "txtPassword2"
		Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword2.Size = New System.Drawing.Size(256, 27)
		Me.txtPassword2.TabIndex = 4
		'
		'lblProfileUser
		'
		Me.lblProfileUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblProfileUser.Location = New System.Drawing.Point(110, 35)
		Me.lblProfileUser.Name = "lblProfileUser"
		Me.lblProfileUser.Size = New System.Drawing.Size(100, 23)
		Me.lblProfileUser.TabIndex = 5
		Me.lblProfileUser.Text = "User"
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(110, 12)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 6
		Me.label3.Text = "Username:"
		'
		'label4
		'
		Me.label4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(355, 9)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "Close"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		AddHandler Me.label4.Click, AddressOf Me.Label4Click
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(11, 9)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(93, 80)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 11
		Me.pictureBox1.TabStop = false
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.OldLace
		Me.panel1.Controls.Add(Me.label5)
		Me.panel1.Controls.Add(Me.lblProfileUser)
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Controls.Add(Me.label3)
		Me.panel1.Controls.Add(Me.pictureBox1)
		Me.panel1.Location = New System.Drawing.Point(1, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(458, 100)
		Me.panel1.TabIndex = 12
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(110, 52)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(310, 42)
		Me.label5.TabIndex = 12
		Me.label5.Text = "Profile Settings"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnUpdate
		'
		Me.btnUpdate.BackColor = System.Drawing.Color.OldLace
		Me.btnUpdate.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnUpdate.Location = New System.Drawing.Point(156, 148)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(256, 48)
		Me.btnUpdate.TabIndex = 0
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = false
		AddHandler Me.btnUpdate.Click, AddressOf Me.BtnUpdateClick
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.OldLace
		Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(37, 46)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 42)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Type New Password"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.OldLace
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.btnUpdate)
		Me.panel2.Location = New System.Drawing.Point(9, 115)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(439, 222)
		Me.panel2.TabIndex = 13
		'
		'MyProfile
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(458, 349)
		Me.Controls.Add(Me.txtPassword2)
		Me.Controls.Add(Me.txtPassword1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.panel2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MyProfile"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MyProfile"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label5 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private label4 As System.Windows.Forms.Label
	Public label3 As System.Windows.Forms.Label
	Public lblProfileUser As System.Windows.Forms.Label
	Private txtPassword2 As System.Windows.Forms.TextBox
	Private txtPassword1 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private btnUpdate As System.Windows.Forms.Button
End Class
