Public Class StaffMenu
    Private Sub PatientMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registerpt_Click(sender As Object, e As EventArgs) Handles registerstaff.Click
        If position = "HR" Then
            NextPage(Me, StaffRegister)
        Else
            MessageBox.Show("เฉพาะ HR เท่านั้น")
        End If

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

    Private Sub stafflistbtn_Click(sender As Object, e As EventArgs) Handles stafflistbtn.Click
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
End Class