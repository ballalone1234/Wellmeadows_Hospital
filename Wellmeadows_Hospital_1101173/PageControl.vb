Module PageControl

    Dim pages As New List(Of Form)
    Public Function NextPage(ByVal formMe As Form, ByVal formNext As Form) As Form
        pages.Add(formMe)
        SwichPage(formMe, formNext)
        Console.WriteLine(pages)
    End Function


    Public Function BackPage(ByVal formMe As Form)
        SwichPage(formMe, pages(pages.Count - 1))
        pages.Remove(pages(pages.Count - 1))
    End Function

    Public Function SwichPage(ByVal formMe As Form, ByVal formNext As Form)
        formMe.Hide()
        formNext.Show()
    End Function
End Module
