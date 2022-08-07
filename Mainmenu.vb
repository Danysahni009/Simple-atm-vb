Imports System.Data.OleDb
Imports System.Data
Public Class Mainmenu
    Dim constr = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\db1.mdb"
    Dim adapt As New OleDbDataAdapter
    Dim conn As New OleDbConnection(constr)
    Dim dset As New DataSet
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTime.Text = Date.Now
        Dim adapt1 As New OleDbDataAdapter("select * from AccountInfo where AccountNo = '" + txtHidden.Text + "'", conn)
        Dim dset1 As New DataSet()
        adapt1.Fill(dset1)
        lblName.Text = dset1.Tables(0).Rows(0)(2).ToString()
    End Sub
    Private Sub btnBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBal.Click
        Dim adapt1 As New OleDbDataAdapter("select * from AccountInfo where AccountNo = '" + txtHidden.Text + "'", conn)
        Dim dset1 As New DataSet()
        adapt1.Fill(dset1)
        Balance.txtAcctName.Text = dset1.Tables(0).Rows(0)(1).ToString()
        Balance.txtBalance.Text = dset1.Tables(0).Rows(0)(5).ToString()
        Balance.txtHidden.Text = txtHidden.Text
        Balance.Show()
        Me.Hide()
    End Sub

    Private Sub btnDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDep.Click
        Deposit.txtAmount.Text = ""
        Deposit.txtHidden.Text = txtHidden.Text
        Deposit.Show()
        
        Me.Hide()
    End Sub

    Private Sub btnWith_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWith.Click
        Withdraw.txtAmount.Text = ""
        Withdraw.txtHidden.Text = txtHidden.Text
        Withdraw.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click


    End Sub
End Class