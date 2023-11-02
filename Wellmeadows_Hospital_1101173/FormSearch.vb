Public Class FormSearch
    Public seachTable As String = ""
    Public returnText As TextBox
    Public returnMode As Boolean = False
    Public singleMode As Boolean = False
    Public returnRows As Object
    Public cellColumn As String
    Public Order As String = ""
    Public func As Action
    Private OrderMode As Boolean = False
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If singleMode Then
            DataSearch.DataSource = GetSeach2(seachTable, search.Text)
        Else
            DataSearch.DataSource = GetSeach(seachTable, search.Text)
        End If
    End Sub

    Public Sub search_KeyUp(sender As Object, e As KeyEventArgs) Handles search.KeyUp
        If singleMode Then
            DataSearch.DataSource = GetSeach2(seachTable, search.Text)
        Else
            DataSearch.DataSource = GetSeach(seachTable, search.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataSearch.CellClick


        Dim cellValue As Object = DataSearch.Rows(e.RowIndex).Cells(cellColumn).Value
        returnText.Text = cellValue.ToString()

        Debug.Write(DataSearch.Rows(e.RowIndex))
        Dim result As DialogResult = MessageBox.Show($"Do you want to select {cellValue.ToString()} ?", "Confirmation", MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then
            returnText.Text = cellValue.ToString()
            If returnMode Then
                Me.Close()

                func()
            Else
                Me.Close()

            End If
        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Cancel Then

        End If
    End Sub

    Private Sub FormSearch_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SelectFunction.Hide()
    End Sub

    Private Sub OrderBTN_Click(sender As Object, e As EventArgs) Handles OrderBTN.Click
        If Not OrderMode Then
            Order = $" ORDER BY {cellColumn} DESC "
            If singleMode Then
                DataSearch.DataSource = GetSeach2(seachTable, search.Text)
            Else
                DataSearch.DataSource = GetSeach(seachTable, search.Text)
            End If
        Else
            Order = $" ORDER BY {cellColumn} ASC "
            If singleMode Then
                DataSearch.DataSource = GetSeach2(seachTable, search.Text)
            Else
                DataSearch.DataSource = GetSeach(seachTable, search.Text)
            End If
        End If
        OrderMode = Not OrderMode
    End Sub
End Class