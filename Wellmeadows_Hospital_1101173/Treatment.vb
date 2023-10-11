﻿Imports System.Windows.Forms.AxHost
Imports Microsoft.Reporting.Map.WebForms.BingMaps
Imports Oracle.ManagedDataAccess.Client
Imports Wellmeadows_Hospital_1101173.Hospital

Public Class Treatment
    Public rowValueSave As List(Of List(Of String))
    Public dataApp() As String
    Public examRoom As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)

    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub SumitButton_Click(sender As Object, e As EventArgs) Handles SumitButton.Click
        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim data() As String = {$"MH_SEQ.NEXTVAL", $"'{ptno.Text}'", $"'{staff_id}'",
            $"'{ward.Text}'", $"TO_DATE('{Tdate.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')", $"'{Diagnosis.Text}'", $"'{tel.Text}'", $"'{DrugAllergies.Text}'"}
        Dim result As Int32 = InsetFlexibleMed(String.Join(",", data), "MEDICAL_HISTORY")
        If result > 0 Then
            rowValueSave.RemoveAt(rowValueSave.Count - 1)
            For Each row In rowValueSave
                Dim sql = $"INSERT INTO PRESCRIBED({GetColumn("PRESCRIBED")}) 
                VALUES({result} , {String.Join(",", row)})"
                Debug.WriteLine(sql)
                Dim cmd As New OracleCommand(sql, connection)
                cmd.ExecuteNonQuery()
            Next
            Dim dataApp() As String = {$"'{appnum.Text}'", $"TO_DATE('{Appointment.examdate.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')",
            $"'{examRoom}'", $"{result}"}
            InsetFlexible(String.Join(",", dataApp), "PATIENTAPPOINTMENT")
            MessageBox.Show("เพิ่มเสร็จสมบูรณ์")
        End If


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub kinname_TextChanged(sender As Object, e As EventArgs) Handles ptno.Click
        FormSearch.seachTable = "PATIENTS"
        FormSearch.cellColumn = "PATIENT_NUM"

        FormSearch.returnText = ptno

        FormSearch.Show()
    End Sub

    Private Sub ward_TextChanged(sender As Object, e As EventArgs) Handles ward.Click
        FormSearch.seachTable = "WARD"
        FormSearch.cellColumn = "WARD_NUM"
        FormSearch.returnText = ward

        FormSearch.Show()
    End Sub

    Private Sub Medications_TextChanged(sender As Object, e As EventArgs) Handles Medications.Click
        PrescribeMenu.Show()
        PrescribeMenu.ptno.Text = ptno.Text

    End Sub

    Private Sub appnum_TextChanged(sender As Object, e As EventArgs) Handles appnum.Click
        Appointment.ptno.Text = ptno.Text
        Appointment.Show()
    End Sub


End Class