Imports Oracle.ManagedDataAccess.Client

Public Class RegisterPatient4
    Public pid As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)

    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs)
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub SumitButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AlloButton_Click(sender As Object, e As EventArgs) Handles AlloButton.Click
        Pagecontroller.NextPage(Me, AllocatePatient)
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TableLayoutPanel3_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub RegisterPatient4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New OracleConnection(Connect())

        ' สร้างคำสั่ง SQL ด้วย WHERE clause เพื่อกรองข้อมูลที่เลือก
        Dim sql As String = $"SELECT
    A3.PATIENT_NUM    PATIENT_NUM,
    A3.PATIENT_NAME   PATIENT_NAME,
    A3.MARITAL_STATUS MARITAL_STATUS,
    A3.DATE_REGIST    DATE_REGIST,
    A3.DOB            DOB,
    A3.TELEPHONE      TELEPHONE,
    A3.CID            CID,
    A3.ADDRESS       ADDRESS,
    A3.ML_NO          ML_NO,
    A2.ML_NO          ML_NO,
    A2.DOC_NAME      DOC_NAME,
    A2.ADDRESS        LADDRESS,
    A2.TEL            TEL,
    A2.CLINIC_NUM     CLINIC_NUM,
    A1.PATIENT_NUM   PATIENT_NUM,
    A1.KIN_NAME      KIN_NAME,
    A1.ADDRESS        PKADDRESS,
    A1.RELATIONSHIP   RELATIONSHIP,
    A1.TEL            PKTEL
FROM
    PATIENTS         A3,
    LOCALDOCTOR       A2,
   PATIENTSNEXTOFKIN  A1
WHERE
        A3.PATIENT_NUM = A1.PATIENT_NUM
    AND A3.ML_NO = A2.ML_NO
    AND (A3.PATIENT_NUM = '{pid}' OR A3.CID = '{pid}')"

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
            pa_id = reader("PATIENT_NUM").ToString()
            patientno.Text = pa_id
            patientname.Text = reader("PATIENT_NAME").ToString()
            address.Text = reader("ADDRESS").ToString()
            birthday.Text = reader("DOB").ToString()
            maritalstatus.Text = reader("MARITAL_STATUS").ToString()
            medicallicenseno.Text = reader("ML_NO").ToString()
            clinicnumber.Text = reader("CLINIC_NUM").ToString()
            doctorname.Text = reader("DOC_NAME").ToString()
            addresss.Text = reader("LADDRESS").ToString()
            tel.Text = reader("TEL").ToString()
            kinname.Text = reader("KIN_NAME").ToString()
            relationship.Text = reader("RELATIONSHIP").ToString()
            addressss.Text = reader("PKADDRESS").ToString()
            tell.Text = reader("PKTEL").ToString()

        End While

        ' ปิดการเชื่อมต่อและปล่อยทรัพยากร

        reader.Close()
        connection.Close()
    End Sub

End Class