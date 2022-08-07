Imports System.Data.OleDb
Imports System.Data
Public Class Withdraw
    Dim constr = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\db1.mdb"
    Dim adapt As New OleDbDataAdapter
    Dim conn As New OleDbConnection(constr)
    Dim dset As New DataSet
    Dim x, total As Integer
    Dim bal, num As String
    Private Sub Withdraw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call draw()
        txtAcctName.Enabled = False
    End Sub
    Function draw()
        Dim adapt1 As New OleDbDataAdapter("select * from AccountInfo where AccountNo = '" + txtHidden.Text + "'", conn)
        Dim dset1 As New DataSet()
        adapt1.Fill(dset1)
        bal = dset1.Tables(0).Rows(0)(5).ToString()
        num = dset1.Tables(0).Rows(0)(0).ToString()
        txtAcctName.Text = dset1.Tables(0).Rows(0)(1).ToString()
        Return 0
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        x = txtAmount.Text Mod 100
        If bal < Val(txtAmount.Text) Then
            lblError.Text = "Insufficient Balance"
        ElseIf txtAcctNo.Text = "" Or txtAmount.Text = "" Then
            lblError.Text = "Please input all fields"
        ElseIf x <> "00" Then
            lblError.Text = "Invalid Amount"
        ElseIf txtAmount.Text < 200 Then
            lblError.Text = "Not less than 200"
        ElseIf txtAcctNo.Text <> num Then
            lblError.Text = "Invalid Account Number"
        Else
            total = bal - Val(txtAmount.Text)
            Dim dbcommand As String = "update AccountInfo set Balance = '" & total & "'where AccountName='" & txtAcctName.Text & "'"
            adapt = New OleDbDataAdapter(dbcommand, conn)
            dset = New DataSet
            adapt.Fill(dset)
            MsgBox("Transaction Success.")
            Call draw()
            Me.Close()
            Mainmenu.Show()
        End If
    End Sub

    Private Sub linkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel2.LinkClicked
        Me.Close()
        Mainmenu.Show()
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

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ChrW(Keys.Delete) OrElse e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged

    End Sub
End Class