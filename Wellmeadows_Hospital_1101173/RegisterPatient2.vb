Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.ReportingServices
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
        param.Add($"'{ML_NO.Text}'")
        Dim result As Int32 = RegisPatient(String.Join(",", param))
        If result > 0 Then

            NextPage(Me, RegisterPatient3)
            p_id = result
            RegisterPatient4.pid = result
        End If
    End Sub








    Private Sub ML_NO_TextChanged(sender As Object, e As EventArgs) Handles ML_NO.Click
        FormSearch.seachTable = "LOCALDOCTOR"
        FormSearch.cellColumn = "ML_NO"
        FormSearch.returnText = ML_NO
        FormSearch.returnMode = True
        FormSearch.func = AddressOf FetchData
        FormSearch.Show()
    End Sub

    Public Sub FetchData()
        Dim reader As OracleDataReader = GetData.Getdata(ML_NO.Text, "ML_NO", "LOCALDOCTOR", " ")
        While reader.Read()
            docname.Text = reader("DOC_NAME").ToString()
            clinic.Text = reader("CLINIC_NUM").ToString()
            Address.Text = reader("ADDRESS").ToString()
            tel.Text = reader("TEL").ToString()
        End While
    End Sub
End Class