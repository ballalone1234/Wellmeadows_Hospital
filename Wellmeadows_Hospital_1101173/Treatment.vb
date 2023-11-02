Imports System.Windows.Forms.AxHost
Imports Microsoft.Reporting.Map.WebForms.BingMaps
Imports Oracle.ManagedDataAccess.Client
Imports Wellmeadows_Hospital_1101173.Hospital

Public Class Treatment
    Public rowValueSave As List(Of List(Of String))
    Public dataApp() As String
    Public examRoom As String
    Public id As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)

    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs)
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub SumitButton_Click(sender As Object, e As EventArgs) Handles SumitButton.Click
        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim data() As String = {$"MH_SEQ.NEXTVAL", $"'{ptno.Text}'", $"'{staff_id}'",
            $"'{ward.Text}'", $"TO_DATE('{Tdate.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')", $"'{Diagnosis.Text}'", $"'{tel.Text}'", $"'{DrugAllergies.Text}'"}
        Dim result As Int32 = InsetFlexibleMed(String.Join(",", data), "MEDICAL_HISTORY")
        If result > 0 Then
            rowValueSave.RemoveAt(rowValueSave.Count - 1)
            For Each row In rowValueSave
                Dim sql = $"INSERT INTO PRESCRIBED({GetColumn("PRESCRIBED")}) 
                VALUES({result} , {String.Join(",", row)})"
                Debug.WriteLine(sql)
                Dim cmd As New OracleCommand(sql, connection)
                cmd.ExecuteNonQuery()
            Next
            Dim dataApp() As String = {$"'{AppointStatus.Text}'", $"TO_DATE('{Appointment.examdate.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')",
            $"'{examRoom}'", $"{result}"}
            If AppointStatus.Text.Equals("Haven't made an appointment") Then

            Else
                InsetFlexible(String.Join(",", dataApp), "PATIENTAPPOINTMENT")
            End If
            PatientList.Show()
            Close()
            PrescribeMenu.Close()
            MessageBox.Show("เพิ่มเสร็จสมบูรณ์")
        End If


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub kinname_TextChanged(sender As Object, e As EventArgs) Handles ptno.Click
        FormSearch.seachTable = "PATIENTS"
        FormSearch.cellColumn = "PATIENT_NUM"

        FormSearch.returnText = ptno
        FormSearch.returnMode = True
        FormSearch.func = AddressOf FetchData
        FormSearch.Show()
    End Sub

    Private Sub ward_TextChanged(sender As Object, e As EventArgs) Handles ward.Click
        FormSearch.seachTable = "WARD"
        FormSearch.cellColumn = "WARD_NUM"
        FormSearch.returnText = ward

        FormSearch.Show()
    End Sub

    Private Sub Medications_TextChanged(sender As Object, e As EventArgs)
        PrescribeMenu.Show()
        PrescribeMenu.ptno.Text = ptno.Text

    End Sub

    Private Sub appnum_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Medications_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Med_Click(sender As Object, e As EventArgs) Handles Med.Click
        PrescribeMenu.Show()
        PrescribeMenu.ptno.Text = ptno.Text
    End Sub

    Private Sub Appbut_Click(sender As Object, e As EventArgs) Handles Appbut.Click
        Appointment.ptno.Text = ptno.Text
        Appointment.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormSearch.seachTable = "MEDICAL_HISTORY"
        FormSearch.cellColumn = "MH_ID"
        FormSearch.returnText = his_id
        FormSearch.returnMode = True
        FormSearch.func = AddressOf FetchData

        FormSearch.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FetchData()
        Try
            Dim reader As OracleDataReader = GetData.Getdata(his_id.Text, "H.MH_ID", "PATIENTAPPOINTMENT A, MEDICAL_HISTORY H", "A.MH_ID = H.MH_ID AND ")
            While reader.Read()
                ptno.Text = reader("PATIENT_NUM").ToString()

            End While
            reader.Close()


        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        Console.WriteLine("ggg")
        FormSearch.search.Text = ptno.Text
        FormSearch.seachTable = "MEDICAL_HISTORY"
        FormSearch.cellColumn = "MH_ID"
        FormSearch.returnText = his_id
        FormSearch.returnMode = True
        FormSearch.func = AddressOf FetchData2
        FormSearch.Show()


    End Sub

    Public Sub FetchData2()
        Console.WriteLine("ggssfsfg")

        Try
            Dim reader As OracleDataReader = GetData.Getdata(his_id.Text, "H.MH_ID", "PATIENTAPPOINTMENT A, MEDICAL_HISTORY H", "A.MH_ID = H.MH_ID AND ")
            While reader.Read()
                ptno.Text = reader("PATIENT_NUM").ToString()
                Diagnosis.Text = reader("DIAGNOSIS").ToString()
                tel.Text = reader("TREAT_REV").ToString()
                ward.Text = reader("WARD_NUM").ToString()
                DrugAllergies.Text = reader("DRUG_ALLERGIES").ToString()
                Tdate.Value = reader("TREATMENT_DATE")
                Diagnosis.Enabled = True
                tel.Enabled = True
                ward.Enabled = True
                DrugAllergies.Enabled = True
                Tdate.Enabled = True
                Diagnosis.Enabled = True

            End While
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

End Class