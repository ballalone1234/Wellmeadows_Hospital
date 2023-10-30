Public Class PatientList

    Private table As String = "PATIENTS"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) 
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, RegisterPatient2)
    End Sub

    Private Sub PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hospital.PATIENTS' table. You can move, or remove it, as needed.

        DataGridView1.DataSource = GetSeach(table, "")

    End Sub





    Private Sub OPD_Report_Click(sender As Object, e As EventArgs) Handles OPD_Report.Click
        PatientOPD_report.Show()
    End Sub

    Private Sub inward_Click(sender As Object, e As EventArgs) Handles inward.Click
        PatientIn_report.Show()
    End Sub

    Private Sub ptno_KeyUp(sender As Object, e As KeyEventArgs) Handles ptno.KeyUp
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub

    Public Sub Reload()
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub
    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub drugtopa_Click(sender As Object, e As EventArgs) Handles drugtopa.Click
        DrugToPatientReport.Show()
    End Sub

    Private Sub waittinglist_Click(sender As Object, e As EventArgs) Handles waittinglist.Click
        table = "WATTING_BED"
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub

    Private Sub watReport_Click(sender As Object, e As EventArgs) Handles watReport.Click
        WaittinglistRepot.Show()
    End Sub

    Private Sub inpatient_Click(sender As Object, e As EventArgs) Handles inpatient.Click
        table = "ALLOCATEDTO"
        DataGridView1.DataSource = GetSeach(table, ptno.Text)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If table = "ALLOCATEDTO" Then


            Dim cellValue As Object = DataGridView1.Rows(e.RowIndex).Cells("PATIENT_NUM").Value
            DataGridView1.Text = cellValue.ToString()

            Debug.Write(DataGridView1.Rows(e.RowIndex))

            SelectFunction.Show()
            SelectFunction.Button1.Text = "Update"
            SelectFunction.Button3.Text = "Delete"
            SelectFunction.Button2.Text = "Update Actual leave"
            SelectFunction.Button4.Text = "Update bed"
            SelectFunction.Func4 = Sub()
                                       Try
                                           Dim userInput As String = InputBox("กรุณาป้อนเลขเตียง:", "Input Dialog")
                                           UpdateData2("ALLOCATEDTO", "BED_NUM", "PATIENT_NUM", DataGridView1.Text, userInput)
                                           SelectFunction.Close()
                                           Reload()
                                       Catch ex As Exception
                                           MessageBox.Show("Update bed fail")
                                       End Try
                                   End Sub
            SelectFunction.Func2 = Sub()
                                       SetActualLeave.Show()
                                   End Sub
            SelectFunction.Func3 = Sub()
                                       Dim result2 As DialogResult = MessageBox.Show($"Do you want Delete {cellValue.ToString()} ?", "Confirmation", MessageBoxButtons.YesNoCancel)

                                       If result2 = DialogResult.Yes Then
                                       ElseIf result2 = DialogResult.No Then
                                       ElseIf result2 = DialogResult.Cancel Then
                                       End If
                                   End Sub

        ElseIf table = "WATTING_BED" Then
            Dim cellValue As Object = DataGridView1.Rows(e.RowIndex).Cells("PATIENT_NUM").Value
            DataGridView1.Text = cellValue.ToString()

            Debug.Write(DataGridView1.Rows(e.RowIndex))
            SelectFunction.Show()
            SelectFunction.Button1.Text = "Choose bed"
            SelectFunction.Button3.Text = "Delete"
            SelectFunction.Button2.Text = "Update Actual leave"
            SelectFunction.Button4.Text = "Update bed"
            SelectFunction.Func1 = Sub()
                                       SetBed.Show()
                                   End Sub




        End If
    End Sub

    Public Sub SetActual(val)
        Try
            UpdateData2("ALLOCATEDTO", "ACTUAL_LEAVE", "PATIENT_NUM", DataGridView1.Text, val)
            MessageBox.Show("Update Actual leave success")
            Reload()
        Catch ex As Exception
            MessageBox.Show("Update Actual leave fail")
        End Try
    End Sub
    Public Sub SetBedv(val)
        Try
            UpdateData2("BED", "PATIENT_NUM", "BED_NUM", val, DataGridView1.Text)
            MessageBox.Show("Update Bed success")
            Reload()
        Catch ex As Exception
            MessageBox.Show("Update Actual leave fail")
        End Try
    End Sub
End Class