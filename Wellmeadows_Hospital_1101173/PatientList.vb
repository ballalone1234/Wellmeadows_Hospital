Public Class PatientList
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

    Private Sub PATIENTTBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PATIENTTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PATIENTTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Hospital)

    End Sub

    Private Sub PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.LOCALDOCTOR' table. You can move, or remove it, as needed.
        Me.LOCALDOCTORTableAdapter.Fill(Me.Hospital.LOCALDOCTOR)
        'TODO: This line of code loads data into the 'Hospital.PATIENTT' table. You can move, or remove it, as needed.
        Me.PATIENTTTableAdapter.Fill(Me.Hospital.PATIENTT)

    End Sub
End Class