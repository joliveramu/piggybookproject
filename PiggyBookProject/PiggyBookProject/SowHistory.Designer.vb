'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 7 Mar 2019
' Time: 1:14 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class SowHistory
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SowHistory))
		Me.lblCurrentUser = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.button1 = New System.Windows.Forms.Button()
		Me.txtSearch = New System.Windows.Forms.TextBox()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.printDialog1 = New System.Windows.Forms.PrintDialog()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label4 = New System.Windows.Forms.Label()
		Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
		Me.panel3.SuspendLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.panel1.SuspendLayout
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
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(977, 7)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 16
		Me.button2.Text = "View Report"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.OldLace
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel3.Controls.Add(Me.button2)
		Me.panel3.Controls.Add(Me.button1)
		Me.panel3.Controls.Add(Me.txtSearch)
		Me.panel3.Controls.Add(Me.btnSearch)
		Me.panel3.Controls.Add(Me.dataGridView1)
		Me.panel3.Location = New System.Drawing.Point(9, 112)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(1057, 404)
		Me.panel3.TabIndex = 16
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
		'txtSearch
		'
		Me.txtSearch.Location = New System.Drawing.Point(8, 11)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(191, 20)
		Me.txtSearch.TabIndex = 14
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
		'dataGridView1
		'
		Me.dataGridView1.AllowUserToAddRows = false
		Me.dataGridView1.AllowUserToDeleteRows = false
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(5, 46)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.ReadOnly = true
		Me.dataGridView1.Size = New System.Drawing.Size(1047, 353)
		Me.dataGridView1.TabIndex = 0
		AddHandler Me.dataGridView1.CellClick, AddressOf Me.DataGridView1CellClick
		'
		'printDocument1
		'
		AddHandler Me.printDocument1.PrintPage, AddressOf Me.PrintDocument1PrintPage
		'
		'printDialog1
		'
		Me.printDialog1.UseEXDialog = true
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(165, 36)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(344, 52)
		Me.label2.TabIndex = 9
		Me.label2.Text = "Sow History"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(165, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(87, 23)
		Me.label1.TabIndex = 7
		Me.label1.Text = "Logged as: "
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
		Me.panel1.Size = New System.Drawing.Size(1077, 100)
		Me.panel1.TabIndex = 14
		'
		'label4
		'
		Me.label4.BackColor = System.Drawing.Color.OldLace
		Me.label4.Cursor = System.Windows.Forms.Cursors.Hand
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(972, 8)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 8
		Me.label4.Text = "Close"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		AddHandler Me.label4.Click, AddressOf Me.Label4Click
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
		'SowHistory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.ClientSize = New System.Drawing.Size(1074, 520)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "SowHistory"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SowHistory"
		AddHandler Load, AddressOf Me.SowHistoryLoad
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.panel1.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
	Private label4 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Public label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private printDialog1 As System.Windows.Forms.PrintDialog
	Private printDocument1 As System.Drawing.Printing.PrintDocument
	Public dataGridView1 As System.Windows.Forms.DataGridView
	Private btnSearch As System.Windows.Forms.Button
	Private txtSearch As System.Windows.Forms.TextBox
	Private button1 As System.Windows.Forms.Button
	Private panel3 As System.Windows.Forms.Panel
	Private button2 As System.Windows.Forms.Button
	Public lblCurrentUser As System.Windows.Forms.Label
End Class
