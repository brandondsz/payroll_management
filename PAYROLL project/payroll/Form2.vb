
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Public Class vpb
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
   

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\Administrator\Documents\PAYROLL project\payroll\pay.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        da = New OleDbDataAdapter("Select [payband], [base], [house_rent], [conv_allw], [medical], [incm_tx] from pay_info", myConnection)
        da.Fill(ds, "pay_info")
        ' replace "items" with the name of the table
        ' replace [Item Code], [Description], [Price] with the columns headers
        Dim view1 As New DataView(tables(0))
        Dim source1 As New BindingSource()
        source1.DataSource = view1
        DataGridView1.DataSource = view1
        DataGridView1.Refresh()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()

        editpy.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hide()
        wlcm.Show()

    End Sub
End Class