'
' Created by SharpDevelop.
' User: John Oliver Amurao
' Date: 11 Jan 2019
' Time: 2:05 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.Data.OleDb
Public Class DatabaseHelper
	Public Property connection As New OleDbConnection("Provider=MICROSOFT.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\piggerydata.mdb")
	Public Property reader As OleDbDataReader
	Public Property adapter As OleDbDataAdapter
	Public Property command As OleDbCommand
	Public Property query As String	
		
End Class
