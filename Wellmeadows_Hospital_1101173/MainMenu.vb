﻿Public Class MainMenu
    Private Sub patienticon_Click_2(sender As Object, e As EventArgs) Handles patienticon.Click
        Pagecontroller.NextPage(Me, PatientMenu)

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dashboardicon_Click(sender As Object, e As EventArgs) Handles dashboardicon.Click
        Pagecontroller.NextPage(Me, Dashboard)
    End Sub

    Private Sub wardicon_Click(sender As Object, e As EventArgs) Handles wardicon.Click
        Pagecontroller.NextPage(Me, Wardlist)
    End Sub

    Private Sub supileicon_Click(sender As Object, e As EventArgs) Handles supileicon.Click
        Pagecontroller.NextPage(Me, SuppliesMenu)
    End Sub
End Class