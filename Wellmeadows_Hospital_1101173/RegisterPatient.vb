Public Class RegisterPatient

    Public cid_patient As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub


    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim data As List(Of String) = New List(Of String)({"patient_seq.NEXTVAL", $"'{Pname.Text}'", $"'{status.SelectedItem}'", "SYSDATE", $"TO_DATE('{DOB.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')", $"'{tel.Text}'", $"'{ctno.Text}'", $"'{address.Text}'", $"'{sex.SelectedItem}'"})
        RegisterPatient2.param = data
        cid_patient = ctno.Text
        NextPage(Me, RegisterPatient2)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class