Imports Microsoft.Reporting.WinForms
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SqlClient

Public Class PatientOPD_report
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub






    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Me.ReportViewer1.Clear()

        Dim oracleDataAdapter As New OracleDataAdapter("SELECT * FROM DETAIL_ALLOCATE_OPD", Connect())
        Dim dataSet As New DataSet()
        oracleDataAdapter.Fill(dataSet)

        Dim rprtDS1 As New ReportDataSource("DataSet1", dataSet.Tables(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS1)


        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class