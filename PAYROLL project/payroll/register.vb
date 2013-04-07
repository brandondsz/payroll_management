
Imports Access = Microsoft.Office.Interop.Access
Imports System.Data
Imports System.Data.OleDb
Public Class register
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hide()
        wlcm.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\Administrator\Documents\PAYROLL project\payroll\pay.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()
        Dim str As String
        str = "insert into gen ([emp_id], [name], [designation], [department], [A/C_no],[payband]) values (?, ?, ?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("emp_id", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("name", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("designation", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("department", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A/C_no", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("payband", CType(TextBox5.Text, String)))

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

        MsgBox("New employee regestered")
        wlcm.Show()

    End Sub
End Class