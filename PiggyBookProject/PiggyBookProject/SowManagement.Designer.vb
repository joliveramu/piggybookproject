'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 4 Mar 2019
' Time: 3:59 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class SowManagement
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SowManagement))
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.lblCurrentUser = New System.Windows.Forms.Label()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.btnSearch1 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.textBox11 = New System.Windows.Forms.TextBox()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.label15 = New System.Windows.Forms.Label()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.cmbType = New System.Windows.Forms.ComboBox()
		Me.txtKilos = New System.Windows.Forms.TextBox()
		Me.txtMother = New System.Windows.Forms.TextBox()
		Me.label16 = New System.Windows.Forms.Label()
		Me.cmbStatus = New System.Windows.Forms.ComboBox()
		Me.cmbSource = New System.Windows.Forms.ComboBox()
		Me.cmbBreed = New System.Windows.Forms.ComboBox()
		Me.dTPAcquired = New System.Windows.Forms.DateTimePicker()
		Me.dTPBirth = New System.Windows.Forms.DateTimePicker()
		Me.textBox10 = New System.Windows.Forms.TextBox()
		Me.label14 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.lblSowID = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.textBox9 = New System.Windows.Forms.TextBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.txtFather = New System.Windows.Forms.TextBox()
		Me.label17 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel3.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel2.SuspendLayout
		Me.panel1.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(47, 405)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(93, 30)
		Me.btnUpdate.TabIndex = 12
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = true
		AddHandler Me.btnUpdate.Click, AddressOf Me.BtnUpdateClick
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(100, 372)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(93, 30)
		Me.btnDelete.TabIndex = 11
		Me.btnDelete.Text = "Cancel"
		Me.btnDelete.UseVisualStyleBackColor = true
		AddHandler Me.btnDelete.Click, AddressOf Me.BtnDeleteClick
		'
		'lblCurrentUser
		'
		Me.lblCurrentUser.Location = New System.Drawing.Point(229, 13)
		Me.lblCurrentUser.Name = "lblCurrentUser"
		Me.lblCurrentUser.Size = New System.Drawing.Size(87, 23)
		Me.lblCurrentUser.TabIndex = 6
		Me.lblCurrentUser.Text = "USer "
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.OldLace
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.btnSearch1)
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Controls.Add(Me.textBox11)
		Me.panel3.Controls.Add(Me.dataGridView1)
		Me.panel3.Controls.Add(Me.label15)
		Me.panel3.Location = New System.Drawing.Point(229, 112)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(619, 438)
		Me.panel3.TabIndex = 16
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
		Me.textBox11.Location = New System.Drawing.Point(6, 19)
		Me.textBox11.Name = "textBox11"
		Me.textBox11.Size = New System.Drawing.Size(191, 20)
		Me.textBox11.TabIndex = 17
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(3, 48)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(610, 383)
		Me.dataGridView1.TabIndex = 0
		AddHandler Me.dataGridView1.CellClick, AddressOf Me.DataGridView1CellClick
		'
		'label15
		'
		Me.label15.Location = New System.Drawing.Point(-3, -1)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(100, 23)
		Me.label15.TabIndex = 20
		Me.label15.Text = "Search using ID:"
		Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(4, 372)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(93, 30)
		Me.btnAdd.TabIndex = 10
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = true
		AddHandler Me.btnAdd.Click, AddressOf Me.BtnAddClick
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.OldLace
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.cmbType)
		Me.panel2.Controls.Add(Me.txtKilos)
		Me.panel2.Controls.Add(Me.txtMother)
		Me.panel2.Controls.Add(Me.label16)
		Me.panel2.Controls.Add(Me.cmbStatus)
		Me.panel2.Controls.Add(Me.cmbSource)
		Me.panel2.Controls.Add(Me.cmbBreed)
		Me.panel2.Controls.Add(Me.dTPAcquired)
		Me.panel2.Controls.Add(Me.dTPBirth)
		Me.panel2.Controls.Add(Me.textBox10)
		Me.panel2.Controls.Add(Me.label14)
		Me.panel2.Controls.Add(Me.label12)
		Me.panel2.Controls.Add(Me.label11)
		Me.panel2.Controls.Add(Me.label10)
		Me.panel2.Controls.Add(Me.label9)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.btnUpdate)
		Me.panel2.Controls.Add(Me.btnDelete)
		Me.panel2.Controls.Add(Me.btnAdd)
		Me.panel2.Controls.Add(Me.label8)
		Me.panel2.Controls.Add(Me.lblSowID)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.textBox1)
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Controls.Add(Me.textBox9)
		Me.panel2.Controls.Add(Me.label13)
		Me.panel2.Controls.Add(Me.txtFather)
		Me.panel2.Controls.Add(Me.label17)
		Me.panel2.Location = New System.Drawing.Point(7, 112)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(200, 438)
		Me.panel2.TabIndex = 15
		'
		'cmbType
		'
		Me.cmbType.FormattingEnabled = true
		Me.cmbType.Items.AddRange(New Object() {"F1", "F2"})
		Me.cmbType.Location = New System.Drawing.Point(79, 174)
		Me.cmbType.Name = "cmbType"
		Me.cmbType.Size = New System.Drawing.Size(112, 21)
		Me.cmbType.TabIndex = 39
		AddHandler Me.cmbType.KeyPress, AddressOf Me.CmbTypeKeyPress
		'
		'txtKilos
		'
		Me.txtKilos.Location = New System.Drawing.Point(79, 250)
		Me.txtKilos.Name = "txtKilos"
		Me.txtKilos.Size = New System.Drawing.Size(113, 20)
		Me.txtKilos.TabIndex = 38
		'
		'txtMother
		'
		Me.txtMother.Location = New System.Drawing.Point(80, 299)
		Me.txtMother.Name = "txtMother"
		Me.txtMother.Size = New System.Drawing.Size(113, 20)
		Me.txtMother.TabIndex = 34
		'
		'label16
		'
		Me.label16.Location = New System.Drawing.Point(-16, 297)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(100, 23)
		Me.label16.TabIndex = 35
		Me.label16.Text = "Mother:"
		Me.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cmbStatus
		'
		Me.cmbStatus.FormattingEnabled = true
		Me.cmbStatus.Location = New System.Drawing.Point(80, 223)
		Me.cmbStatus.Name = "cmbStatus"
		Me.cmbStatus.Size = New System.Drawing.Size(112, 21)
		Me.cmbStatus.TabIndex = 33
		AddHandler Me.cmbStatus.KeyPress, AddressOf Me.CmbStatusKeyPress
		'
		'cmbSource
		'
		Me.cmbSource.FormattingEnabled = true
		Me.cmbSource.Location = New System.Drawing.Point(80, 198)
		Me.cmbSource.Name = "cmbSource"
		Me.cmbSource.Size = New System.Drawing.Size(112, 21)
		Me.cmbSource.TabIndex = 32
		AddHandler Me.cmbSource.KeyPress, AddressOf Me.CmbSourceKeyPress
		'
		'cmbBreed
		'
		Me.cmbBreed.FormattingEnabled = true
		Me.cmbBreed.Location = New System.Drawing.Point(80, 92)
		Me.cmbBreed.Name = "cmbBreed"
		Me.cmbBreed.Size = New System.Drawing.Size(112, 21)
		Me.cmbBreed.TabIndex = 30
		AddHandler Me.cmbBreed.KeyPress, AddressOf Me.CmbBreedKeyPress
		'
		'dTPAcquired
		'
		Me.dTPAcquired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dTPAcquired.Location = New System.Drawing.Point(80, 148)
		Me.dTPAcquired.Name = "dTPAcquired"
		Me.dTPAcquired.Size = New System.Drawing.Size(112, 20)
		Me.dTPAcquired.TabIndex = 29
		'
		'dTPBirth
		'
		Me.dTPBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dTPBirth.Location = New System.Drawing.Point(80, 119)
		Me.dTPBirth.Name = "dTPBirth"
		Me.dTPBirth.Size = New System.Drawing.Size(112, 20)
		Me.dTPBirth.TabIndex = 28
		'
		'textBox10
		'
		Me.textBox10.Location = New System.Drawing.Point(80, 347)
		Me.textBox10.Name = "textBox10"
		Me.textBox10.Size = New System.Drawing.Size(113, 20)
		Me.textBox10.TabIndex = 26
		'
		'label14
		'
		Me.label14.Location = New System.Drawing.Point(-18, 345)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(100, 23)
		Me.label14.TabIndex = 27
		Me.label14.Text = "Remarks"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(-18, 247)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(100, 23)
		Me.label12.TabIndex = 23
		Me.label12.Text = "No. of Kilos"
		Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(-17, 223)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 21
		Me.label11.Text = "Status"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(-15, 198)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 19
		Me.label10.Text = "Source"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(-20, 171)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 17
		Me.label9.Text = "Type"
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(-20, 145)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 15
		Me.label5.Text = "DOA"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(-20, 119)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(100, 23)
		Me.label8.TabIndex = 9
		Me.label8.Text = "DOB"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSowID
		'
		Me.lblSowID.ForeColor = System.Drawing.Color.DarkRed
		Me.lblSowID.Location = New System.Drawing.Point(47, 28)
		Me.lblSowID.Name = "lblSowID"
		Me.lblSowID.Size = New System.Drawing.Size(100, 23)
		Me.lblSowID.TabIndex = 3
		Me.lblSowID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(47, 5)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Sow ID:"
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
		Me.label6.Text = "Sow Alias"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(-17, 90)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 7
		Me.label7.Text = "Breed"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox9
		'
		Me.textBox9.Location = New System.Drawing.Point(80, 274)
		Me.textBox9.Name = "textBox9"
		Me.textBox9.Size = New System.Drawing.Size(113, 20)
		Me.textBox9.TabIndex = 24
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(-18, 272)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(100, 23)
		Me.label13.TabIndex = 25
		Me.label13.Text = "Owner"
		Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtFather
		'
		Me.txtFather.Location = New System.Drawing.Point(80, 323)
		Me.txtFather.Name = "txtFather"
		Me.txtFather.Size = New System.Drawing.Size(113, 20)
		Me.txtFather.TabIndex = 36
		'
		'label17
		'
		Me.label17.Location = New System.Drawing.Point(-16, 321)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(100, 23)
		Me.label17.TabIndex = 37
		Me.label17.Text = "Father:"
		Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(165, 36)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(344, 52)
		Me.label2.TabIndex = 9
		Me.label2.Text = "Sow Management"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(165, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(87, 23)
		Me.label1.TabIndex = 7
		Me.label1.Text = "Logged as: "
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
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.OldLace
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.lblCurrentUser)
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Location = New System.Drawing.Point(-1, 6)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(863, 100)
		Me.panel1.TabIndex = 14
		'
		'pictureBox1
		'
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(12, 15)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(142, 80)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 13
		Me.pictureBox1.TabStop = false
		'
		'SowManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(860, 555)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "SowManagement"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SowManagement"
		AddHandler Load, AddressOf Me.SowManagementLoad
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel1.ResumeLayout(false)
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private cmbType As System.Windows.Forms.ComboBox
	Private txtKilos As System.Windows.Forms.TextBox
	Private label17 As System.Windows.Forms.Label
	Private txtFather As System.Windows.Forms.TextBox
	Private label16 As System.Windows.Forms.Label
	Private txtMother As System.Windows.Forms.TextBox
	Private cmbSource As System.Windows.Forms.ComboBox
	Private cmbStatus As System.Windows.Forms.ComboBox
	Private cmbBreed As System.Windows.Forms.ComboBox
	Private dTPBirth As System.Windows.Forms.DateTimePicker
	Private dTPAcquired As System.Windows.Forms.DateTimePicker
	Private label15 As System.Windows.Forms.Label
	Private btnSearch1 As System.Windows.Forms.Button
	Private btnSearch As System.Windows.Forms.Button
	Private textBox11 As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private label14 As System.Windows.Forms.Label
	Private textBox10 As System.Windows.Forms.TextBox
	Private label13 As System.Windows.Forms.Label
	Private textBox9 As System.Windows.Forms.TextBox
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private panel1 As System.Windows.Forms.Panel
	Private label4 As System.Windows.Forms.Label
	Public label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private lblSowID As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private btnAdd As System.Windows.Forms.Button
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private panel3 As System.Windows.Forms.Panel
	Public lblCurrentUser As System.Windows.Forms.Label
	Private btnDelete As System.Windows.Forms.Button
	Private btnUpdate As System.Windows.Forms.Button
	
End Class
