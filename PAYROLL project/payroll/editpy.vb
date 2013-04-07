Imports Access = Microsoft.Office.Interop.Access
Imports System.Data
Imports System.Data.OleDb
Public Class editpy
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub editpy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\Administrator\Documents\PAYROLL project\payroll\pay.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "update [pay_info] set [base] = '" & TextBox1.Text & "' , [house_rent] = '" & TextBox2.Text & "', [conv_allw] = '" & TextBox3.Text & "', [child_ed] = '" & TextBox4.Text & "' , [medical] = '" & TextBox5.Text & "' , [incm_tx] = '" & TextBox6.Text & "' Where [payband] = '" & ComboBox1.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

        MsgBox("Changes saved to database")
        Hide()
        wlcm.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hide()

        wlcm.Show()

    End Sub
End Class