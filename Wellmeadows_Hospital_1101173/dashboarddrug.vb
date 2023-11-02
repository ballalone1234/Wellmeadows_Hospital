﻿Imports Oracle.ManagedDataAccess.Client

Public Class dashboarddrug
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, RegisterPatient2)
    End Sub

    Private Sub Home_Click_1(sender As Object, e As EventArgs) Handles Home.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chart1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        NextPage(Me, dashboardstaff)
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NextPage(Me, Dashboard)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NextPage(Me, dashboardpatient)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NextPage(Me, dashboardward)
    End Sub

    Private Sub Chart1_Click_2(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub dashboarddrug_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetDropdown2(MonthD, "PRESCRIBED", "MONTH", "to_char(START_DATE, 'Month') as MONTH", "MONTH")
        LoadChart()
    End Sub

    Private where As String = " WHERE to_char(START_DATE, 'Month') = to_char(SYSDATE, 'Month') "
    Public Sub LoadChart()

        ' ตั้งค่าการเชื่อมต่อกับ Oracle Database

        ' สร้าง OracleConnection
        Dim connection As New OracleConnection(Connect())

        ' SQL Query สำหรับดึงข้อมูลจาก Oracle Database
        Dim query As String = $"SELECT DRUG_NAME  , count(*) as COUNT FROM prescribed p left join DRUG d on p.DRUG_NUM = d.DRUG_NUM {where} GROUP by DRUG_NAME "

        ' สร้าง DataTable เพื่อเก็บข้อมูล
        Dim dataTable As New DataTable()

        Try
            ' เปิดการเชื่อมต่อกับฐานข้อมูล
            connection.Open()

            ' สร้าง OracleDataAdapter และเตรียมข้อมูลใน DataTable
            Using adapter As New OracleDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using

            ' ตรวจสอบว่ามีข้อมูลใน DataTable หรือไม่
            If dataTable.Rows.Count > 0 Then

                ' กำหนดข้อมูลใน Chart
                Chart1.DataSource = dataTable
                Chart1.Series("จำนวนยา").XValueMember = "DRUG_NAME"
                Chart1.Series("จำนวนยา").YValueMembers = "Count"
                Chart1.Series("จำนวนยา").IsValueShownAsLabel = True ' แสดงค่าเป็น Label

                ' แสดง Chart
                Chart1.DataBind()
            Else
                MessageBox.Show("No data available.")
            End If
        Catch ex As Exception
            ' จัดการข้อผิดพลาด
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' ปิดการเชื่อมต่อ
            connection.Close()
        End Try
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        NextPage(Me, dashboardsup)
    End Sub

    Private Sub MonthD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonthD.SelectedIndexChanged
        where = $" WHERE to_char(START_DATE, 'Month') = '{MonthD.SelectedItem.VALUE}'"
        LoadChart()
    End Sub
End Class