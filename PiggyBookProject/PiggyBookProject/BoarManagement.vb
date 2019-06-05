'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 4 Mar 2019
' Time: 1:05 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing


Public Partial Class BoarManagement
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
	
	Sub BoarManagementLoad(sender As Object, e As EventArgs)
		dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill
		loadData()
		loadBreed()
		loadSource()
	End Sub
	
	Sub loadData()
		
		Try
			db.connection.Open()
			db.query = "select * from boar"
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
	
	
	Sub loadSource
		Try
			db.connection.Open()
			db.query = "select * from source;"
			db.command = New OleDbCommand(db.query, db.connection)
			db.reader = db.command.ExecuteReader()
			
			While db.reader.Read()
				Dim items As String
				items = db.reader.GetString(1)
				cmbSource.Items.Add(items)
			End While
				
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	Sub loadBreed()
		Try
			db.connection.Open()
			db.query = "select * from breed;"
			db.command = New OleDbCommand(db.query, db.connection)
			db.reader = db.command.ExecuteReader()
			
			While db.reader.Read()
				Dim items As String
				items = db.reader.GetString(1)
				cmbBreed.Items.Add(items)
			End While
				
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	Sub DataGridView1CellClick(sender As Object, e As DataGridViewCellEventArgs)
		Try
			lblBoarID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString()
			textBox1.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString()
			dTPBoarBirth.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString()
			cmbBreed.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString()
			cmbSource.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString()
			textBox6.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub
	
	Sub BtnAddClick(sender As Object, e As EventArgs)
		If cmbSource.SelectedIndex = -1 Or cmbBreed.SelectedIndex = -1 Then
			MessageBox.Show("Please fill up the blank fields!")	
		Else
			Try
			db.connection.Open()
			db.query = "insert into boar (alyas,birthdate,breed,source,remarks) values (@alias,@bday,@breed,@source,@remarks);"
			db.command = New OleDbCommand(db.query,db.connection)
			db.command.Parameters.AddWithValue("@alias",textBox1.Text)
			db.command.Parameters.AddWithValue("@bday",dTPBoarBirth.Text)
			db.command.Parameters.AddWithValue("@breed",cmbBreed.Text)
			db.command.Parameters.AddWithValue("@source",cmbSource.Text)
			db.command.Parameters.AddWithValue("@remarks",textBox6.Text)
			db.command.ExecuteNonQuery()
			MessageBox.Show("Data Added!")
			db.connection.Close()
			loadData()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
		End If
		
		
	End Sub
	
	Sub BtnDeleteClick(sender As Object, e As EventArgs)
		'Try
		'	db.connection.Open()
			'db.query="delete from tbl_boar where boar_id = @id;"
			'db.command = New OleDbCommand(db.query,db.connection)
			'db.command.Parameters.AddWithValue("@id",lblBoarID.Text)
			'db.command.ExecuteNonQuery()
			'MessageBox.Show("Data deleted!")
			'db.connection.Close()
			'loadData()
		'Catch ex As Exception
			'MessageBox.Show(ex.Message)
			'db.connection.Close()
			'End Try
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
	
	Sub BtnUpdateClick(sender As Object, e As EventArgs)
		
		If cmbSource.SelectedIndex = -1 Or cmbBreed.SelectedIndex = -1 Then
			MessageBox.Show("Please fill up the blank fields!")	
		Else
			Try
			db.connection.Open()
			db.query = "update boar set alyas = @alias, birthdate = @bday, breed = @breed," & 
				"source = @source, remarks = @remarks where idboar = @id;"
			db.command = New OleDbCommand(db.query,db.connection)
			db.command.Parameters.AddWithValue("@alias",textBox1.Text)
			db.command.Parameters.AddWithValue("@bday",dTPBoarBirth.Text)
			db.command.Parameters.AddWithValue("@breed",cmbBreed.Text)
			db.command.Parameters.AddWithValue("@source",cmbSource.Text)
			db.command.Parameters.AddWithValue("@remarks",textBox6.Text)
			db.command.Parameters.AddWithValue("@id",lblBoarID.Text)
			db.command.ExecuteNonQuery()
			MessageBox.Show("Data Updated!")
			db.connection.Close()
			loadData()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
			
			
		End If
		
		
		
	End Sub
	
	Sub BtnSearchClick(sender As Object, e As EventArgs)
		Try
			db.connection.Open()
			db.query = "select * from boar where @id in (idboar);"
			db.command = new OleDbCommand(db.query, db.connection)
			db.command.Parameters.AddWithValue("@id",textBox4.Text)
			db.reader = db.command.ExecuteReader()
			If db.reader.HasRows Then
				Dim dt As New DataTable
				dt.Load(db.reader)
				dataGridView1.DataSource = dt
			End If
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			
			db.connection.Close()
		End Try
	End Sub
	
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		loadData()
	End Sub
	
	
	
	Sub Button2Click(sender As Object, e As EventArgs)
'		printPreviewDialog1.Document = printDocument1
'		printPreviewDialog1.PrintPreviewControl.Zoom = 1
'		printPreviewDialog1.ShowDialog()
	End Sub
	
	
	Sub PrintDocument1PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
		''Working
		'Dim dataGridViewImage As New Bitmap(Me.dataGridView1.Width, Me.dataGridView1.Height)
		'Dim font As New Font("Arial",16,FontStyle.Regular)
		
		'dataGridView1.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.dataGridView1.Width, Me.dataGridView1.Height))
		 
		 ''End Working
		''Working 
		'dataGridView1.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.dataGridView1.Width, Me.dataGridView1.Height))
		'e.Graphics.DrawString("Alyas: ",font, Brushes.Black, 50,8)
		'e.Graphics.DrawString(textBox1.Text,font, Brushes.Black, 120,8)
		
	'	e.Graphics.DrawString("Date: ",font, Brushes.Black, 50,50)
	'	e.Graphics.DrawString(textBox2.Text,font, Brushes.Black, 120,50)
		
	'	e.Graphics.DrawString("Breed: ",font, Brushes.Black, 350,8)
	'	e.Graphics.DrawString(textBox3.Text,font, Brushes.Black, 420,8)
		
	'	e.Graphics.DrawString("Source: ",font, Brushes.Black, 350,50)
	'	e.Graphics.DrawString(textBox5.Text,font, Brushes.Black, 430,50)
		
		
		'	e.Graphics.DrawImage(dataGridViewImage, 50, 50)
	'	e.Graphics.DrawImage(dataGridViewImage, 100, 100)
	''End Working
	End Sub
End Class
