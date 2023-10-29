Public Class PatientMenu
    Private Sub PatientMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registerpt_Click(sender As Object, e As EventArgs) Handles registerpt.Click
        Pagecontroller.NextPage(Me, RegisterPatient)
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        MainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub allocatept_Click(sender As Object, e As EventArgs) Handles allocatept.Click
        AllocatePatient.patientno.Enabled = True
        Pagecontroller.NextPage(Me, AllocatePatient)
    End Sub

    Private Sub prescribept_Click(sender As Object, e As EventArgs) Handles prescribept.Click
        Pagecontroller.NextPage(Me, Treatment)
    End Sub

    Private Sub assignpt_Click(sender As Object, e As EventArgs) Handles assignpt.Click
        Pagecontroller.NextPage(Me, AssignPatient)
    End Sub

    Private Sub listpt_Click(sender As Object, e As EventArgs) Handles listpt.Click
        Pagecontroller.NextPage(Me, PatientList)
    End Sub


End Class