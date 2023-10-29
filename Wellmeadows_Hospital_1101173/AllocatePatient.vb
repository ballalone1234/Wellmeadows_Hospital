Imports Oracle.ManagedDataAccess.Client

Public Class AllocatePatient
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)

    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles inp.CheckedChanged

    End Sub

    Private Sub AllocatePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        patientno.Text = pa_id
        GetDropdown(Wardno, "WARD", "WARD_NAME", "WARD_NUM")

        Wardno.Height = 100


    End Sub

    Private Sub Wardno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Wardno.SelectedIndexChanged
        Dim selectedValue As String = Wardno.SelectedItem.VALUE.ToString()
        Debug.WriteLine(selectedValue)
        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim sql As String = $"SELECT BED_NUM FROM BED WHERE WARD_NUM = '{selectedValue}'"
        Dim command As New OracleCommand(sql, connection)
        Dim reader As OracleDataReader = command.ExecuteReader()
        While reader.Read()
            BedNo.Items.Add(reader("BED_NUM").ToString()) ' column_name คือชื่อคอลัมน์ที่คุณต้องการใส่ใน ComboBox


        End While
        reader.Close()
        connection.Close()
    End Sub


    Private Sub Summit2Button_Click(sender As Object, e As EventArgs) Handles Summit2Button.Click
        Dim table As String = ""
        Dim data() As String = {}
        Dim patient_type As String = ""
        If inp.Checked Then
            table = "ALLOCATEDTO"
            data = {BedNo.SelectedItem, $"'{patientno.Text}'", $"'{Wardno.SelectedItem.VALUE.ToString()}'", $"SYSDATE",
            $"SYSDATE + {ExDay.Text}", $"NULL", $"'{ExDay.Text}'"}
            patient_type = "in"
            If UpdateBedOrInsertToWaittinglist(BedNo.SelectedItem, patientno.Text, Wardno.SelectedItem.VALUE) Then
                If Allocate(String.Join(",", data), table) > 0 Then
                    UpdateData("PATIENTS", "PATIENT_TYPE", "PATIENT_NUM", patientno.Text, patient_type)
                    MessageBox.Show("ส่งไปที่คลินิกแล้ว")
                    PatientList.Show()
                    PatientList.Reload()
                    Close()
                End If
            End If
        ElseIf outp.Checked Then
            table = "ALLOCATEDTO_OPD"
            data = {$"'{patientno.Text}'", $"'{Wardno.SelectedItem.VALUE.ToString()}'", "watting_que_seq.NEXTVAL", $"{Getdate(waitingdate)}"}
            patient_type = "out"
            If Allocate(String.Join(",", data), table) > 0 Then
                UpdateData("PATIENTS", "PATIENT_TYPE", "PATIENT_NUM", patientno.Text, patient_type)
                MessageBox.Show("ส่งไปที่คลินิก OPD แล้ว")
                PatientList.Show()
                PatientList.Reload()
                Close()
            End If
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles outp.CheckedChanged
        waitingdate.Hide()
        ExDay.Hide()
        BedNo.Hide()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles inp.CheckedChanged
        waitingdate.Show()
        ExDay.Show()
        BedNo.Show()

    End Sub

    Private Sub ExDay_TextChanged(sender As Object, e As EventArgs) Handles ExDay.TextChanged

    End Sub

    Private Sub patientno_TextChanged(sender As Object, e As EventArgs) Handles patientno.Click
        FormSearch.seachTable = "PATIENTS"
        FormSearch.cellColumn = "PATIENT_NUM"

        FormSearch.returnText = patientno


        FormSearch.Show()
    End Sub
End Class