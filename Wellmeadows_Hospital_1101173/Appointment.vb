Public Class Appointment

    Public cid_patient As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs)
        Pagecontroller.BackPage(Me)
    End Sub


    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Treatment.appnum.Text = $"{ptno.Text}{examroom.Text}{wardno.Text}{examdate.Value.ToString("yyyyMMdd")}"
        Close()
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub wardno_TextChanged(sender As Object, e As EventArgs) Handles wardno.Click
        FormSearch.seachTable = "WARD"
        FormSearch.cellColumn = "WARD_NUM"
        FormSearch.returnText = wardno

        FormSearch.Show()

    End Sub

    Private Sub wardno_TextChanged_1(sender As Object, e As EventArgs) Handles wardno.TextChanged

    End Sub
End Class