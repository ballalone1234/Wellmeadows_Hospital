Public Class PatientMenu
    Private Sub PatientMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub registerpt_Click(sender As Object, e As EventArgs) Handles registerpt.Click
        RegisterPatient.Show()
        Me.Hide()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        MainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class