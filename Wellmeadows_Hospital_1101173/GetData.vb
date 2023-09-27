Imports System.Collections.ObjectModel
Imports Oracle.ManagedDataAccess.Client

Module GetData
    Dim textBoxArray As New List(Of String)()


    Public Function RegisterPatient(ByVal data As String) As Int32

        'Dim column As String = String.Join(",", )

        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = $"INSERT INTO PATIENTT ({GetColumn("PATIENTT")}) VALUES ({String.Join(",", data)})"
            Console.WriteLine(sql)
            Dim cmd As New OracleCommand(sql, connection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Register success")
            connection.Close()
            Return 1
        Catch ex As OracleException When ex.Number = 1 AndAlso ex.Message.Contains("UNI_PATIENTT")
            ' จัดการกับข้อผิดพลาดที่เกิดจาก unique constraint violation
            MessageBox.Show("cid is already exist")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            Return 0
        End Try

    End Function

    Public Function GetColumn(ByVal table)
        ' สร้างเชื่อมต่อกับ Oracle Database

        Dim connection As New OracleConnection(Connect())
        connection.Open()

        ' สร้าง SQL query เพื่อดึงโครงสร้างของตาราง "patients"
        Dim tableName As String = table
        Dim sql As String = $"SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME = '{tableName}'"
        Dim cmd As New OracleCommand(sql, connection)

        ' สร้าง List เพื่อเก็บชื่อคอลัมน์
        Dim columnNames As New List(Of String)()

        ' อ่านข้อมูลจากคำสั่ง SQL และเพิ่มชื่อคอลัมน์ลงใน List
        Using reader As OracleDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim columnName As String = reader.GetString(0)
                Console.WriteLine("Tex8:" & columnName)
                columnNames.Add(columnName)
            End While
        End Using
        Console.WriteLine(sql)
        ' ปิดการเชื่อมต่อ
        connection.Close()

        ' แปลง List เป็น Array
        Dim columnArray As String() = columnNames.ToArray()
        Dim column As String = String.Join(",", columnArray)
        Console.WriteLine("ss" & column)
        Return column
    End Function
End Module
