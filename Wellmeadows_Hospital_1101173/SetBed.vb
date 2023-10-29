Imports Oracle.ManagedDataAccess.Client

Public Class SetBed


    Private Sub SetBed_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetDropdown(Wardno, "WARD", "WARD_NAME", "WARD_NUM")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PatientList.SetBedv(BedNo.SelectedItem)
    End Sub
End Class