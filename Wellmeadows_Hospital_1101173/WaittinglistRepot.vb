Imports Microsoft.Reporting.WinForms
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SqlClient

Public Class WaittinglistRepot
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub


    Private Sub SetReport(where)
        Me.ReportViewer1.Clear()
        Dim sql As String = $"SELECT * FROM WATTING_BED {where}"
        Debug.Write(sql)
        Dim oracleDataAdapter As New OracleDataAdapter(sql, Connect())
        Dim dataSet As New DataSet()
        oracleDataAdapter.Fill(dataSet)

        Dim rprtDS1 As New ReportDataSource("DataSet1", dataSet.Tables(0))
        ' Clear existing data sources (if needed)
        ReportViewer1.LocalReport.DataSources.Clear()

        ' Add the new data source
        ReportViewer1.LocalReport.DataSources.Add(rprtDS1)



        Me.ReportViewer1.RefreshReport()
    End Sub





    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub StaffByWardReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetReport("")
        GetDropdown(wardbox, "WARD", "WARD_NAME", "WARD_NUM")
    End Sub

    Private Sub wardbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wardbox.SelectedIndexChanged
        SetReport($"WHERE WARD_NUM = '{wardbox.SelectedItem.VALUE}'")
    End Sub
End Class