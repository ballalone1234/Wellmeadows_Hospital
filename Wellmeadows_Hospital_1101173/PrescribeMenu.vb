Imports System.Globalization
Imports System.Net
Imports System.Windows.Forms.AxHost
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports Oracle.ManagedDataAccess.Client
Imports Wellmeadows_Hospital_1101173.Hospital

Public Class PrescribeMenu
    Public rowValue As New List(Of List(Of String))()
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)

    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub DrugNo_Click(sender As Object, e As EventArgs) Handles DrugNo.Click
        FormSearch.seachTable = "DRUG"
        FormSearch.cellColumn = "DRUG_NUM"
        FormSearch.returnRows = rowData
        FormSearch.returnText = DrugNo
        FormSearch.Show()

    End Sub
    Private rowData As Object
    Public drug_nameE As String
    Private Sub ptno_TextChanged(sender As Object, e As EventArgs) Handles ptno.Click
        FormSearch.seachTable = "PATIENTS"
        FormSearch.cellColumn = "PATIENT_NUM"

        FormSearch.returnText = ptno

        FormSearch.Show()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim row As String() = {DrugNo.Text, UnitPer.Value, St.Value.ToString("yyyy-MM-dd"), EndD.Value.ToString("yyyy-MM-dd"), Detail.Text}

        DataDrug.Rows.Add(row)
    End Sub

    Private Sub Summit2Button_Click(sender As Object, e As EventArgs) Handles Summit2Button.Click
        Dim connection As New OracleConnection(Connect())
        connection.Open()

        For Each row As DataGridViewRow In DataDrug.Rows
            Dim columnValues As New List(Of String)()
            For Each row2 As DataGridViewCell In row.Cells
                Dim dateString As String = row2.Value
                Dim format As String = "yyyy-MM-dd"
                Dim parsedDate As DateTime

                If DateTime.TryParseExact(dateString, format, Nothing, DateTimeStyles.None, parsedDate) Then
                    columnValues.Add($"TO_DATE('{row2.Value}','YYYY-MM-DD')")
                Else
                    columnValues.Add($"'{row2.Value}'")
                End If

            Next
            rowValue.Add(columnValues)
            Debug.WriteLine(columnValues)

        Next

        Debug.WriteLine(rowValue)


        'Dim cmd As New OracleCommand(sql, connection)
        'cmd.ExecuteNonQuery()
        connection.Close()
        Treatment.Medications.Text = "add success"
        Treatment.rowValueSave = rowValue
        Debug.WriteLine(Treatment.rowValueSave)
        Hide()

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs)

    End Sub




End Class