Module OC
    Public Function Connect() As String
        Dim host As String = "digilab.sut.ac.th:1521/XEPDB1"
        Dim password As String = "1095"
        Dim username As String = "B6301095"
        Dim connectionString As String = $"DATA SOURCE={host};PASSWORD={password};USER ID={username};"
        Return connectionString
    End Function

End Module
