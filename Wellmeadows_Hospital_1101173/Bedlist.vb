Public Class Bedlist
    Private Sub PatientMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registerpt_Click(sender As Object, e As EventArgs)
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

    Private Sub stafflistbtn_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, StaffList)
    End Sub

    Private Sub listpt_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, PatientList)
    End Sub

    Private Sub waitingpt_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, WaitingListPatient)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, Wardlist)
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class