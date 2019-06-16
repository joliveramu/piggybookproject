'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 4 Mar 2019
' Time: 3:59 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.OleDb

Public Partial Class SowManagement
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
	
	Sub SowManagementLoad(sender As Object, e As EventArgs)
		loadData()		
		loadBreed()
		loadSource()
		loadStatus()
		displayLatestCount()
	End Sub
	
	Sub DataGridView1CellClick(sender As Object, e As DataGridViewCellEventArgs)
		'If cmbSource.SelectedIndex = -1 Or cmbBreed.SelectedIndex = -1 Then
		'	MessageBox.Show("Please fill up the blank fields!")	
		'Else
			Try
			lblSowID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString()
			textBox1.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString()
			cmbBreed.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString()
			dTPBirth.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString()
			dTPAcquired.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString()
			txtKilos.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString()
			cmbType.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value.ToString()
			cmbSource.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value.ToString()
			cmbStatus.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value.ToString()
			'dTPCulled.Text = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value.ToString()
			textBox9.Text = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value.ToString()
			txtMother.Text = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value.ToString()
			txtFather.Text = DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value.ToString()
			textBox10.Text = DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value.ToString()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		'End If
		
	End Sub
	
	Sub BtnAddClick(sender As Object, e As EventArgs)
		If cmbSource.SelectedIndex = -1 Or cmbBreed.SelectedIndex = -1 Or cmbType.SelectedIndex = -1 Then
			MessageBox.Show("Please fill up the blank fields!")	
		Else
			Try
			db.connection.Open()
			db.query = "INSERT INTO sowlist (alyas,breed,birthdate,dateacquired,type,source,status,kilo_acquired,owner,remarks,mother,father) values "&
				"(@alias,@breed,@birth_date,@date_acquired,@type,@source,@status,@kilos,@owner,@remarks,@mther,@fther)"
			db.command = New OleDbCommand(db.query,db.connection)	
			db.command.Parameters.AddWithValue("@alias",textBox1.Text)
			db.command.Parameters.AddWithValue("@breed", cmbBreed.Text)
			db.command.Parameters.AddWithValue("@birth_date",dTPBirth.Text)
			db.command.Parameters.AddWithValue("@date_acquired",dTPAcquired.Text)
			db.command.Parameters.AddWithValue("@type",cmbType.Text)
			db.command.Parameters.AddWithValue("@source",cmbSource.Text)
			db.command.Parameters.AddWithValue("@status",cmbStatus.Text)
			db.command.Parameters.AddWithValue("@kilos", txtKilos.Text)
			db.command.Parameters.AddWithValue("@owner",textBox9.Text)
			db.command.Parameters.AddWithValue("@remarks",textBox10.Text)
			db.command.Parameters.AddWithValue("@mther",txtMother.Text)
			db.command.Parameters.AddWithValue("@fther",txtFather.Text)
			db.command.ExecuteNonQuery()
			MessageBox.Show("Data Added!")
			db.connection.Close()
			clearFields()
			loadData()
			displayLatestCount()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
		End If
	End Sub
	
	Sub BtnDeleteClick(sender As Object, e As EventArgs)	
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
	
	Sub loadStatus
		Try
			db.connection.Open()
			db.query = "select * from sowstatus;"
			db.command = New OleDbCommand(db.query, db.connection)
			db.reader = db.command.ExecuteReader()
			
			While db.reader.Read()
				Dim items As String
				items = db.reader.GetString(1)
				cmbStatus.Items.Add(items)
			End While
				
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
	
	Sub BtnUpdateClick(sender As Object, e As EventArgs)
		If cmbSource.SelectedIndex = -1 Or cmbBreed.SelectedIndex = -1 Then
			MessageBox.Show("Please fill up the blank fields!")	
		Else
		Try
			db.connection.Open()
			db.query = "update sowlist set alyas = @alias, breed = @breed, birthdate = @birth_date, " & 
				"dateacquired = @date_acquired, type = @type, source = @source, status = @status,"&
				"kilo_acquired = @kilos, owner = @owner, remarks = @remarks, mother = @mother," &
			   " father = @father where pigcode = @id;"
			db.command = New OleDbCommand(db.query,db.connection)	
			db.command.Parameters.AddWithValue("@alias",textBox1.Text)
			db.command.Parameters.AddWithValue("@breed",cmbBreed.Text)
			db.command.Parameters.AddWithValue("@birth_date",dTPBirth.Text)
			db.command.Parameters.AddWithValue("@date_acquired",dTPAcquired.Text)
			db.command.Parameters.AddWithValue("@type",cmbType.Text)
			db.command.Parameters.AddWithValue("@source",cmbSource.Text)
			db.command.Parameters.AddWithValue("@status",cmbStatus.Text)
			db.command.Parameters.AddWithValue("@kilos", txtKilos.Text)
			db.command.Parameters.AddWithValue("@owner",textBox9.Text)
			db.command.Parameters.AddWithValue("@remarks",textBox10.Text)
			db.command.Parameters.AddWithValue("@",txtMother.Text)
			db.command.Parameters.AddWithValue("@father",txtFather.Text)			
			db.command.Parameters.AddWithValue("@id",lblSowID.Text)
			db.command.ExecuteNonQuery()
			MessageBox.Show("Data Updated!")
			clearFields()
			db.connection.Close()
			loadData()
			displayLatestCount()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
		End If
		
	End Sub
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		loadData()
		textBox11.Clear()
	End Sub
	
	Sub BtnSearch1Click(sender As Object, e As EventArgs)
		Try
			db.connection.Open()
			'db.query = "select * from sowlist where sow_id = " & Integer.Parse(textBox11.Text) & " "
			'Dim adapter As New OleDbDataAdapter(db.query, db.connection)
			'Dim dt As New DataTable
			'adapter.Fill(dt)
			'dataGridView1.DataSource = dt
			db.query = "SELECT * from sowlist WHERE  @id in (pigcode);"
			db.command = New OleDbCommand(db.query,db.connection)
			db.command.Parameters.AddWithValue("@id",textBox11.Text)
			db.reader = db.command.ExecuteReader()
			If db.reader.HasRows Then
				Dim dt As New DataTable
				dt.Load(db.reader)
				dataGridView1.DataSource = dt
			Else
				MessageBox.Show("We cannot find that")
			End If
				
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	Sub displayLatestCount()
		Try
			db.connection.Open()
			db.query = "select count(*) + 1 from sowlist"
			db.command = New OleDbCommand(db.query, db.connection)
			
			lblSowID.Text 	= db.command.ExecuteScalar.ToString()
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	Sub CmbTypeKeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = True
	End Sub
	
	Sub CmbBreedKeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = True
	End Sub
	
	Sub CmbSourceKeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = True
	End Sub
	
	Sub CmbStatusKeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = True
	End Sub
	
	Sub clearFields()
		textBox1.Text = Nothing
		txtFather.Text = Nothing
		txtMother.Text = Nothing
		txtKilos.Text = Nothing
		textBox9.Text = Nothing
		textBox10.Text = Nothing
		textBox11.Text = Nothing
		cmbBreed.SelectedIndex = -1
		cmbSource.SelectedIndex = -1
		cmbStatus.SelectedIndex = -1
		cmbType.SelectedIndex = -1
		dTPAcquired.Value = DateTime.Now.ToString("yyyy/MM/dd")
		dTPBirth.Value = DateTime.Now.ToString("yyyy/MM/dd")
	End Sub
End Class
