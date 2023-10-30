Imports DataVisualization.Charting
Imports System.Data
Imports Oracle.DataAccess.Client
Imports Oracle.ManagedDataAccess.Client

Public Class dashboardsup
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs)
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

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NextPage(Me, Dashboard)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NextPage(Me, dashboardward)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NextPage(Me, dashboarddrug)
    End Sub

    Private Sub dashboardpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rand As New Random()
        For i As Integer = 2018 To 2023
            Dim value As Integer = 1800000 + rand.Next(-50000, 50000)
            Chart1.Series("มูลค่าการจัดซื้อ").Points.AddXY(i.ToString(), value)
        Next
        Chart1.Series("มูลค่าการจัดซื้อ").IsValueShownAsLabel = True
        For i As Integer = 2018 To 2023
            Dim value As Integer = 200000 + rand.Next(-50000, 50000)
            Chart2.Series("ปริมาณยาคงคลัง").Points.AddXY(i.ToString(), value)
        Next
        Chart2.Series("ปริมาณยาคงคลัง").IsValueShownAsLabel = True
        For i As Integer = 2018 To 2023
            Dim value As Integer = 200000 + rand.Next(-50000, 50000)
            Chart2.Series("ปริมาณยาที่ใช้").Points.AddXY(i.ToString(), value)
        Next
        Chart2.Series("ปริมาณยาที่ใช้").IsValueShownAsLabel = True
        For i As Integer = 2018 To 2023
            Dim value As Integer = 200000 + rand.Next(-50000, 50000)
            Chart2.Series("ปริมาณยาสั่งซื้อ").Points.AddXY(i.ToString(), value)
        Next
        Chart2.Series("ปริมาณยาสั่งซื้อ").IsValueShownAsLabel = True
        For i As Integer = 2018 To 2023
            Dim value As Integer = 1800000 + rand.Next(-50000, 50000)
            Chart4.Series("มูลค่าการจัดซื้อ").Points.AddXY(i.ToString(), value)
        Next
        For i As Integer = 2018 To 2023
            Dim value As Integer = 200000 + rand.Next(-50000, 50000)
            Chart3.Series("ปริมาณที่ใช้").Points.AddXY(i.ToString(), value)
        Next
        Chart3.Series("ปริมาณที่ใช้").IsValueShownAsLabel = True
        For i As Integer = 2018 To 2023
            Dim value As Integer = 200000 + rand.Next(-50000, 50000)
            Chart3.Series("ปริมาณที่ชำรุด/ทิ้ง").Points.AddXY(i.ToString(), value)
        Next
        Chart3.Series("ปริมาณที่ชำรุด/ทิ้ง").IsValueShownAsLabel = True
        For i As Integer = 2018 To 2023
            Dim value As Integer = 200000 + rand.Next(-50000, 50000)
            Chart3.Series("ปริมาณที่สั่งซื้อ").Points.AddXY(i.ToString(), value)
        Next
        Chart3.Series("ปริมาณที่สั่งซื้อ").IsValueShownAsLabel = True
    End Sub

    Private Sub Chart3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chart1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NextPage(Me, dashboardpatient)
    End Sub

    Private Sub Chart2_Click(sender As Object, e As EventArgs) Handles Chart2.Click

    End Sub
End Class