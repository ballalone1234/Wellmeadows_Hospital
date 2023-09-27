Public Class StaffRegister
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

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub ptno_TextChanged(sender As Object, e As EventArgs) Handles staff_no.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sex As String = ""
        If sexmale.Checked Then
            sex = "male"
        ElseIf sexfemale.Checked Then
            sex = "female"
        End If
        Dim data() As String = {$"'{staff_no.Text}'", $"'{position.Text}'", $"'{staff_name.Text}'", $"'{address.Text}'", $"{DOB.Value}", $"'{sex}'",
            $"'{work_location.Text}'", $"'{salary.Text}'", $"'{NIN.Text}'", $"'{tel.Text}'", $"'{worked_per_week.Text}'", $"'{work_type.Text}'", $"'{payment_type.Text}'", $"'{salary_level.Text}'"}
        Dim result As Int32 = RegisStaff(String.Join(",", data))
        If result > 0 Then
            MessageBox.Show("ลงทะเบียนบุคลากรสำเร็จ")
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles payment_type.TextChanged

    End Sub
End Class