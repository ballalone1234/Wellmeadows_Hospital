Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class setChargeN

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



        UpdateData("STAFF", "WORK_LOCATION", "STAFF_NUM", staffno.Text, wardno.Text)
        UpdateData("WARD", "STAFF_NUM", "WARD_NUM", wardno.Text, staffno.Text)
        Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub wardno_TextChanged(sender As Object, e As EventArgs) Handles wardno.Click
        FormSearch.seachTable = "WARD"
        FormSearch.cellColumn = "WARD_NUM"
        FormSearch.returnText = wardno

        FormSearch.Show()
    End Sub
End Class