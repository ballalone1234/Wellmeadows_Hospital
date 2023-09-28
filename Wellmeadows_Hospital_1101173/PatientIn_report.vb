Imports Microsoft.Reporting.WinForms
Imports Oracle.ManagedDataAccess.Client
Imports System.Data.SqlClient

Public Class PatientIn_report
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub










    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Me.ReportViewer1.Clear()

        Dim oracleDataAdapter As New OracleDataAdapter("SELECT * FROM DETAIL_CURRENT_PATIENTS_IN_WARD", Connect())
        Dim dataSet As New DataSet()
        oracleDataAdapter.Fill(dataSet)

        Dim rprtDS1 As New ReportDataSource("DataSet1", dataSet.Tables(0))
        ReportViewer1.LocalReport.DataSources.Add(rprtDS1)


        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub PatientIn_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class