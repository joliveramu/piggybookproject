'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 11 Jan 2019
' Time: 2:00 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtUsername = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(164, 214)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(193, 36)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Login"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.OldLace
		Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(34, 129)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Username"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label2
		'
		Me.label2.BackColor = System.Drawing.Color.OldLace
		Me.label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(34, 175)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Password"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtUsername
		'
		Me.txtUsername.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtUsername.Location = New System.Drawing.Point(164, 129)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(193, 27)
		Me.txtUsername.TabIndex = 3
		'
		'txtPassword
		'
		Me.txtPassword.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPassword.Location = New System.Drawing.Point(164, 172)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(193, 27)
		Me.txtPassword.TabIndex = 4
		'
		'pictureBox1
		'
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(18, 13)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(88, 80)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 11
		Me.pictureBox1.TabStop = false
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.OldLace
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Controls.Add(Me.button1)
		Me.panel1.Controls.Add(Me.txtPassword)
		Me.panel1.Controls.Add(Me.txtUsername)
		Me.panel1.Controls.Add(Me.label3)
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.pictureBox1)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Location = New System.Drawing.Point(5, 9)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(394, 299)
		Me.panel1.TabIndex = 12
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.Color.OldLace
		Me.label4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(289, 268)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 13
		Me.label4.Text = "Exit"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label4.Click, AddressOf Me.Label4Click
		'
		'label3
		'
		Me.label3.BackColor = System.Drawing.Color.OldLace
		Me.label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(155, 29)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(202, 64)
		Me.label3.TabIndex = 12
		Me.label3.Text = "Pig Book Management System"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(406, 317)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PiggyBookProject"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private txtPassword As System.Windows.Forms.TextBox
	Private txtUsername As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
End Class
