'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 4 Mar 2019
' Time: 1:27 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FattenerManagement
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FattenerManagement))
		Me.textBox8 = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.lblCurrentUser = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBox7 = New System.Windows.Forms.TextBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.textBox6 = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.label8 = New System.Windows.Forms.Label()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.btnSearch1 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.textBox11 = New System.Windows.Forms.TextBox()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.lblFattenerID = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel1.SuspendLayout
		Me.panel3.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel2.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'textBox8
		'
		Me.textBox8.Location = New System.Drawing.Point(80, 286)
		Me.textBox8.Name = "textBox8"
		Me.textBox8.Size = New System.Drawing.Size(113, 20)
		Me.textBox8.TabIndex = 22
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(-10, 284)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(100, 23)
		Me.label12.TabIndex = 23
		Me.label12.Text = "Cause of Death"
		Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.OldLace
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.lblCurrentUser)
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Location = New System.Drawing.Point(-1, 4)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(863, 100)
		Me.panel1.TabIndex = 18
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(165, 36)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(426, 52)
		Me.label2.TabIndex = 9
		Me.label2.Text = "Fattener Management"
		'
		'lblCurrentUser
		'
		Me.lblCurrentUser.Location = New System.Drawing.Point(229, 13)
		Me.lblCurrentUser.Name = "lblCurrentUser"
		Me.lblCurrentUser.Size = New System.Drawing.Size(87, 23)
		Me.lblCurrentUser.TabIndex = 6
		Me.lblCurrentUser.Text = "USer "
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.Color.OldLace
		Me.label4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(764, 8)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 8
		Me.label4.Text = "Close"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		AddHandler Me.label4.Click, AddressOf Me.Label4Click
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(165, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(87, 23)
		Me.label1.TabIndex = 7
		Me.label1.Text = "Logged as: "
		'
		'textBox7
		'
		Me.textBox7.Location = New System.Drawing.Point(80, 252)
		Me.textBox7.Name = "textBox7"
		Me.textBox7.Size = New System.Drawing.Size(113, 20)
		Me.textBox7.TabIndex = 20
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(-11, 250)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 21
		Me.label11.Text = "Num. of Death"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox6
		'
		Me.textBox6.Location = New System.Drawing.Point(80, 223)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.Size = New System.Drawing.Size(113, 20)
		Me.textBox6.TabIndex = 18
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(-15, 221)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 19
		Me.label10.Text = "Boar"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox5
		'
		Me.textBox5.Location = New System.Drawing.Point(80, 191)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(113, 20)
		Me.textBox5.TabIndex = 16
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(-20, 189)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 17
		Me.label9.Text = "Sow Code"
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(80, 157)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(113, 20)
		Me.textBox4.TabIndex = 14
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(-20, 155)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 15
		Me.label5.Text = "Quantity"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(80, 127)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(113, 20)
		Me.textBox3.TabIndex = 8
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(53, 352)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(93, 30)
		Me.btnUpdate.TabIndex = 12
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = true
		AddHandler Me.btnUpdate.Click, AddressOf Me.BtnUpdateClick
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(-20, 125)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(100, 23)
		Me.label8.TabIndex = 9
		Me.label8.Text = "DOB"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(4, 318)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(93, 30)
		Me.btnAdd.TabIndex = 10
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = true
		AddHandler Me.btnAdd.Click, AddressOf Me.BtnAddClick
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.OldLace
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.btnSearch1)
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Controls.Add(Me.textBox11)
		Me.panel3.Controls.Add(Me.dataGridView1)
		Me.panel3.Location = New System.Drawing.Point(229, 110)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(619, 390)
		Me.panel3.TabIndex = 20
		'
		'btnSearch1
		'
		Me.btnSearch1.Location = New System.Drawing.Point(204, 10)
		Me.btnSearch1.Name = "btnSearch1"
		Me.btnSearch1.Size = New System.Drawing.Size(93, 31)
		Me.btnSearch1.TabIndex = 19
		Me.btnSearch1.Text = "Search"
		Me.btnSearch1.UseVisualStyleBackColor = true
		AddHandler Me.btnSearch1.Click, AddressOf Me.BtnSearch1Click
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(303, 10)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(93, 31)
		Me.button1.TabIndex = 18
		Me.button1.Text = "Reset"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'textBox11
		'
		Me.textBox11.Location = New System.Drawing.Point(6, 14)
		Me.textBox11.Name = "textBox11"
		Me.textBox11.Size = New System.Drawing.Size(191, 20)
		Me.textBox11.TabIndex = 17
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(3, 47)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(610, 337)
		Me.dataGridView1.TabIndex = 0
		AddHandler Me.dataGridView1.CellClick, AddressOf Me.DataGridView1CellClick
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.OldLace
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.textBox8)
		Me.panel2.Controls.Add(Me.label12)
		Me.panel2.Controls.Add(Me.textBox7)
		Me.panel2.Controls.Add(Me.label11)
		Me.panel2.Controls.Add(Me.textBox6)
		Me.panel2.Controls.Add(Me.label10)
		Me.panel2.Controls.Add(Me.textBox5)
		Me.panel2.Controls.Add(Me.label9)
		Me.panel2.Controls.Add(Me.textBox4)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.textBox3)
		Me.panel2.Controls.Add(Me.btnUpdate)
		Me.panel2.Controls.Add(Me.btnDelete)
		Me.panel2.Controls.Add(Me.btnAdd)
		Me.panel2.Controls.Add(Me.label8)
		Me.panel2.Controls.Add(Me.textBox2)
		Me.panel2.Controls.Add(Me.lblFattenerID)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.textBox1)
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Location = New System.Drawing.Point(7, 110)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(200, 390)
		Me.panel2.TabIndex = 19
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(100, 318)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(93, 30)
		Me.btnDelete.TabIndex = 11
		Me.btnDelete.Text = "Cancel"
		Me.btnDelete.UseVisualStyleBackColor = true
		AddHandler Me.btnDelete.Click, AddressOf Me.BtnDeleteClick
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(80, 98)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(113, 20)
		Me.textBox2.TabIndex = 6
		'
		'lblFattenerID
		'
		Me.lblFattenerID.ForeColor = System.Drawing.Color.DarkRed
		Me.lblFattenerID.Location = New System.Drawing.Point(47, 28)
		Me.lblFattenerID.Name = "lblFattenerID"
		Me.lblFattenerID.Size = New System.Drawing.Size(100, 23)
		Me.lblFattenerID.TabIndex = 3
		Me.lblFattenerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(47, 5)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Fattener ID:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(80, 64)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(112, 20)
		Me.textBox1.TabIndex = 1
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(-8, 62)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 5
		Me.label6.Text = "Date Weaned"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(-17, 95)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 7
		Me.label7.Text = "Batch No."
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pictureBox1
		'
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(12, 13)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(142, 80)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 17
		Me.pictureBox1.TabStop = false
		'
		'FattenerManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(860, 505)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FattenerManagement"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FattenerManagement"
		AddHandler Load, AddressOf Me.FattenerManagementLoad
		Me.panel1.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private lblFattenerID As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private btnDelete As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private textBox11 As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private btnSearch1 As System.Windows.Forms.Button
	Private panel3 As System.Windows.Forms.Panel
	Private btnAdd As System.Windows.Forms.Button
	Private label8 As System.Windows.Forms.Label
	Private btnUpdate As System.Windows.Forms.Button
	Private textBox3 As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private textBox4 As System.Windows.Forms.TextBox
	Private label9 As System.Windows.Forms.Label
	Private textBox5 As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private textBox6 As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private textBox7 As System.Windows.Forms.TextBox
	Public label1 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Public lblCurrentUser As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private label12 As System.Windows.Forms.Label
	Private textBox8 As System.Windows.Forms.TextBox
End Class
