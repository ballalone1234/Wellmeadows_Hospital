Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Oracle.ManagedDataAccess.Client

Public Class RegisterPatient2
    Public param As List(Of String)
    Public p_id As Int32
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)

    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        param.Add($"'{ml_no.SelectedItem.ToString()}'")
        Dim result As Int32 = RegisPatient(String.Join(",", param))
        If result > 0 Then

            NextPage(Me, RegisterPatient3)
            p_id = result
            RegisterPatient4.pid = result
        End If
    End Sub



    Private Sub RegisterPatient2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim sql As String = "SELECT ML_NO FROM LOCALDOCTOR"
        Dim command As New OracleCommand(sql, connection)
        Dim reader As OracleDataReader = command.ExecuteReader()
        While reader.Read()
            ml_no.Items.Add(reader("ML_NO").ToString()) ' column_name คือชื่อคอลัมน์ที่คุณต้องการใส่ใน ComboBox
        End While
        reader.Close()
        connection.Close()
        ml_no.Height = 100
        Console.WriteLine(String.Join(",", param))
    End Sub

    Private Sub ml_no_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ml_no.SelectedIndexChanged
        Dim selectedValue As String = ml_no.SelectedItem.ToString()

        ' เชื่อมต่อกับฐานข้อมูล Oracle โดยใช้ Connection String


        Dim connection As New OracleConnection(Connect())

        ' สร้างคำสั่ง SQL ด้วย WHERE clause เพื่อกรองข้อมูลที่เลือก
        Dim sql As String = $"SELECT * FROM LOCALDOCTOR WHERE ML_NO = '{selectedValue}'"

        ' สร้าง OracleCommand
        Dim command As New OracleCommand(sql, connection)



        ' เปิดการเชื่อมต่อ
        connection.Open()

        ' สร้าง OracleDataReader เพื่ออ่านข้อมูล
        Dim reader As OracleDataReader = command.ExecuteReader()

        ' นำข้อมูลที่เหลือมาแสดง
        While reader.Read()
            ' ทำสิ่งที่คุณต้องการกับข้อมูลที่ถูกดึงมา ยกตัวอย่างเช่นแสดงใน TextBox หรือ ListBox
            ' ตัวอย่าง: TextBox1.Text = reader("column_name").ToString()
            docname.Text = reader("DOC_NAME").ToString()
            clinic.Text = reader("CLINIC_NUM").ToString()
            Address.Text = reader("ADDRESS").ToString()
            tel.Text = reader("TEL").ToString()
        End While

        ' ปิดการเชื่อมต่อและปล่อยทรัพยากร

        reader.Close()
        connection.Close()
    End Sub
End Class