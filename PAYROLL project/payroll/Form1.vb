Imports Access = Microsoft.Office.Interop.Access
Imports System.Data

Imports WindowsApplication1.search_emp
Public Class absent
    
    Public Shared absnt As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        absnt = TextBox1.Text

        payslip.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Hide()
        search_emp.Show()

    End Sub

    Private Sub absent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class