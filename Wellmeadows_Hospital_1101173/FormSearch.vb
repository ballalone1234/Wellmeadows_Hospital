Public Class FormSearch
    Public seachTable As String = ""
    Public returnText As TextBox
    Public returnRows As Object
    Public cellColumn As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataSearch.DataSource = GetSeach(seachTable, search.Text)
    End Sub

    Public Sub search_KeyUp(sender As Object, e As KeyEventArgs) Handles search.KeyUp
        DataSearch.DataSource = GetSeach(seachTable, search.Text)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataSearch.CellClick


        Dim cellValue As Object = DataSearch.Rows(e.RowIndex).Cells(CellColumn).Value
        returnText.Text = cellValue.ToString()

        Debug.Write(DataSearch.Rows(e.RowIndex))
        Dim result As DialogResult = MessageBox.Show($"Do you want to select {cellValue.ToString()} ?", "Confirmation", MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then
            returnText.Text = cellValue.ToString()
            Me.Close()
        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Cancel Then

        End If
    End Sub
End Class