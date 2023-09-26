Public Class RegisterPatient
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        MainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        PatientMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class