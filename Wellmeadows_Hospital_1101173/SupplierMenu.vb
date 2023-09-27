Public Class SupplierMenu
    Private Sub PatientMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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



    Private Sub suppliersrc_Click(sender As Object, e As EventArgs) Handles suppliersrc.Click
        Pagecontroller.NextPage(Me, SupplierSearch)
    End Sub

    Private Sub supilerreg_Click(sender As Object, e As EventArgs) Handles supilerreg.Click
        Pagecontroller.NextPage(Me, SupplierRegister)
    End Sub
End Class