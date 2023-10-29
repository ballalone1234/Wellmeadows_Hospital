Public Class SelectFunction
    Public Func1 As Action
    Public Func2 As Action
    Public Func3 As Action

    Public Func4 As Action

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Func1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Func2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Func3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Func4()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class