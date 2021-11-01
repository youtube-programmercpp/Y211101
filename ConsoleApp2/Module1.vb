Module Module1

    Sub Main()
        Dim a(2)
        a(0) = "偶数"
        a(1) = "奇数"
        Dim x As Integer = 4
        System.Diagnostics.Debug.WriteLine(a(x And 1))
    End Sub

End Module
