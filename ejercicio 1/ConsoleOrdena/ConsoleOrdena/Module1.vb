Module Module1

    Sub Main()
        Console.WriteLine("Ingrese Primer Nro")
        Dim a As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese Segundo Nro")
        Dim b As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese Tercer Nro")
        Dim c As Integer = Integer.Parse(Console.ReadLine())
        Dim K

        Console.Write("Orden Decendente: ")
        If a > b AndAlso a > c Then
            GoTo caso1
        ElseIf b > a AndAlso b > c Then
            GoTo caso2
        Else
            GoTo caso3
        End If
caso1:
        If b < c Then
            Console.Write("{0}, {1}, {2}", a, c, b)
        Else
            Console.Write("{0}, {1}, {2}", a, b, c)
        End If
        GoTo Fin
caso2:
        If a < c Then
            Console.Write("{0}, {1}, {2}", b, c, a)
        Else
            Console.Write("{0}, {1}, {2}", b, a, c)
        End If
        GoTo Fin
caso3:
        If a < b Then
            Console.Write("{0}, {1}, {2}", c, b, a)
        Else
            Console.Write("{0}, {1}, {2}", c, a, b)
        End If
        GoTo Fin
Fin:
        Dim x = Console.ReadKey


    End Sub

End Module
