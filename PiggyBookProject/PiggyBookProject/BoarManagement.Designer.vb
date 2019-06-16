'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 4 Mar 2019
' Time: 1:05 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class BoarManagement
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BoarManagement))
		Me.lblCurrentUser = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.cmbSource = New System.Windows.Forms.ComboBox()
		Me.cmbBreed = New System.Windows.Forms.ComboBox()
		Me.dTPBoarBirth = New System.Windows.Forms.DateTimePicker()
		Me.textBox6 = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.lblBoarID = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.textBox4 = New System.Windows.Forms.TextBox()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.printDialog1 = New System.Windows.Forms.PrintDialog()
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.txtMother = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.txtFather = New System.Windows.Forms.TextBox()
		Me.label11 = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel3.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblCurrentUser
		'
		Me.lblCurrentUser.Location = New System.Drawing.Point(229, 13)
		Me.lblCurrentUser.Name = "lblCurrentUser"
		Me.lblCurrentUser.Size = New System.Drawing.Size(87, 23)
		Me.lblCurrentUser.TabIndex = 6
		Me.lblCurrentUser.Text = "USer "
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
		'pictureBox1
		'
		Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(12, 9)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(142, 80)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pictureBox1.TabIndex = 9
		Me.pictureBox1.TabStop = false
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.OldLace
		Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.lblCurrentUser)
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Location = New System.Drawing.Point(-1, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(863, 100)
		Me.panel1.TabIndex = 10
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(165, 36)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(344, 52)
		Me.label2.TabIndex = 9
		Me.label2.Text = "Boar Management"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.OldLace
		Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel2.Controls.Add(Me.txtFather)
		Me.panel2.Controls.Add(Me.txtMother)
		Me.panel2.Controls.Add(Me.cmbSource)
		Me.panel2.Controls.Add(Me.cmbBreed)
		Me.panel2.Controls.Add(Me.dTPBoarBirth)
		Me.panel2.Controls.Add(Me.textBox6)
		Me.panel2.Controls.Add(Me.btnUpdate)
		Me.panel2.Controls.Add(Me.btnDelete)
		Me.panel2.Controls.Add(Me.btnAdd)
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.lblBoarID)
		Me.panel2.Controls.Add(Me.label3)
		Me.panel2.Controls.Add(Me.textBox1)
		Me.panel2.Controls.Add(Me.label10)
		Me.panel2.Controls.Add(Me.label7)
		Me.panel2.Controls.Add(Me.label8)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Controls.Add(Me.label9)
		Me.panel2.Controls.Add(Me.label11)
		Me.panel2.Location = New System.Drawing.Point(7, 106)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(200, 421)
		Me.panel2.TabIndex = 11
		'
		'cmbSource
		'
		Me.cmbSource.FormattingEnabled = true
		Me.cmbSource.Location = New System.Drawing.Point(4, 212)
		Me.cmbSource.Name = "cmbSource"
		Me.cmbSource.Size = New System.Drawing.Size(189, 21)
		Me.cmbSource.TabIndex = 19
		'
		'cmbBreed
		'
		Me.cmbBreed.FormattingEnabled = true
		Me.cmbBreed.Location = New System.Drawing.Point(4, 170)
		Me.cmbBreed.Name = "cmbBreed"
		Me.cmbBreed.Size = New System.Drawing.Size(189, 21)
		Me.cmbBreed.TabIndex = 18
		'
		'dTPBoarBirth
		'
		Me.dTPBoarBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dTPBoarBirth.Location = New System.Drawing.Point(4, 130)
		Me.dTPBoarBirth.Name = "dTPBoarBirth"
		Me.dTPBoarBirth.Size = New System.Drawing.Size(191, 20)
		Me.dTPBoarBirth.TabIndex = 17
		'
		'textBox6
		'
		Me.textBox6.Location = New System.Drawing.Point(2, 254)
		Me.textBox6.Name = "textBox6"
		Me.textBox6.Size = New System.Drawing.Size(191, 20)
		Me.textBox6.TabIndex = 15
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(47, 188)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 14
		Me.label5.Text = "Boar Source"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(54, 388)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(93, 29)
		Me.btnUpdate.TabIndex = 12
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = true
		AddHandler Me.btnUpdate.Click, AddressOf Me.BtnUpdateClick
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(100, 355)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(93, 29)
		Me.btnDelete.TabIndex = 11
		Me.btnDelete.Text = "Cancel"
		Me.btnDelete.UseVisualStyleBackColor = true
		AddHandler Me.btnDelete.Click, AddressOf Me.BtnDeleteClick
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(4, 355)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(93, 29)
		Me.btnAdd.TabIndex = 10
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = true
		AddHandler Me.btnAdd.Click, AddressOf Me.BtnAddClick
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(47, 148)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(100, 23)
		Me.label8.TabIndex = 9
		Me.label8.Text = "Boar Breed"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(47, 108)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 7
		Me.label7.Text = "Boar Birthday"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(46, 67)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 5
		Me.label6.Text = "Boar Alias"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblBoarID
		'
		Me.lblBoarID.ForeColor = System.Drawing.Color.DarkRed
		Me.lblBoarID.Location = New System.Drawing.Point(47, 35)
		Me.lblBoarID.Name = "lblBoarID"
		Me.lblBoarID.Size = New System.Drawing.Size(100, 23)
		Me.lblBoarID.TabIndex = 3
		Me.lblBoarID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(47, 12)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Boar ID:"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(3, 90)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(191, 20)
		Me.textBox1.TabIndex = 1
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(45, 231)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 16
		Me.label9.Text = "Boar Remarks"
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(206, 7)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(93, 31)
		Me.btnSearch.TabIndex = 13
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = true
		AddHandler Me.btnSearch.Click, AddressOf Me.BtnSearchClick
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.OldLace
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.button2)
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Controls.Add(Me.textBox4)
		Me.panel3.Controls.Add(Me.btnSearch)
		Me.panel3.Controls.Add(Me.dataGridView1)
		Me.panel3.Location = New System.Drawing.Point(229, 106)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(619, 421)
		Me.panel3.TabIndex = 12
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(458, 11)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 16
		Me.button2.Text = "Print"
		Me.button2.UseVisualStyleBackColor = true
		Me.button2.Visible = false
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(305, 7)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(93, 31)
		Me.button1.TabIndex = 15
		Me.button1.Text = "Reset"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(8, 11)
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(191, 20)
		Me.textBox4.TabIndex = 14
		'
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(4, 46)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(610, 370)
		Me.dataGridView1.TabIndex = 0
		AddHandler Me.dataGridView1.CellClick, AddressOf Me.DataGridView1CellClick
		'
		'printDialog1
		'
		Me.printDialog1.UseEXDialog = true
		'
		'printDocument1
		'
		AddHandler Me.printDocument1.PrintPage, AddressOf Me.PrintDocument1PrintPage
		'
		'printPreviewDialog1
		'
		Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
		Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
		Me.printPreviewDialog1.Enabled = true
		Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"),System.Drawing.Icon)
		Me.printPreviewDialog1.Name = "printPreviewDialog1"
		Me.printPreviewDialog1.Visible = false
		'
		'txtMother
		'
		Me.txtMother.Location = New System.Drawing.Point(5, 292)
		Me.txtMother.Name = "txtMother"
		Me.txtMother.Size = New System.Drawing.Size(191, 20)
		Me.txtMother.TabIndex = 20
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(48, 271)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 21
		Me.label10.Text = "Mother"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtFather
		'
		Me.txtFather.Location = New System.Drawing.Point(4, 330)
		Me.txtFather.Name = "txtFather"
		Me.txtFather.Size = New System.Drawing.Size(191, 20)
		Me.txtFather.TabIndex = 22
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(47, 309)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 23
		Me.label11.Text = "Father"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'BoarManagement
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(860, 539)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "BoarManagement"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "BoarManagement"
		AddHandler Load, AddressOf Me.BoarManagementLoad
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private label11 As System.Windows.Forms.Label
	Private txtFather As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private txtMother As System.Windows.Forms.TextBox
	Private cmbSource As System.Windows.Forms.ComboBox
	Private cmbBreed As System.Windows.Forms.ComboBox
	Private dTPBoarBirth As System.Windows.Forms.DateTimePicker
	Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
	Private printDocument1 As System.Drawing.Printing.PrintDocument
	Private printDialog1 As System.Windows.Forms.PrintDialog
	Private button2 As System.Windows.Forms.Button
	Private label5 As System.Windows.Forms.Label
	Private textBox6 As System.Windows.Forms.TextBox
	Private label9 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private textBox4 As System.Windows.Forms.TextBox
	Private btnAdd As System.Windows.Forms.Button
	Private btnDelete As System.Windows.Forms.Button
	Private btnUpdate As System.Windows.Forms.Button
	Private btnSearch As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private lblBoarID As System.Windows.Forms.Label
	Private textBox1 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private panel3 As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private panel1 As System.Windows.Forms.Panel
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private label4 As System.Windows.Forms.Label
	Public label1 As System.Windows.Forms.Label
	Public lblCurrentUser As System.Windows.Forms.Label
	
	
End Class
