Public Class PatientList

    Private table As String = "PATIENTS"
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

        DataGridView1.DataSource = GetSeach(table, "")

    End Sub





    Private Sub OPD_Report_Click(sender As Object, e As EventArgs) Handles OPD_Report.Click
        PatientOPD_report.Show()
    End Sub

    Private Sub inward_Click(sender As Object, e As EventArgs) Handles inward.Click
        PatientIn_report.Show()
    End Sub

    Private Sub ptno_KeyUp(sender As Object, e As KeyEventArgs) Handles ptno.KeyUp
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub

    Public Sub Reload()
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub
    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub drugtopa_Click(sender As Object, e As EventArgs) Handles drugtopa.Click
        DrugToPatientReport.Show()
    End Sub

    Private Sub waittinglist_Click(sender As Object, e As EventArgs) Handles waittinglist.Click
        table = "WATTING_BED"
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub

    Private Sub watReport_Click(sender As Object, e As EventArgs) Handles watReport.Click
        WaittinglistRepot.Show()
    End Sub

    Private Sub inpatient_Click(sender As Object, e As EventArgs) Handles inpatient.Click
        table = "ALLOCATEDTO"
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class