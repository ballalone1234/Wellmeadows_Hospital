Public Class RegisterPatient3
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)

    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub SumitButton_Click(sender As Object, e As EventArgs) Handles SumitButton.Click
        Pagecontroller.NextPage(Me, RegisterPatient4)
    End Sub
End Class