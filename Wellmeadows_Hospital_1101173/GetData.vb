Imports Microsoft.Reporting.Map.WebForms.BingMaps
Imports Oracle.ManagedDataAccess.Client

Module GetData
    Public pa_id As String
    Public staff_id As String = "1101"
    Dim dataAdd As New List(Of String)()
    Public Function SavePatient(ByVal data As List(Of String))
        dataAdd = data
    End Function
    Public Function SaveDc(ByVal data As String)
        dataAdd.Add(data)
    End Function

    Public Function GetSeq()
        Dim connection As New OracleConnection(Connect())
        connection.Open()

        ' สร้างคำสั่ง SQL สำหรับเรียกใช้ค่าจาก Sequence
        Dim getSequenceSql As String = "SELECT patient_seq.CURRVAL FROM DUAL"
        Dim cmd As New OracleCommand(getSequenceSql, connection)

        ' สร้างตัวแปรเพื่อเก็บค่าที่ได้จาก Sequence
        Dim generatedPatientNum As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())

        ' ตอนนี้ค่า generatedPatientNum จะเป็นค่าล่าสุดที่ได้จาก Sequence
        Console.WriteLine("Generated PATIENT_NUM: " & generatedPatientNum)
        Return generatedPatientNum
        connection.Close()
    End Function

    Public Function GetSeqq(seq)
        Dim connection As New OracleConnection(Connect())
        connection.Open()

        ' สร้างคำสั่ง SQL สำหรับเรียกใช้ค่าจาก Sequence
        Dim getSequenceSql As String = $"SELECT {seq}.CURRVAL FROM DUAL"
        Dim cmd As New OracleCommand(getSequenceSql, connection)

        ' สร้างตัวแปรเพื่อเก็บค่าที่ได้จาก Sequence
        Dim generatedPatientNum As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())

        ' ตอนนี้ค่า generatedPatientNum จะเป็นค่าล่าสุดที่ได้จาก Sequence
        Console.WriteLine("Generated PATIENT_NUM: " & generatedPatientNum)
        Return generatedPatientNum
        connection.Close()
    End Function

    Public Function GetSeqStaff() As Int32
        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = "SELECT MAX(STAFF_NUM) FROM STAFF"
            Dim cmd As New OracleCommand(sql, connection)
            Dim maxStaffNum As Object = cmd.ExecuteScalar()
            connection.Close()
            If maxStaffNum IsNot Nothing AndAlso Int32.TryParse(maxStaffNum.ToString(), maxStaffNum) Then
                Return maxStaffNum
            Else
                Return 0
            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            Return 0
        End Try
    End Function
    Public Function RegisPatient(ByVal data As String)
        Dim col() As String = {"PATIENT_NUM", "PATIENT_NAME", "MARITAL_STATUS", "DATE_REGIST", "DOB", "TELEPHONE", "CID", "ADDRESS", "SEX", "ML_NO"}
        'Dim column As String = String.Join(",", )

        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = $"INSERT INTO PATIENTS ({String.Join(",", col)}) VALUES ({String.Join(",", data)})"
            Dim cmd As New OracleCommand(sql, connection)



            cmd.ExecuteNonQuery()
            connection.Close()

            Return 1
        Catch ex As OracleException When ex.Number = 1 AndAlso ex.Message.Contains("PATIENTS_UK1")
            ' จัดการกับข้อผิดพลาดที่เกิดจาก unique constraint violation
            MessageBox.Show("cid is already exist")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            Return 0
        End Try

    End Function

    'ฟังชั้น ดึงข้อมูล patient_num จาก cid
    Public Function GetPatientNum(cid)
        Using connection As New OracleConnection(Connect())
            connection.Open()

            Dim sql As String = $"SELECT patient_num FROM patients WHERE cid = '{cid}'"
            Debug.Write(sql)
            Using command As New OracleCommand(sql, connection)
                Using reader As OracleDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim patientNum As String = reader.GetString(0)
                        Return patientNum
                    Else
                        ' ไม่พบข้อมูลที่ต้องการ
                    End If
                End Using
            End Using
        End Using
    End Function
    Public Function RegisPatientKin(ByVal data As String) As Int32
        'Dim column As String = String.Join(",", )

        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = $"INSERT INTO PATIENTSNEXTOFKIN ({GetColumn("PATIENTSNEXTOFKIN")}) VALUES ({String.Join(",", data)})"
            Console.WriteLine(sql)
            Dim cmd As New OracleCommand(sql, connection)
            cmd.ExecuteNonQuery()

            connection.Close()
            Return 1
        Catch ex As OracleException When ex.Number = 1 AndAlso ex.Message.Contains("PATIENTS_UK1")
            ' จัดการกับข้อผิดพลาดที่เกิดจาก unique constraint violation
            MessageBox.Show("cid is already exist")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            Return 0
        End Try

    End Function

    Public Function Allocate(ByVal data As String, ByVal table As String) As Int32
        'Dim column As String = String.Join(",", )

        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = $"INSERT INTO {table} ({GetColumn(table)}) VALUES ({String.Join(",", data)})"
            Console.WriteLine(sql)
            Dim cmd As New OracleCommand(sql, connection)
            cmd.ExecuteNonQuery()

            connection.Close()
            Return 1
        Catch ex As OracleException When ex.Number = 1 AndAlso ex.Message.Contains("PATIENTS_UK1")
            ' จัดการกับข้อผิดพลาดที่เกิดจาก unique constraint violation
            MessageBox.Show("cid is already exist")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            Return 0
        End Try

    End Function

    Public Function InsetFlexible(ByVal data As String, ByVal table As String) As Int32
        'Dim column As String = String.Join(",", )

        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = $"INSERT INTO {table} ({GetColumn(table)}) VALUES ({String.Join(",", data)})"
            Console.WriteLine(sql)
            Dim cmd As New OracleCommand(sql, connection)
            cmd.ExecuteNonQuery()

            connection.Close()
            Return 1
        Catch ex As OracleException When ex.Number = 1 AndAlso ex.Message.Contains("PATIENTS_UK1")
            ' จัดการกับข้อผิดพลาดที่เกิดจาก unique constraint violation
            MessageBox.Show("cid is already exist")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            Console.WriteLine(ex.Message)
            MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            Return 0
        End Try

    End Function
    Public Function InsetFlexibleMed(ByVal data As String, ByVal table As String) As Int32
        'Dim column As String = String.Join(",", )

        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = $"INSERT INTO {table} ({GetColumn(table)}) VALUES ({String.Join(",", data)})"
            Console.WriteLine(sql)
            Dim cmd As New OracleCommand(sql, connection)
            cmd.ExecuteNonQuery()
            Dim getSequenceSql As String = $"SELECT MH_SEQ.CURRVAL FROM DUAL"
            Dim cmd2 As New OracleCommand(getSequenceSql, connection)

            ' สร้างตัวแปรเพื่อเก็บค่าที่ได้จาก Sequence
            Dim generatedPatientNum As Decimal = Convert.ToDecimal(cmd2.ExecuteScalar())
            Console.WriteLine("Generated PATIENT_NUM: " & generatedPatientNum)
            connection.Close()
            Return generatedPatientNum
        Catch ex As OracleException When ex.Number = 1 AndAlso ex.Message.Contains("PATIENTS_UK1")
            ' จัดการกับข้อผิดพลาดที่เกิดจาก unique constraint violation
            MessageBox.Show("cid is already exist")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            Console.WriteLine(ex.Message)
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

    Public Function RegisStaff(ByVal data As String) As Int32
        Dim col() As String = {"STAFF_NUM", "POSITION", "STAFF_NAME", "ADDRESS", "DOB", "SEX", "WORK_LOCATION", "SALARY", "NIN", "TELL", "WORKED_PER_WEEK", "WORK_TYPE", "PAYMENT_TYPE", "SALARY_LEVEL"}
        'Dim column As String = String.Join(",", )

        Try
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            Dim sql As String = $"INSERT INTO STAFF ({String.Join(",", col)}) VALUES ({String.Join(",", data)})"
            Console.WriteLine(sql)
            Dim cmd As New OracleCommand(sql, connection)
            cmd.ExecuteNonQuery()
            connection.Close()
            Return GetSeqStaff()
        Catch ex As OracleException When ex.Number = 1 AndAlso ex.Message.Contains("PATIENTS_UK1")
            ' จัดการกับข้อผิดพลาดที่เกิดจาก unique constraint violation
            MessageBox.Show("cid is already exist")

        Catch ex As Exception
            ' จัดการข้อผิดพลาดที่เกิดขึ้น
            MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            Return 0
        End Try

    End Function



    Public Function Getdate(ByVal Dd As DateTimePicker)
        Dim date_format As String = $"TO_DATE('{Dd.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')"
        Return date_format
    End Function

    Public Function Getdata(key_id, column, table, where) As OracleDataReader
        Dim Data = New List(Of OracleDataReader)
        Dim connection As New OracleConnection(Connect())

        ' สร้างคำสั่ง SQL ด้วย WHERE clause เพื่อกรองข้อมูลที่เลือก
        Dim sql As String = $"SELECT * FROM {table} WHERE {where} {column} = '{key_id}'"

        ' สร้าง OracleCommand
        Dim command As New OracleCommand(sql, connection)



        ' เปิดการเชื่อมต่อ
        connection.Open()

        ' สร้าง OracleDataReader เพื่ออ่านข้อมูล
        Dim reader As OracleDataReader = command.ExecuteReader()

        ' นำข้อมูลที่เหลือมาแสดง
        Return reader

        ' ปิดการเชื่อมต่อและปล่อยทรัพยากร

        reader.Close()
        connection.Close()
    End Function


    Public Function GetSeach(table, textS)
        Dim column As String = GetColumn(table)
        Dim columArray() As String = Split(column, ",")


        Dim sqltest As String = $"SELECT {column} FROM {table} WHERE "
        For Each item As String In columArray
            sqltest += item + $" like '%{textS}%' OR "

        Next
        sqltest = sqltest.Substring(0, sqltest.Length - 3)
        If table.Equals("ALLOCATEDTO") Then
            sqltest += " AND ACTUAL_LEAVE IS NULL"
        End If

        Console.WriteLine(sqltest)
        Using connection As OracleConnection = New OracleConnection(Connect())
            Dim cmd As New OracleCommand(sqltest, connection)
            Using sda As OracleDataAdapter = New OracleDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetSeach2(table, textS)
        Dim column As String = GetColumn(table)
        Dim columArray() As String = Split(column, ",")


        Dim sqltest As String = $"SELECT {column} FROM {table} WHERE "
        For Each item As String In columArray
            sqltest += item + $" like '{textS}' OR "

        Next
        sqltest = sqltest.Substring(0, sqltest.Length - 3)
        If table.Equals("ALLOCATEDTO") Then
            sqltest += " AND ACTUAL_LEAVE IS NULL"
        End If

        Console.WriteLine(sqltest)
        Using connection As OracleConnection = New OracleConnection(Connect())
            Dim cmd As New OracleCommand(sqltest, connection)
            Using sda As OracleDataAdapter = New OracleDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Function GetDataOnceCol(table, column, id)

        Using connection As New OracleConnection(Connect())
            connection.Open()

            Dim sql As String = $"SELECT {column} FROM {table} WHERE drug_num = '{id}'"
            Debug.Write(sql)
            Using command As New OracleCommand(sql, connection)
                Using reader As OracleDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim drugName As String = reader.GetString(0)
                        Return drugName
                    Else
                        ' ไม่พบข้อมูลที่ต้องการ
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Sub UpdateData(table, column, column_where, id, value)
        Dim query As String = $"UPDATE {table} SET {column} = '{value}' WHERE {column_where} = '{id}'"
        Console.WriteLine(query)
        Using connection As New OracleConnection(Connect())
            Using command As New OracleCommand(query, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data updated successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub UpdateData2(table, column, column_where, id, value)
        Dim query As String = $"UPDATE {table} SET {column} = {value} WHERE {column_where} = '{id}'"
        Console.WriteLine(query)
        Using connection As New OracleConnection(Connect())
            Using command As New OracleCommand(query, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data updated successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    'ฟังชั่น Update ข้อมูล หลายๆข้อมูลใน Column ที่แตกต่างกัน




    'ฟั่งชั่น Delete ข้อมูล
    Public Sub DeleteData(table, column, id)
        Dim query As String = $"DELETE FROM {table} WHERE {column} = '{id}'"
        Console.WriteLine(query)
        Using connection As New OracleConnection(Connect())
            Using command As New OracleCommand(query, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data deleted successfully.")
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Function UpdateBedOrInsertToWaittinglist(bed_num, patient_num, ward_no) As Boolean
        ' สร้าง Connection String สำหรับ Oracle Database
        Dim checkBedWat = GetCountForDash("WATTING_LIST", $" WHERE patient_num  = '{patient_num}'")
        Dim checkBed = GetCountForDash("BED", $" WHERE patient_num IS NULL AND bed_num = '{bed_num}'")
        If checkBedWat >= 1 Then
            MessageBox.Show("อยู่ในคิวแล้ว กรุณารอคิว")
            UpdateData("WATTING_LIST", "BED_NUM", "PATIENT_NUM", patient_num, bed_num)
            Return False
        ElseIf checkBed = 1 Then
            UpdateData("BED", "PATIENT_NUM", "BED_NUM", bed_num, patient_num)
            MessageBox.Show("เตียงว่าง")
            Return True
        Else
            Dim data() As String = {"q_seq.NEXTVAL", bed_num, patient_num, "'false'", "SYSDATE", ward_no}
            InsetFlexible(String.Join(",", data), "WATTING_LIST")
            MessageBox.Show("เตียงไม่ว่าง")
            Return False
        End If

    End Function
    Public Function GetCountForDash(table, where)

        Using connection As New OracleConnection(Connect())
            connection.Open()

            Dim sql As String = $"SELECT COUNT(*) as count FROM {table} {where}"
            Debug.Write(sql)
            Using command As New OracleCommand(sql, connection)
                Using reader As OracleDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim drugName As String = reader.GetString(0)
                        Return drugName
                    Else
                        ' ไม่พบข้อมูลที่ต้องการ
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Sub GetDropdown(comboBox As ComboBox, table As String, display As String, value As String)
        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim sql As String = $"SELECT DISTINCT {display} ,{value} FROM {table}"
        Dim command As New OracleCommand(sql, connection)
        Dim reader As OracleDataReader = command.ExecuteReader()
        ' เซ็ต DisplayMember เป็นชื่อคอลัมน์ที่คุณต้องการให้แสดงใน ComboBox
        comboBox.DisplayMember = "DISPLAY"
        ' เซ็ต ValueMember เป็นชื่อคอลัมน์ที่คุณต้องการให้เป็นค่า value ของ ComboBox
        comboBox.ValueMember = "VALUE"

        While reader.Read()
            ' เพิ่มข้อมูลลงใน ComboBox โดยใช้ชื่อคอลัมน์ที่ต้องการแสดง
            comboBox.Items.Add(New With {.DISPLAY = reader(display).ToString(), .VALUE = reader(value).ToString()})

        End While
        reader.Close()
        connection.Close()
    End Sub

    Public Sub GetDropdown2(comboBox As ComboBox, table As String, display As String, column As String, value As String)
        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim sql As String = $"SELECT DISTINCT {column}  FROM {table}"
        Dim command As New OracleCommand(sql, connection)
        Dim reader As OracleDataReader = command.ExecuteReader()
        ' เซ็ต DisplayMember เป็นชื่อคอลัมน์ที่คุณต้องการให้แสดงใน ComboBox
        comboBox.DisplayMember = "DISPLAY"
        ' เซ็ต ValueMember เป็นชื่อคอลัมน์ที่คุณต้องการให้เป็นค่า value ของ ComboBox
        comboBox.ValueMember = "VALUE"

        While reader.Read()
            ' เพิ่มข้อมูลลงใน ComboBox โดยใช้ชื่อคอลัมน์ที่ต้องการแสดง
            comboBox.Items.Add(New With {.DISPLAY = reader(display).ToString(), .VALUE = reader(value).ToString()})

        End While
        reader.Close()
        connection.Close()
    End Sub
    Public position As String = ""
    'ฟั่งชั่นดึงข้อมูล 1 แถว ในตราง staff และ ดึงมาเฉพาะ staff_name และ position
    Public Function GetStaffNameAndPosition(staff_id)
        Using connection As New OracleConnection(Connect())
            connection.Open()

            Dim sql As String = $"SELECT staff_name, position FROM staff WHERE staff_num = '{staff_id}'"
            Debug.Write(sql)
            Using command As New OracleCommand(sql, connection)
                Using reader As OracleDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim staffName As String = reader.GetString(0)
                        position = reader.GetString(1)
                        Return staffName + " (" + position + ")"
                    Else
                        ' ไม่พบข้อมูลที่ต้องการ
                    End If
                End Using
            End Using
        End Using
    End Function


End Module
