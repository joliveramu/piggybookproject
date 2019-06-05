'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 11 Jan 2019
' Time: 2:28 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainMenu
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnLogoutClick(sender As Object, e As EventArgs)
		Dim loginform As New MainForm
		loginform.Show()
		Me.Hide()
		
	End Sub
	
	Sub BtnProfileClick(sender As Object, e As EventArgs)
		Dim myProfile As New MyProfile
		myProfile.Show()
		myProfile.lblProfileUser.Text = Me.lblCurrentUser.Text
		Me.Hide()
		
	End Sub
	
	Sub BtnPiggeryManagementClick(sender As Object, e As EventArgs)
		Dim boarManagement As New BoarManagement
		boarManagement.Show()
		boarManagement.lblCurrentUser.Text = Me.lblCurrentUser.Text
		Me.Hide()
	End Sub
	
	Sub BtnSowManagementClick(sender As Object, e As EventArgs)
		Dim sowManagement As New SowManagement
		sowManagement.Show()
		sowManagement.lblCurrentUser.Text = Me.lblCurrentUser.Text
		Me.Hide()
	End Sub
	
	Sub BtnFattenerManagementClick(sender As Object, e As EventArgs)
		Dim fattenerManagerment As New FattenerManagement
		fattenerManagerment.Show()
		fattenerManagerment.lblCurrentUser.Text = Me.lblCurrentUser.Text
		Me.Hide()
	End Sub
	
	
	
	Sub BtnSowHistoryClick(sender As Object, e As EventArgs)
		Dim sowHistory As New SowHistory
		sowHistory.Show()
		sowHistory.lblCurrentUser.Text = Me.lblCurrentUser.Text
		Me.Hide()
	End Sub
End Class
