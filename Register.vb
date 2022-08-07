Imports System.Data.OleDb
Imports System.Data
Public Class Register
    Dim constr = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\db1.mdb"
    Dim adapt, adapt1 As New OleDbDataAdapter
    Dim conn As New OleDbConnection(constr)
    Dim dset As New DataSet
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtAcctName.Text = "" And txtAcctNo.Text = "" And txtAddress.Text = "" And txtContact.Text = "" And txtName.Text = "" Or TextBox1.Text = "" Then
            lblError.Text = "Input all Fields"
        ElseIf txtAcctName.Text = "" Or txtAcctNo.Text = "" Or txtAddress.Text = "" Or txtContact.Text = "" Or txtName.Text = "" Or TextBox1.Text = "" Then
            lblError.Text = "Input all Fields"
        ElseIf TextBox1.Text <> txtAcctNo.Text Then
            lblAccNo.Text = "Account number not match"
        Else
            Dim adapt1 As New OleDbDataAdapter("select * from AccountInfo where AccountName='" & txtAcctName.Text & "'", conn)
            Dim dset1 As New DataSet()
            adapt1.Fill(dset1)
            If dset1.Tables(0).Rows.Count <> 0 Then
                lblAccNo.Text = "Account name already exist"
            Else
                Dim dbcommand As String = "INSERT into AccountInfo (AccountNo, AccountName, UName, Address, ContactNo, Balance)" & " VALUES ('" & txtAcctNo.Text + "','" & txtAcctName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtContact.Text & "','" & 10000 & "')"
                Dim adapt As New OleDbDataAdapter(dbcommand, conn)
                Dim dset As New DataSet()
                adapt.Fill(dset)
                MsgBox("You Have Succesfully Registered!")
                Me.Hide()
                LogIn.Show()
            End If
        End If
    End Sub
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = constr
        conn.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        LogIn.Show()
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

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

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Delete) OrElse e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Delete) OrElse e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged

    End Sub
End Class