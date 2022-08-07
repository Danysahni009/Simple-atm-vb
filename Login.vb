Imports System.Data.OleDb
Imports System.Data
Public Class LogIn
    Dim constr = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\db1.mdb"
    Dim adapt As New OleDbDataAdapter
    Dim conn As New OleDbConnection(constr)
    Dim dset As New DataSet
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = constr
        conn.Open()
    End Sub
    Private Sub llblRegister_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblRegister.LinkClicked
        Me.Hide()
        Register.Show()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        adapt = New OleDbDataAdapter("Select * from AccountInfo Where AccountName='" & txtAcctName.Text & "' and AccountNo='" & txtAcctNo.Text & "'", conn)
        dset = New DataSet
        adapt.Fill(dset)
        If Not dset.Tables(0).Rows.Count = 0 Then
            Me.Hide()
            Mainmenu.txtHidden.Text = txtAcctNo.Text
            Mainmenu.Show()
            lblError.Text = ""
        Else
            MsgBox("Incorrect Username or Password")
        End If
    End Sub

    Private Sub txtAcctNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAcctNo.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Delete) OrElse e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAcctNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcctNo.TextChanged

    End Sub
End Class
