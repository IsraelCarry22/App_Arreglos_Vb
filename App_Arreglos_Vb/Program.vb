Imports System

Module Program
    Sub Main(args As String())
        Dim Tc As Integer
        Dim cont As Integer = 1
        Console.WriteLine("========== Conversiones Temperatura ==========" & vbLf)
        Console.Write("Ingresa las cant de temperaturas: ")
        Tc = Integer.Parse(Console.ReadLine())
        Dim temperatura As Integer() = New Integer(Tc - 1) {}

        For i As Integer = 0 To temperatura.Length - 1
            Console.WriteLine(vbLf & "Ingresa la temperatura: ")
            temperatura(i) = Integer.Parse(Console.ReadLine())
        Next

        Dim ResultadoF_C As Double() = New Double(Tc - 1) {}

        For i As Integer = 0 To ResultadoF_C.Length - 1
            ResultadoF_C(i) = (1.8 * temperatura(i)) + 32
        Next

        Dim ResultadoK_C As Double() = New Double(Tc - 1) {}

        For i As Integer = 0 To ResultadoK_C.Length - 1
            ResultadoK_C(i) = temperatura(i) + 273.15
        Next

        Dim ResultadoK_F As Double() = New Double(Tc - 1) {}

        For i As Integer = 0 To ResultadoK_F.Length - 1
            ResultadoK_F(i) = 1.8 * (ResultadoK_C(i) - 273.15) + 32
        Next

        Console.Clear()
        Console.WriteLine(vbLf & "Tus temperaturas de Centigrada a Fahrenheit.")

        For i As Integer = 0 To ResultadoF_C.Length - 1
            Console.WriteLine(cont & "°. " & ResultadoF_C(i))
            cont += 1
        Next

        cont = 1
        Console.WriteLine(vbLf & "Tus temperaturas de Centigrada a Kelvin.")

        For i As Integer = 0 To ResultadoK_C.Length - 1
            Console.WriteLine(cont & "°. " & ResultadoK_C(i))
            cont += 1
        Next

        cont = 1
        Console.WriteLine(vbLf & "Tus temperaturas de Kelvin a Fahrenheit.")

        For i As Integer = 0 To ResultadoK_F.Length - 1
            Console.WriteLine(cont & "°. " & ResultadoK_F(i))
            cont += 1
        Next
        Console.ReadKey()
    End Sub
End Module
