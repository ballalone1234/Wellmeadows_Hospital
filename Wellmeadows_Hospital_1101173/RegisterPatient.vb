﻿Public Class RegisterPatient
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        MainMenu.Show()
        Me.Hide()

    End Sub


    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        RegisterPatient2.Show()
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        PatientMenu.Show()
        Me.Hide()
    End Sub
End Class