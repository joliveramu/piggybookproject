'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 11 Jan 2019
' Time: 2:00 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data.OleDb
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	Dim db As New DatabaseHelper
	Sub Button1Click(sender As Object, e As EventArgs)
		Try
			db.connection.Open()
			db.query = "select count(*) as num from tbl_user where username = @user and password = @pass"
			db.command = New OleDbCommand(db.query, db.connection)
			db.command.Parameters.AddWithValue("@user",txtUsername.Text)
			db.command.Parameters.AddWithValue("@pass",txtPassword.Text)
			
			Dim count As Int32
			count = db.command.ExecuteScalar()
			
			If count = 1 Then
				MessageBox.Show("You may now log in!")
				db.connection.Close()
				Me.Hide
				Dim mainmenu As New MainMenu
				mainmenu.Show()
				mainmenu.lblCurrentUser.Text = Me.txtUsername.Text
			Else
				MessageBox.Show("You have entered an invalid user credential!")
				db.connection.Close()
			End If
			
			
			db.connection.Close()
		Catch ex As Exception
				
		End Try
	End Sub
	
	Sub Label4Click(sender As Object, e As EventArgs)
		System.Environment.Exit(0)		
	End Sub
End Class
