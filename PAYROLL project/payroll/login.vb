Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim usern As String, pass As String
        usern = "brandon"
        pass = "5011"
        If TextBox1.Text = usern And TextBox2.Text = pass Then
            wlcm.Show()
            Hide()
        Else
            MsgBox("Invalid username or password")
        End If






    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class