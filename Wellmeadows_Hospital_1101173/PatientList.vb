Public Class PatientList
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) 
        Pagecontroller.NextPage(Me, RegisterPatient2)
    End Sub

    Private Sub PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.PATIENTS' table. You can move, or remove it, as needed.

        DataGridView1.DataSource = GetSeach("PATIENTS", "")

    End Sub





    Private Sub OPD_Report_Click(sender As Object, e As EventArgs) Handles OPD_Report.Click
        PatientOPD_report.Show()
    End Sub

    Private Sub inward_Click(sender As Object, e As EventArgs) Handles inward.Click
        PatientIn_report.Show()
    End Sub

    Private Sub ptno_KeyUp(sender As Object, e As KeyEventArgs) Handles ptno.KeyUp
        DataGridView1.DataSource = GetSeach("PATIENTS", ptno.Text)
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub
End Class