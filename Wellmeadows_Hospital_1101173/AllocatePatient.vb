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
        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim sql As String = "SELECT WARD_NUM FROM WARD"
        Dim command As New OracleCommand(sql, connection)
        Dim reader As OracleDataReader = command.ExecuteReader()
        While reader.Read()
            Wardno.Items.Add(reader("WARD_NUM").ToString()) ' column_name คือชื่อคอลัมน์ที่คุณต้องการใส่ใน ComboBox
            Console.WriteLine(reader("WARD_NUM"))

        End While
        reader.Close()
        connection.Close()
        Wardno.Height = 100


    End Sub

    Private Sub Wardno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Wardno.SelectedIndexChanged
        Dim selectedValue As String = Wardno.SelectedItem.ToString()
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

        If inp.Checked Then
            table = "ALLOCATEDTO"
            data = {$"'{patientno.Text}'", $"'{Wardno.SelectedItem.ToString()}'", $"{Getdate(dateplace)}",
            $"{Getdate(dateleave)}", $"{Getdate(actualleave)}", $"'{ExDay.Text}'", $"{Getdate(waitingdate)}"}
        ElseIf outp.Checked Then
            table = "ALLOCATEDTO_OPD"
            data = {$"'{patientno.Text}'", $"'{Wardno.SelectedItem.ToString()}'", "watting_que_seq.NEXTVAL", $"{Getdate(waitingdate)}"}
        End If
        MessageBox.Show(table)
        If Allocate(String.Join(",", data), table) > 0 Then
            MessageBox.Show("ส่งมอบสำเร็จ")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles outp.CheckedChanged
        actualleave.Hide()
        ExDay.Hide()
        dateleave.Hide()
        dateplace.Hide()
        BedNo.Hide()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles inp.CheckedChanged
        actualleave.Show()
        ExDay.Show()
        dateleave.Show()
        dateplace.Show()
        BedNo.Show()

    End Sub
End Class