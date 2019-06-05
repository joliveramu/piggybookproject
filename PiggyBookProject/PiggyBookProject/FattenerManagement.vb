'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 4 Mar 2019
' Time: 1:27 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.OleDb

Public Partial Class FattenerManagement
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
			db.query = "select * from tbl_fatteners"
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
	
	Sub FattenerManagementLoad(sender As Object, e As EventArgs)
		loadData()
	End Sub
	
	Sub DataGridView1CellClick(sender As Object, e As DataGridViewCellEventArgs)
		Try
			lblFattenerID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
			textBox1.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
			textBox2.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
			textBox3.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
			textBox4.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
			textBox5.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
			textBox6.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
			textBox7.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
			textBox8.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub
	
	Sub BtnAddClick(sender As Object, e As EventArgs)
		Try
			db.connection.Open()
			db.query = "INSERT INTO tbl_fatteners (date_weaned,batch_no,date_born,quantity,sow_code,boar,num_of_death,cause_of_death) values "&
				"(@date_weaned,@batch,@born,@quantity,@sow_code,@boar,@death,@cause_of_death)"
			db.command = New OleDbCommand(db.query,db.connection)	
			db.command.Parameters.AddWithValue("@date_weaned",textBox1.Text)
			db.command.Parameters.AddWithValue("@batch",textBox2.Text)
			db.command.Parameters.AddWithValue("@born",textBox3.Text)
			db.command.Parameters.AddWithValue("@quantity",textBox4.Text)
			db.command.Parameters.AddWithValue("@sow_code",textBox5.Text)
			db.command.Parameters.AddWithValue("@boar",textBox6.Text)
			db.command.Parameters.AddWithValue("@death",textBox7.Text)
			db.command.Parameters.AddWithValue("@cause_of_death",textBox8.Text)
			db.command.ExecuteNonQuery()
			MessageBox.Show("Data Added!")
			db.connection.Close()
			loadData()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	Sub BtnUpdateClick(sender As Object, e As EventArgs)
		Try
			db.connection.Open()
			db.query = "update tbl_fatteners set date_weaned = @dw, batch_no = @bn, date_born = @db, quantity = @q,"&
				"sow_code = @sc, boar = @b, num_of_death = @death, cause_of_death=@cod where fattener_id = @id;"
			db.command = New OleDbCommand(db.query,db.connection)
			db.command.Parameters.AddWithValue("@dw",textBox1.Text)
			db.command.Parameters.AddWithValue("@bn",textBox2.Text)
			db.command.Parameters.AddWithValue("@db",textBox3.Text)
			db.command.Parameters.AddWithValue("@q",textBox4.Text)
			db.command.Parameters.AddWithValue("@sc",textBox5.Text)
			db.command.Parameters.AddWithValue("@b",textBox6.Text)
			db.command.Parameters.AddWithValue("@death",textBox7.Text)
			db.command.Parameters.AddWithValue("@cod",textBox8.Text)
			db.command.Parameters.AddWithValue("@id",lblFattenerID.Text)
			db.command.ExecuteNonQuery()
			MessageBox.Show("Data Updated!")
			db.connection.Close()
			loadData()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
	Sub BtnDeleteClick(sender As Object, e As EventArgs)
		'Try
			'db.connection.Open()
			'db.query = "delete from tbl_fatteners where fattener_id = @id"
			'db.command = New OleDbCommand(db.query, db.connection)
			'db.command.Parameters.AddWithValue("@id",lblFattenerID.Text)
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
	
	Sub BtnSearch1Click(sender As Object, e As EventArgs)
		Try
			db.connection.Open()
			db.query = "select * from tbl_fatteners where fattener_id = " & Integer.Parse(textBox11.Text) &" "
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
	
	Sub Button1Click(sender As Object, e As EventArgs)
		loadData()
	End Sub
End Class
