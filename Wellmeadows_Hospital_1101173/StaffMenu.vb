Public Class StaffMenu
    Private Sub PatientMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registerpt_Click(sender As Object, e As EventArgs) Handles registerstaff.Click
        Pagecontroller.NextPage(Me, StaffRegister)
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        MainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs)
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub allocatept_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, AllocatePatient)
    End Sub

    Private Sub prescribept_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, PrescribeMenu)
    End Sub

    Private Sub assignpt_Click(sender As Object, e As EventArgs) Handles stafflistbtn.Click
        Pagecontroller.NextPage(Me, AssignPatient)
    End Sub

    Private Sub listpt_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, PatientList)
    End Sub

    Private Sub waitingpt_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, WaitingListPatient)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class