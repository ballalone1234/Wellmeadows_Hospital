Public Class StaffList
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

    Private Sub STAFFBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles STAFFBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.STAFFBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital)

    End Sub

    Private Sub StaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.STAFF' table. You can move, or remove it, as needed.
        Me.STAFFTableAdapter.Fill(Me.Hospital.STAFF)

    End Sub
End Class