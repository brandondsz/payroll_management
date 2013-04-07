Imports WindowsApplication1.search_emp
Imports WindowsApplication1.absent

Imports System.Data.OleDb
Public Class payslip
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub payslip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "C:\Users\Administrator\Documents\PAYROLL project\payroll\pay.accdb" ' Change it to your Access Database location
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        myConnection.Open()



        Dim str As String
        str = "SELECT * FROM gen WHERE (emp_id = '" & emp & "')"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        dr = cmd.ExecuteReader

        While dr.Read()
            Label19.Text = dr("name").ToString
            Label25.Text = dr("designation").ToString
            Label26.Text = dr("department").ToString

            Label28.Text = dr("payband").ToString
            Label29.Text = dr("A/C_no").ToString
            Label27.Text = emp
        End While
        Dim pyb As String
        Dim erng, bs, hs, cnv, chl, med, crmn, dys, inct As Integer
        pyb = Label28.Text
        str = "SELECT * FROM pay_info WHERE (payband = '" & pyb & "')"
        Dim cmd1 As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd1.ExecuteReader

        While dr.Read()
            Label32.Text = dr("base").ToString
            Label33.Text = dr("house_rent").ToString
            Label34.Text = dr("conv_allw").ToString
            Label35.Text = dr("child_ed").ToString
            Label36.Text = dr("medical").ToString
            bs = dr("base").ToString
            hs = dr("house_rent").ToString
            cnv = dr("conv_allw").ToString
            chl = dr("child_ed").ToString
            med = dr("medical").ToString
            inct = dr("incm_tx").ToString
        End While
        erng = bs + hs + cnv + chl + med
        Label37.Text = erng
        crmn = Today.Month

        If crmn = 1 Then
        dys = 31
        ElseIf crmn = 2 Then
            dys = 29
        ElseIf crmn = 3 Then
            dys = 31
        ElseIf crmn = 4 Then
            dys = 30
        ElseIf crmn = 5 Then
            dys = 31
        ElseIf crmn = 6 Then
            dys = 30
        ElseIf crmn = 7 Then
            dys = 31
        ElseIf crmn = 8 Then
            dys = 31
        ElseIf crmn = 9 Then
            dys = 30
        ElseIf crmn = 10 Then
            dys = 31
        ElseIf crmn = 11 Then
            dys = 30
        ElseIf crmn = 12 Then
            dys = 31
        End If


        Label40.Text = dys
        Label41.Text = absnt
        Label42.Text = dys - absnt
        Label38.Text = absnt * bs / dys
        Label39.Text = inct
        Dim ded As Integer
        ded = inct + absnt * bs / dys

        Label43.Text = ded
        Label44.Text = erng - ded


    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MsgBox(Now)
    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click

    End Sub
End Class