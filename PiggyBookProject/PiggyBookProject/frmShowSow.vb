'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 12/03/2019
' Time: 12:41 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing

Public Partial Class frmShowSow
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Dim db As New DatabaseHelper
	
	Sub FrmShowSowLoad(sender As Object, e As EventArgs)
		loadBoarId()
		loadData()
		lblSowID.Text = Me.textID.Text
	End Sub
	
	Sub loadData()	
		Try
			Dim sHistory As New SowHistory
			db.connection.Open()
			'db.query = "Select sowlist.*, sowhistory.* from sowlist inner join sowhistory on sowhistory.pigcode = sowlist.pigcode where sowhistory.pigcode = " & Integer.Parse(Me.textID.Text) 
			db.query = "select status, idsowhistory, datecaste, born, liveborn, mummified, stillborn, idboar, pigletbirthdate, deaths, datewean, natai from sowlist inner join sowhistory on sowhistory.pigcode = sowlist.pigcode where sowhistory.pigcode = " & Integer.Parse(Me.textID.Text)
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
	
	
	
	Sub BtnCloseClick(sender As Object, e As EventArgs)
		Dim showSowHistory As New SowHistory
		db.connection.Close()
		Me.Hide()
		showSowHistory.lblCurrentUser.Text = Me.lblCurrentUser.Text
		showSowHistory.Show()
	End Sub
	
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		If cmbNatai.SelectedIndex = -1 Or cmbBoarID.SelectedIndex = -1 Then
			MessageBox.Show("Please fill up the blank fields!")	
		Else
			Try
				db.connection.Open()
				db.query = "INSERT INTO sowhistory(pigcode,datecaste,born,liveborn,mummified,stillborn,"
				db.query += "idboar,pigletbirthdate,deaths,datewean,natai)"
				db.query += "VALUES(@pigcode,@dcaste,@born,@lborn, @mumm, @stillborn,"
				db.query += "@boarid,@pigdob,@deaths,@datewean,@natai);"
				db.command = New OleDbCommand(db.query, db.connection)
				
				db.command.Parameters.AddWithValue("@pigcode",Me.textID.Text)
				db.command.Parameters.AddWithValue("@dcaste",Me.dtpDateCaste.Text)
				db.command.Parameters.AddWithValue("@born",Me.txtBorn.Text)
				db.command.Parameters.AddWithValue("@lborn",Me.txtLiveBorn.Text)
				db.command.Parameters.AddWithValue("@mumm",Me.txtMummified.Text)
				db.command.Parameters.AddWithValue("@stillborn",Me.txtStillBorn.Text)
				
				db.command.Parameters.AddWithValue("@boarid",Me.cmbBoarID.Text)
				db.command.Parameters.AddWithValue("@pigdob",Me.dtpPigDOB.Text)
				db.command.Parameters.AddWithValue("@deaths", Me.txtDeath.Text)
				db.command.Parameters.AddWithValue("@datewean",Me.dtpWeanDate.Text)
				db.command.Parameters.AddWithValue("@natai",Me.cmbNatai.Text)
				
				db.command.ExecuteNonQuery()
				MessageBox.Show("New record added for Sow ID "+Me.textID.Text)
				
				db.connection.Close()
				loadData()
				clearFields()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
		End If
		
	End Sub
	
	Sub loadBoarId()
		Try
			db.connection.Open()
			db.query = "select * from boar"
			db.command = New OleDbCommand(db.query, db.connection)
			db.reader = db.command.ExecuteReader()
			
			If db.reader.HasRows Then
				While db.reader.Read()
					cmbBoarID.Items.Add(db.reader("idboar"))
				End While
			End If
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	End Sub
	
		Sub clearFields()
			cmbNatai.SelectedIndex = -1
			cmbBoarID.SelectedIndex = - 1
			txtBorn.Text = Nothing
			txtDeath.Text = Nothing
			txtLiveBorn.Text = Nothing
			txtMummified.Text = Nothing
			txtStillBorn.Text = Nothing
			dtpDateCaste.Value = DateTime.Now.ToString("yyyy/MM/dd")
			dtpPigDOB.Value = DateTime.Now.ToString("yyyy/MM/dd")
			dtpWeanDate.Value = DateTime.Now.ToString("yyyy/MM/dd")
	End Sub
End Class
