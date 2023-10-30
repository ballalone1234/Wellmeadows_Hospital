Public Class dashboardward
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NextPage(Me, dashboardpatient)
    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click
        NextPage(Me, Dashboard)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NextPage(Me, dashboarddrug)
    End Sub

    Private Sub dashboardward_Load(sender As Object, e As EventArgs) Handles Me.Load
        Chart1.Series("จำนวนสตาฟ").Points.AddXY("Ward 1", 5)
        Chart1.Series("จำนวนสตาฟ").Points.AddXY("Ward 2", 10)
        Chart1.Series("จำนวนสตาฟ").Points.AddXY("Ward 3", 9)
        Chart1.Series("จำนวนสตาฟ").Points.AddXY("Ward 4", 10)
        Chart1.Series("จำนวนสตาฟ").Points.AddXY("Ward 5", 8)
        Chart1.Series("จำนวนสตาฟ").Points.AddXY("Ward 6", 11)
        Chart1.Series("จำนวนสตาฟ").IsValueShownAsLabel = True ' แสดงค่าเป็น Label
        Chart2.Series("จำนวนผู้ป่วย").Points.AddXY("Ward 1", 20)
        Chart2.Series("จำนวนผู้ป่วย").Points.AddXY("Ward 2", 30)
        Chart2.Series("จำนวนผู้ป่วย").Points.AddXY("Ward 3", 25)
        Chart2.Series("จำนวนผู้ป่วย").Points.AddXY("Ward 4", 15)
        Chart2.Series("จำนวนผู้ป่วย").Points.AddXY("Ward 5", 8)
        Chart2.Series("จำนวนผู้ป่วย").Points.AddXY("Ward 6", 19)
        Chart2.Series("จำนวนผู้ป่วย").IsValueShownAsLabel = True ' แสดงค่าเป็น Label
        Chart3.Series("เตียงที่ใช้").Points.AddXY("Ward 1", 20)
        Chart3.Series("เตียงที่ใช้").Points.AddXY("Ward 2", 30)
        Chart3.Series("เตียงที่ใช้").Points.AddXY("Ward 3", 25)
        Chart3.Series("เตียงที่ใช้").Points.AddXY("Ward 4", 15)
        Chart3.Series("เตียงที่ใช้").Points.AddXY("Ward 5", 8)
        Chart3.Series("เตียงที่ใช้").Points.AddXY("Ward 6", 19)
        Chart3.Series("เตียงที่ใช้").IsValueShownAsLabel = True ' แสดงค่าเป็น Label
        Chart3.Series("เตียงที่มี").Points.AddXY("Ward 1", 30)
        Chart3.Series("เตียงที่มี").Points.AddXY("Ward 2", 31)
        Chart3.Series("เตียงที่มี").Points.AddXY("Ward 3", 25)
        Chart3.Series("เตียงที่มี").Points.AddXY("Ward 4", 17)
        Chart3.Series("เตียงที่มี").Points.AddXY("Ward 5", 7)
        Chart3.Series("เตียงที่มี").Points.AddXY("Ward 6", 20)
        Chart3.Series("เตียงที่มี").IsValueShownAsLabel = True ' แสดงค่าเป็น Label
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        NextPage(Me, dashboardsup)
    End Sub
End Class