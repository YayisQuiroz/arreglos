Module module1

    Sub Main(args As String())
        ' Crear un arreglo de 3x3'
        Dim arreglo(2, 2) As Integer

        ' Llenar el arreglo con algunos valores'
        arreglo(0, 0) = 1
        arreglo(0, 1) = 2
        arreglo(0, 2) = 3
        arreglo(1, 0) = 4
        arreglo(1, 1) = 5
        arreglo(1, 2) = 6
        arreglo(2, 0) = 7
        arreglo(2, 1) = 8
        arreglo(2, 2) = 9

        ' Recorrer el arreglo y mostrar sus valores'
        Console.WriteLine("Los valores en el arreglo son:")
        For i As Integer = 0 To 2
            Dim sumaFila As Integer = 0
            For j As Integer = 0 To 2
                Console.Write(arreglo(i, j) & " ")
                sumaFila += arreglo(i, j)
            Next
            Console.Write(" (suma de la fila: " & sumaFila & ")")
            Console.WriteLine()
        Next

        ' Esperar a que el usuario presione una tecla para salir'
        Console.ReadKey()
    End Sub
End Module
