Public Class MainMenu
    Private Sub patienticon_Click_2(sender As Object, e As EventArgs) Handles patienticon.Click
        PatientMenu.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class