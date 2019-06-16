'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 12/03/2019
' Time: 12:41 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class frmShowSow
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowSow))
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.textID = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.lblSowID = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.cmbBoarID = New System.Windows.Forms.ComboBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.cmbNatai = New System.Windows.Forms.ComboBox()
		Me.dtpWeanDate = New System.Windows.Forms.DateTimePicker()
		Me.dtpPigDOB = New System.Windows.Forms.DateTimePicker()
		Me.dtpDateCaste = New System.Windows.Forms.DateTimePicker()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.txtDeath = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.txtStillBorn = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.txtMummified = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.txtLiveBorn = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.txtBorn = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.lblCurrentUser = New System.Windows.Forms.Label()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel2.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'dataGridView1
		'
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(23, 177)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(855, 245)
		Me.dataGridView1.TabIndex = 0
		'
		'textID
		'
		Me.textID.Location = New System.Drawing.Point(26, 12)
		Me.textID.Name = "textID"
		Me.textID.Size = New System.Drawing.Size(100, 20)
		Me.textID.TabIndex = 1
		Me.textID.Visible = false
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.OldLace
		Me.label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(140, 56)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(117, 23)
		Me.label1.TabIndex = 2
		Me.label1.Text = "Records of ID"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSowID
		'
		Me.lblSowID.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblSowID.Location = New System.Drawing.Point(132, 49)
		Me.lblSowID.Name = "lblSowID"
		Me.lblSowID.Size = New System.Drawing.Size(93, 23)
		Me.lblSowID.TabIndex = 3
		Me.lblSowID.Text = "Sow ID"
		Me.lblSowID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnClose
		'
		Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnClose.Location = New System.Drawing.Point(828, 4)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(53, 23)
		Me.btnClose.TabIndex = 4
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = true
		AddHandler Me.btnClose.Click, AddressOf Me.BtnCloseClick
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.OldLace
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Location = New System.Drawing.Point(12, 165)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(877, 270)
		Me.panel1.TabIndex = 6
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.OldLace
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.pictureBox1)
		Me.panel2.Controls.Add(Me.lblSowID)
		Me.panel2.Location = New System.Drawing.Point(12, 36)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(248, 123)
		Me.panel2.TabIndex = 7
		'
		'pictureBox1
		'
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(7, 8)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(114, 108)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 15
		Me.pictureBox1.TabStop = false
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.OldLace
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.cmbBoarID)
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Controls.Add(Me.cmbNatai)
		Me.panel3.Controls.Add(Me.dtpWeanDate)
		Me.panel3.Controls.Add(Me.dtpPigDOB)
		Me.panel3.Controls.Add(Me.dtpDateCaste)
		Me.panel3.Controls.Add(Me.label11)
		Me.panel3.Controls.Add(Me.label10)
		Me.panel3.Controls.Add(Me.txtDeath)
		Me.panel3.Controls.Add(Me.label9)
		Me.panel3.Controls.Add(Me.label8)
		Me.panel3.Controls.Add(Me.label7)
		Me.panel3.Controls.Add(Me.txtStillBorn)
		Me.panel3.Controls.Add(Me.label6)
		Me.panel3.Controls.Add(Me.txtMummified)
		Me.panel3.Controls.Add(Me.label5)
		Me.panel3.Controls.Add(Me.txtLiveBorn)
		Me.panel3.Controls.Add(Me.label4)
		Me.panel3.Controls.Add(Me.txtBorn)
		Me.panel3.Controls.Add(Me.label3)
		Me.panel3.Controls.Add(Me.label2)
		Me.panel3.Location = New System.Drawing.Point(266, 36)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(623, 123)
		Me.panel3.TabIndex = 8
		'
		'cmbBoarID
		'
		Me.cmbBoarID.FormattingEnabled = true
		Me.cmbBoarID.Location = New System.Drawing.Point(4, 95)
		Me.cmbBoarID.Name = "cmbBoarID"
		Me.cmbBoarID.Size = New System.Drawing.Size(99, 21)
		Me.cmbBoarID.TabIndex = 25
		Me.cmbBoarID.Text = "SELECT ID"
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(539, 59)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 34)
		Me.button1.TabIndex = 24
		Me.button1.Text = "Add Record"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'cmbNatai
		'
		Me.cmbNatai.FormattingEnabled = true
		Me.cmbNatai.Items.AddRange(New Object() {"AI", "Natural"})
		Me.cmbNatai.Location = New System.Drawing.Point(427, 95)
		Me.cmbNatai.Name = "cmbNatai"
		Me.cmbNatai.Size = New System.Drawing.Size(100, 21)
		Me.cmbNatai.TabIndex = 23
		Me.cmbNatai.Text = "SELECT NATAI"
		'
		'dtpWeanDate
		'
		Me.dtpWeanDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpWeanDate.Location = New System.Drawing.Point(321, 96)
		Me.dtpWeanDate.Name = "dtpWeanDate"
		Me.dtpWeanDate.Size = New System.Drawing.Size(100, 20)
		Me.dtpWeanDate.TabIndex = 22
		'
		'dtpPigDOB
		'
		Me.dtpPigDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpPigDOB.Location = New System.Drawing.Point(109, 96)
		Me.dtpPigDOB.Name = "dtpPigDOB"
		Me.dtpPigDOB.Size = New System.Drawing.Size(100, 20)
		Me.dtpPigDOB.TabIndex = 21
		'
		'dtpDateCaste
		'
		Me.dtpDateCaste.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpDateCaste.Location = New System.Drawing.Point(3, 36)
		Me.dtpDateCaste.Name = "dtpDateCaste"
		Me.dtpDateCaste.Size = New System.Drawing.Size(100, 20)
		Me.dtpDateCaste.TabIndex = 20
		'
		'label11
		'
		Me.label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.Location = New System.Drawing.Point(427, 70)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 18
		Me.label11.Text = "Natai"
		'
		'label10
		'
		Me.label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.Location = New System.Drawing.Point(321, 70)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 16
		Me.label10.Text = "Wean Date"
		'
		'txtDeath
		'
		Me.txtDeath.Location = New System.Drawing.Point(215, 96)
		Me.txtDeath.Name = "txtDeath"
		Me.txtDeath.Size = New System.Drawing.Size(100, 20)
		Me.txtDeath.TabIndex = 15
		'
		'label9
		'
		Me.label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.Location = New System.Drawing.Point(215, 70)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 14
		Me.label9.Text = "Deaths"
		'
		'label8
		'
		Me.label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.Location = New System.Drawing.Point(109, 70)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(100, 23)
		Me.label8.TabIndex = 12
		Me.label8.Text = "Piglet DOB"
		'
		'label7
		'
		Me.label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(3, 70)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 10
		Me.label7.Text = "Boar ID"
		'
		'txtStillBorn
		'
		Me.txtStillBorn.Location = New System.Drawing.Point(427, 36)
		Me.txtStillBorn.Name = "txtStillBorn"
		Me.txtStillBorn.Size = New System.Drawing.Size(100, 20)
		Me.txtStillBorn.TabIndex = 9
		'
		'label6
		'
		Me.label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(427, 10)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 8
		Me.label6.Text = "Stillborn"
		'
		'txtMummified
		'
		Me.txtMummified.Location = New System.Drawing.Point(321, 36)
		Me.txtMummified.Name = "txtMummified"
		Me.txtMummified.Size = New System.Drawing.Size(100, 20)
		Me.txtMummified.TabIndex = 7
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(321, 10)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 6
		Me.label5.Text = "Mummified"
		'
		'txtLiveBorn
		'
		Me.txtLiveBorn.Location = New System.Drawing.Point(215, 36)
		Me.txtLiveBorn.Name = "txtLiveBorn"
		Me.txtLiveBorn.Size = New System.Drawing.Size(100, 20)
		Me.txtLiveBorn.TabIndex = 5
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(215, 10)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 4
		Me.label4.Text = "Liveborn"
		'
		'txtBorn
		'
		Me.txtBorn.Location = New System.Drawing.Point(109, 36)
		Me.txtBorn.Name = "txtBorn"
		Me.txtBorn.Size = New System.Drawing.Size(100, 20)
		Me.txtBorn.TabIndex = 3
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(109, 10)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Born"
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(3, 10)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 0
		Me.label2.Text = "Date Caste"
		'
		'lblCurrentUser
		'
		Me.lblCurrentUser.Location = New System.Drawing.Point(145, 4)
		Me.lblCurrentUser.Name = "lblCurrentUser"
		Me.lblCurrentUser.Size = New System.Drawing.Size(100, 23)
		Me.lblCurrentUser.TabIndex = 9
		Me.lblCurrentUser.Text = "label12"
		Me.lblCurrentUser.Visible = false
		'
		'frmShowSow
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(893, 453)
		Me.Controls.Add(Me.lblCurrentUser)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.textID)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.panel2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "frmShowSow"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmShowSow"
		AddHandler Load, AddressOf Me.FrmShowSowLoad
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel2.ResumeLayout(false)
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Public lblCurrentUser As System.Windows.Forms.Label
	Private cmbBoarID As System.Windows.Forms.ComboBox
	Private button1 As System.Windows.Forms.Button
	Private cmbNatai As System.Windows.Forms.ComboBox
	Private dtpWeanDate As System.Windows.Forms.DateTimePicker
	Private dtpPigDOB As System.Windows.Forms.DateTimePicker
	Private dtpDateCaste As System.Windows.Forms.DateTimePicker
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private txtBorn As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private txtLiveBorn As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private txtMummified As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private txtStillBorn As System.Windows.Forms.TextBox
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private txtDeath As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private panel3 As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private btnClose As System.Windows.Forms.Button
	Private lblSowID As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Public textID As System.Windows.Forms.TextBox
	Private dataGridView1 As System.Windows.Forms.DataGridView
End Class
