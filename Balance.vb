Imports System.Data.OleDb
Imports System.Data
Public Class Balance
    Dim constr = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\mydbase.mdb"
    Dim adapt As New OleDbDataAdapter
    Dim conn As New OleDbConnection(constr)
    Dim dset As New DataSet
    Private Sub Balance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub linkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Me.Hide()
        Mainmenu.Show()

    End Sub
End Class