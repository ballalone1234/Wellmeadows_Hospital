Imports Oracle.ManagedDataAccess.Client


Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click

        Dim table As String = "staff"


        Using connection As New OracleConnection(Connect())
            Try
                connection.Open()

                ' เมื่อเชื่อมต่อกับ Oracle สำเร็จ ให้ดำเนินการตรวจสอบการล็อกอิน
                Dim sql As String = $"SELECT COUNT(*) FROM {table} WHERE STAFF_NUM = :Username"
                Using command As New OracleCommand(sql, connection)
                    command.Parameters.Add(New OracleParameter("Username", txtUsername.Text))

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If result > 0 Then
                        MessageBox.Show("ล็อกอินสำเร็จ!")
                        NextPage(Me, MainMenu)
                        ' ทำสิ่งที่คุณต้องการหลังจากล็อกอินสำเร็จ
                    Else
                        MessageBox.Show("ล็อกอินล้มเหลว กรุณาตรวจสอบชื่อผู้ใช้งานและรหัสผ่าน")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อกับฐานข้อมูล: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
