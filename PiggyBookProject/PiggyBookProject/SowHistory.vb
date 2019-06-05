'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 7 Mar 2019
' Time: 1:14 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing

Public Partial Class SowHistory
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Dim db As New DatabaseHelper
	Dim mainMenu As New MainMenu
	
	Sub Label4Click(sender As Object, e As EventArgs)
			Try
			mainMenu.Show()
			mainMenu.lblCurrentUser.Text = Me.lblCurrentUser.Text
			Me.Hide()
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	Sub loadData()
		
		Try
			db.connection.Open()
			db.query = "select * from sowlist"
			Dim adapter As New OleDbDataAdapter(db.query, db.connection)
			Dim dt As New DataTable
			adapter.Fill(dt)
			dataGridView1.DataSource = dt
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	
	Sub SowHistoryLoad(sender As Object, e As EventArgs)
		dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		loadData()
	End Sub
	
	
	
	Sub DataGridView1CellClick(sender As Object, e As DataGridViewCellEventArgs)
		Try
			'lblHistoryID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
			'textBox1.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
			'textBox2.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
			'textBox3.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
			'textBox4.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
			'textBox5.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
			'textBox6.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
			'textBox7.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
			'textBox8.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
			Dim showSow As New frmShowSow
			showSow.textID.Text = Convert.ToInt32(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
			showSow.Show()
			Me.Hide()
			db.connection.Close()
			
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		printPreviewDialog1.Document = printDocument1
		PrintDocument1.DefaultPageSettings.Landscape = True
		printPreviewDialog1.PrintPreviewControl.Zoom = 1
		printPreviewDialog1.ShowDialog()
	End Sub
	
	Sub PrintDocument1PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
		Dim dataGridViewImage As New Bitmap(Me.dataGridView1.Width, Me.dataGridView1.Height)
		Dim font As New Font("Arial",16,FontStyle.Regular)
		
		dataGridView1.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.dataGridView1.Width, Me.dataGridView1.Height))
		e.Graphics.DrawString("Pig Code: ",font, Brushes.Black, 50,8)
		'e.Graphics.DrawString(textBox1.Text,font, Brushes.Black, 150,8)
		
		e.Graphics.DrawString("Date Caste: ",font, Brushes.Black, 50,50)
		'e.Graphics.DrawString(textBox2.Text,font, Brushes.Black, 170,50)
		
		e.Graphics.DrawString("Date of Birth: ",font, Brushes.Black, 350,8)
		'e.Graphics.DrawString(textBox7.Text,font, Brushes.Black, 485,8)
		
		e.Graphics.DrawString("Remarks: ",font, Brushes.Black, 350,50)
		'e.Graphics.DrawString(textBox8.Text,font, Brushes.Black, 450,50)
		e.Graphics.DrawImage(dataGridViewImage, 125, 100)
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		txtSearch.Clear()
		loadData()
	End Sub
	
	Sub BtnSearchClick(sender As Object, e As EventArgs)
		dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		Try
			db.connection.Open()
			db.query = "select * from sowlist where " & txtSearch.Text &" in (pigcode)"
			Dim adapter As New OleDbDataAdapter(db.query, db.connection)
			Dim dt As New DataTable
			adapter.Fill(dt)
			dataGridView1.DataSource = dt
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try		
	End Sub
End Class
