Public Class Dashboard
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

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        NextPage(Me, dashboardpatient)
    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NextPage(Me, dashboardpatient)
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        NextPage(Me, dashboardstaff)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NextPage(Me, dashboardward)
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        NextPage(Me, dashboardward)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        NextPage(Me, dashboarddrug)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = GetCountForDash("PATIENTS", "")
        maleC.Text = GetCountForDash("PATIENTS", "WHERE SEX like 'male'")
        FemaleC.Text = GetCountForDash("PATIENTS", "WHERE SEX like 'female'")
        OutC.Text = GetCountForDash("PATIENTS", "WHERE PATIENT_TYPE like 'out'")
        InC.Text = GetCountForDash("PATIENTS", "WHERE PATIENT_TYPE like 'in'")
        Allstaff.Text = GetCountForDash("STAFF", "")
        BedC.Text = GetCountForDash("BED", "")
        BedA.Text = GetCountForDash("BED", "WHERE PATIENT_NUM IS NULL")
        BedNa.Text = GetCountForDash("BED", "WHERE PATIENT_NUM IS NOT NULL")
        WardC.Text = GetCountForDash("WARD", "")

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        NextPage(Me, dashboardsup)
    End Sub
End Class