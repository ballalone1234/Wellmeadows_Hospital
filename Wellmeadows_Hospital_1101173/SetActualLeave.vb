Public Class SetActualLeave


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PatientList.SetActual(Getdate(DateTimePicker1))
        Close()
        SelectFunction.Close()
    End Sub
End Class