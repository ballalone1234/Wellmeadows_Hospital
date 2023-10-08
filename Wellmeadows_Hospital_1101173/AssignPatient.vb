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
        RegisterPatient4.pid = patientno.Text
        RegisterPatient4.loadData()
        Dim data() As String = {$"{staff_id}", $"{patientno.Text}", "SYSDATE"}
        If InsetFlexible(String.Join(",", data), "ASSIGNEDTO") > 0 Then
            MessageBox.Show("assign sucess!")
            Pagecontroller.NextPage(Me, RegisterPatient4)
        End If
    End Sub

    Private Sub ptno_TextChanged(sender As Object, e As EventArgs) Handles patientno.TextChanged

    End Sub

    Private Sub searchassign_Click(sender As Object, e As EventArgs) Handles searchassign.Click
        FormSearch.seachTable = "PATIENTS"
        FormSearch.returnText = patientno
        FormSearch.cellColumn = "PATIENT_NUM"
        FormSearch.Show()

    End Sub


End Class