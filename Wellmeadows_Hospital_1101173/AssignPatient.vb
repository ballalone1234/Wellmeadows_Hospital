Public Class AssignPatient
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

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub assignbtn_Click(sender As Object, e As EventArgs) Handles assignbtn.Click
        Pagecontroller.NextPage(Me, RegisterPatient4)
    End Sub

    Private Sub ptno_TextChanged(sender As Object, e As EventArgs) Handles ptno.TextChanged

    End Sub
End Class