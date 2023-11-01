Public Class Wardlist
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

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pagecontroller.BackPage(Me)
    End Sub




    Private Sub StaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.LIST_STAFF' table. You can move, or remove it, as needed.

        LIST_STAFFDataGridView.DataSource = GetSeach("WARD", ptno.Text)

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub Fillter_Click(sender As Object, e As EventArgs) Handles Fillter.Click

    End Sub

    Private Sub ptno_KeyUp(sender As Object, e As KeyEventArgs) Handles ptno.KeyUp
        LIST_STAFFDataGridView.DataSource = GetSeach("WARD", ptno.Text)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LIST_STAFFDataGridView.CellClick
        Dim go As TextBox = New TextBox()
        Dim cellValue As Object = LIST_STAFFDataGridView.Rows(e.RowIndex).Cells("WARD_NUM").Value
        LIST_STAFFDataGridView.Text = cellValue.ToString()

        Debug.Write(LIST_STAFFDataGridView.Rows(e.RowIndex))

        SelectFunction.Show()
        SelectFunction.Button1.Text = "Check staff"
        SelectFunction.Button2.Text = "Check pateint"
        SelectFunction.Button3.Text = "Check bed"
        SelectFunction.Button4.Hide()
        SelectFunction.Func1 = Sub()
                                   FormSearch.seachTable = "STAFF"
                                   FormSearch.cellColumn = "STAFF_NUM"
                                   FormSearch.search.Text = LIST_STAFFDataGridView.Text
                                   FormSearch.singleMode = True
                                   FormSearch.returnText = go
                                   FormSearch.Show()
                               End Sub

        SelectFunction.Func2 = Sub()
                                   FormSearch.seachTable = "PATIENTS"
                                   FormSearch.cellColumn = "PATIENT_NUM"
                                   FormSearch.search.Text = LIST_STAFFDataGridView.Text
                                   FormSearch.singleMode = True
                                   FormSearch.returnText = go
                                   FormSearch.Show()
                               End Sub
        SelectFunction.Func3 = Sub()
                                   FormSearch.seachTable = "BED"
                                   FormSearch.cellColumn = "BED_NUM"
                                   FormSearch.search.Text = LIST_STAFFDataGridView.Text
                                   FormSearch.singleMode = True
                                   FormSearch.returnText = go
                                   FormSearch.Show()
                               End Sub



    End Sub

    Private Sub setWard_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub setCharge_CheckedChanged(sender As Object, e As EventArgs)
        ptno.Text = "Charge Nurse"
        LIST_STAFFDataGridView.DataSource = GetSeach("LIST_STAFF", ptno.Text)
    End Sub

    Private Sub ReporyByWard_Click(sender As Object, e As EventArgs)
        StaffByWardReport.Show()

    End Sub
End Class