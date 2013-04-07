Imports System.Data.OleDb
Public Class search_emp
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public Shared emp As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\Administrator\Documents\PAYROLL project\payroll\pay.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub search_emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Hide()
        wlcm.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myConnection.Open()
       
        emp = TextBox3.Text

        Dim str As String
        str = "SELECT * FROM gen WHERE (emp_id = '" & TextBox3.Text & "')"

        Dim cmd As OleDbCommand = New OleDbCommand(Str, myConnection)

        dr = cmd.ExecuteReader

        While dr.Read()
            Label11.Text = dr("name").ToString
            Label12.Text = dr("designation").ToString
            Label13.Text = dr("department").ToString

        End While
        dr.Close()
        myConnection.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Hide()

        absent.Show()





    End Sub
End Class