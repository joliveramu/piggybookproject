'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 11 Jan 2019
' Time: 2:56 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data.OleDb
Public Partial Class MyProfile
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Dim db As New DatabaseHelper
	Dim mainMenu As New MainMenu
	Sub BtnUpdateClick(sender As Object, e As EventArgs)
		If txtPassword1.Text = Nothing Or txtPassword2.Text = Nothing Then
			MessageBox.Show("You cannot leave fields blank!")
		Else
			If txtPassword1.Text.Equals(txtPassword2.Text) Then
				Try
					db.connection.Open()
					db.query= "update tbl_user set [password] = @password where [username] = @username;"
					db.command = New OleDbCommand(db.query, db.connection)
					db.command.Parameters.AddWithValue("@password",txtPassword1.Text)
					db.command.Parameters.AddWithValue("@username",lblProfileUser.Text)
					db.command.ExecuteNonQuery()
					MessageBox.Show("Updated!")
					db.connection.Close()
					mainMenu.Show()
					mainMenu.lblCurrentUser.Text = Me.lblProfileUser.Text
					Me.Hide()
				Catch ex As Exception
					MessageBox.Show(ex.Message)
					db.connection.Close()
				End Try
			
			Else
				MessageBox.Show("Password not match!")	
			End If
			
		End If
		
	End Sub
	
	Sub Label4Click(sender As Object, e As EventArgs)
		Try
			mainMenu.Show()
			mainMenu.lblCurrentUser.Text = Me.lblProfileUser.Text
			Me.Hide()
			db.connection.Close()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			db.connection.Close()
		End Try
	
		
	End Sub
End Class
