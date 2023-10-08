Imports Oracle.ManagedDataAccess.Client
Imports Wellmeadows_Hospital_1101173.Hospital

Public Class PrescribeMenu
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

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrescribeMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim connection As New OracleConnection(Connect())
        connection.Open()
        Dim sql As String = "SELECT PATIENT_NUM   , PATIENT_NAME  FROM detail_current_patients_in_ward
UNION
SELECT PATIENT_NUM , PATIENT_NAME FROM detail_allocate_opd
   "
        Dim command As New OracleCommand(sql, connection)
        Dim reader As OracleDataReader = command.ExecuteReader()
        ' เซ็ต DisplayMember เป็นชื่อคอลัมน์ที่คุณต้องการให้แสดงใน ComboBox
        ptno.DisplayMember = "PATIENT_NAME"

        ' เซ็ต ValueMember เป็นชื่อคอลัมน์ที่คุณต้องการให้เป็นค่า value ของ ComboBox
        ptno.ValueMember = "PATIENT_NUM"

        While reader.Read()
            ' เพิ่มข้อมูลลงใน ComboBox โดยใช้ชื่อคอลัมน์ที่ต้องการแสดง
            ptno.Items.Add(New With {.PATIENT_NAME = reader("PATIENT_NAME").ToString(), .PATIENT_NUM = reader("PATIENT_NUM").ToString()})
            Console.WriteLine(reader("PATIENT_NUM"))
        End While
        reader.Close()
        connection.Close()
        ptno.Height = 100
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub
End Class