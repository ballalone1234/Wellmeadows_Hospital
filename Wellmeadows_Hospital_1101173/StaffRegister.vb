Imports Oracle.ManagedDataAccess.Client

Public Class StaffRegister
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Pagecontroller.NextPage(Me, MainMenu)


    End Sub



    Private Sub Back_Click_1(sender As Object, e As EventArgs) Handles Back.Click
        Pagecontroller.BackPage(Me)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs)
        Pagecontroller.NextPage(Me, RegisterPatient2)
    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub ptno_TextChanged(sender As Object, e As EventArgs) Handles staff_no.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sex As String = ""
        If sexmale.Checked Then
            sex = "male"
        ElseIf sexfemale.Checked Then
            sex = "female"
        End If
        Dim data() As String = {$"STAFF_SEQ.NEXTVAL ", $"'{position.Text}'", $"'{staff_name.Text}'", $"'{address.Text}'", $"TO_DATE('{DOB.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')", $"'{sex}'",
            $"'{work_location.Text}'", $"'{salary.Text}'", $"'{NIN.Text}'", $"'{tel.Text}'", $"'{worked_per_week.Text}'", $"'{work_type.Text}'", $"'{payment_type.Text}'", $"'{salary_level.Text}'"}
        Dim result As Int32 = RegisStaff(String.Join(",", data))
        If result > 0 Then
            MessageBox.Show("ลงทะเบียนบุคลากรสำเร็จ")
            Dim connection As New OracleConnection(Connect())
            connection.Open()
            For Each row As DataGridViewRow In WorkExp.Rows
                Dim organi = row.Cells(0).Value
                Dim Pos = row.Cells(1).Value
                Dim Stat = row.Cells(2).Value
                Dim Endd = row.Cells(3).Value
                Dim sql = $"INSERT INTO WORKEXP(ID_W,STAFF_NUM,POSITION,ORG_NAME,DATE_END,DATE_START) 
                VALUES(WORKEXP_SEQ.NEXTVAL , '{result}' , '{Pos}' , '{organi}' , TO_DATE('{Stat}','YYYY-MM-DD') ,TO_DATE('{Endd}','YYYY-MM-DD'))"
                Dim cmd As New OracleCommand(sql, connection)
                cmd.ExecuteNonQuery()
            Next
            For Each row As DataGridViewRow In Qua_g.Rows
                Dim ins = row.Cells(0).Value
                Dim type = row.Cells(1).Value
                Dim date_r = row.Cells(2).Value


                Dim sql = $"INSERT INTO QUALIFICATION(ID_Q,STAFF_NUM,INSTITUTION_NAME,DATE_OF_QUALIFICATION,TYPE) 
                VALUES(QUA_SEQ.NEXTVAL , '{result}' , '{ins}' , TO_DATE('{date_r}','YYYY-MM-DD') , '{type}')"
                Dim cmd As New OracleCommand(sql, connection)
                cmd.ExecuteNonQuery()
            Next

        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles payment_type.TextChanged

    End Sub

    Private Sub ADD2Button_Click(sender As Object, e As EventArgs) Handles ADD2Button.Click
        Dim row As String() = {Organi.Text, Pos.Text, startdate.Value.ToString("yyyy-MM-dd"), eeedate.Value.ToString("yyyy-MM-dd")}

        WorkExp.Rows.Add(row)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As String() = {inst.Text, qua_type.Text, qua_date.Value.ToString("yyyy-MM-dd")}

        Qua_g.Rows.Add(row)
    End Sub
End Class