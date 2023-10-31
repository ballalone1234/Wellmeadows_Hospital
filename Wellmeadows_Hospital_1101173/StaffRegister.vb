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

    Private Sub ptno_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sex As String = ""
        If sexmale.Checked Then
            sex = "male"
        ElseIf sexfemale.Checked Then
            sex = "female"
        End If
        Dim data() As String = {$"STAFF_SEQ.NEXTVAL ", $"'{position.SelectedItem}'", $"'{staff_name.Text}'", $"'{address.Text}'", $"TO_DATE('{DOB.Value.ToString("yyyy-MM-dd")}','YYYY-MM-DD')", $"'{sex}'",
            $"'{work_location.Text}'", $"'{salary.Text}'", $"'{NIN.Text}'", $"'{tel.Text}'", $"'{worked_per_week.Text}'", $"'{work_type.SelectedItem}'", $"'{payment_type.SelectedItem}'", $"'{salary_level.Text}'"}
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
            NextPage(Me, StaffList)
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ADD2Button_Click(sender As Object, e As EventArgs) Handles ADD2Button.Click
        Dim row As String() = {Organi.Text, Pos.Text, startdate.Value.ToString("yyyy-MM-dd"), eeedate.Value.ToString("yyyy-MM-dd")}

        WorkExp.Rows.Add(row)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As String() = {inst.Text, qua_type.Text, qua_date.Value.ToString("yyyy-MM-dd")}

        Qua_g.Rows.Add(row)
    End Sub

    Private Sub position_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub staff_name_TextChanged(sender As Object, e As EventArgs) Handles staff_name.TextChanged

    End Sub

    Private Sub Panel30_Paint(sender As Object, e As PaintEventArgs) Handles Panel30.Paint

    End Sub

    Private Sub Panel38_Paint(sender As Object, e As PaintEventArgs) Handles Panel38.Paint

    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub Panel32_Paint(sender As Object, e As PaintEventArgs) Handles Panel32.Paint

    End Sub

    Private Sub Panel29_Paint(sender As Object, e As PaintEventArgs) Handles Panel29.Paint

    End Sub

    Private Sub Qua_g_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Qua_g.CellContentClick

    End Sub

    Private Sub Panel35_Paint(sender As Object, e As PaintEventArgs) Handles Panel35.Paint

    End Sub

    Private Sub Panel39_Paint(sender As Object, e As PaintEventArgs) Handles Panel39.Paint

    End Sub

    Private Sub qua_type_TextChanged(sender As Object, e As EventArgs) Handles qua_type.TextChanged

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

    End Sub

    Private Sub Panel33_Paint(sender As Object, e As PaintEventArgs) Handles Panel33.Paint

    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged

    End Sub

    Private Sub Panel23_Paint(sender As Object, e As PaintEventArgs) Handles Panel23.Paint

    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint

    End Sub

    Private Sub Panel24_Paint(sender As Object, e As PaintEventArgs) Handles Panel24.Paint

    End Sub

    Private Sub eeedate_ValueChanged(sender As Object, e As EventArgs) Handles eeedate.ValueChanged

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Panel25_Paint(sender As Object, e As PaintEventArgs) Handles Panel25.Paint

    End Sub

    Private Sub Panel26_Paint(sender As Object, e As PaintEventArgs) Handles Panel26.Paint

    End Sub

    Private Sub Pos_TextChanged(sender As Object, e As EventArgs) Handles Pos.TextChanged

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Panel20_Paint(sender As Object, e As PaintEventArgs) Handles Panel20.Paint

    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint

    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub Panel18_Paint(sender As Object, e As PaintEventArgs) Handles Panel18.Paint

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs) Handles Panel15.Paint

    End Sub

    Private Sub worked_per_week_TextChanged(sender As Object, e As EventArgs) Handles worked_per_week.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub salary_level_TextChanged(sender As Object, e As EventArgs) Handles salary_level.TextChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DOB_ValueChanged(sender As Object, e As EventArgs) Handles DOB.ValueChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub sexfemale_CheckedChanged(sender As Object, e As EventArgs) Handles sexfemale.CheckedChanged

    End Sub

    Private Sub sexmale_CheckedChanged(sender As Object, e As EventArgs) Handles sexmale.CheckedChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub address_TextChanged(sender As Object, e As EventArgs) Handles address.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub work_location_TextChanged(sender As Object, e As EventArgs) Handles work_location.TextChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub NIN_TextChanged(sender As Object, e As EventArgs) Handles NIN.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub tel_TextChanged(sender As Object, e As EventArgs) Handles tel.TextChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel17_Paint(sender As Object, e As PaintEventArgs) Handles Panel17.Paint

    End Sub

    Private Sub work_type_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub WorkExp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles WorkExp.CellContentClick

    End Sub

    Private Sub Panel22_Paint(sender As Object, e As PaintEventArgs) Handles Panel22.Paint

    End Sub

    Private Sub startdate_ValueChanged(sender As Object, e As EventArgs) Handles startdate.ValueChanged

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Panel21_Paint(sender As Object, e As PaintEventArgs) Handles Panel21.Paint

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Organi_TextChanged(sender As Object, e As EventArgs) Handles Organi.TextChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub salary_TextChanged(sender As Object, e As EventArgs) Handles salary.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Panel28_Paint(sender As Object, e As PaintEventArgs) Handles Panel28.Paint

    End Sub

    Private Sub Panel34_Paint(sender As Object, e As PaintEventArgs) Handles Panel34.Paint

    End Sub

    Private Sub Panel37_Paint(sender As Object, e As PaintEventArgs) Handles Panel37.Paint

    End Sub

    Private Sub qua_date_ValueChanged(sender As Object, e As EventArgs) Handles qua_date.ValueChanged

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Panel36_Paint(sender As Object, e As PaintEventArgs) Handles Panel36.Paint

    End Sub

    Private Sub inst_TextChanged(sender As Object, e As EventArgs) Handles inst.TextChanged

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Panel31_Paint(sender As Object, e As PaintEventArgs) Handles Panel31.Paint

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class