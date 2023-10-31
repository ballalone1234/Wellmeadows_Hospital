Imports System.Reflection.Emit

Public Class Status


    Private Sub Status_user_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = GetStaffNameAndPosition(LoginForm.txtUsername.Text)
    End Sub
End Class