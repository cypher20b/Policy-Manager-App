Imports System.Data.OleDb

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=D:Db.accdb")
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "qry_Renewal_List"
        cmd.Parameters.Add("@Parameter1", OleDbType.VarChar).Value = "value1"  ' Add Parameter
        cmd.Connection = con
        con.Open()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, "Table1")
        DataGridView1.DataSource = ds.Tables("Table1")  ' Binding to DataGridView   
        con.Close()
    End Sub

End Class
