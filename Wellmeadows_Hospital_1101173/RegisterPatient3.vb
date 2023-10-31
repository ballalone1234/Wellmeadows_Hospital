Imports Oracle.ManagedDataAccess.Client

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
        Dim data() As String = {$"'{GetPatientNum(RegisterPatient.ctno.Text)}'", $"'{kinname.Text}'", $"'{ address.Text}'", $"'{relationship.Text}'", $"'{tel.Text}'"}
        Dim result As Integer = RegisPatientKin(String.Join(",", data))
        RegisterPatient4.pid = GetPatientNum(RegisterPatient.ctno.Text)
        If result > 0 Then
            Pagecontroller.NextPage(Me, RegisterPatient4)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

End Class