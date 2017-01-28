Module Module1

    Sub Main()
        Dim guess, secret As Integer

        guess = 0
        secret = 0

        Randomize()
        secret = Int((Rnd() * 100) + 1)

        Console.WriteLine("A secret number between 1 and 100 has been chosen!!!")
        Console.WriteLine("Guess the secret number, you have 10 tries")

        'For i = 0 To 100
        '    secret = Int((Rnd() * 100) + 1)
        '    Console.WriteLine(secret)
        'Next



        Dim count As Integer
        count = 0

        Do

            guess = Int(Console.ReadLine())

            count = count + 1

            If guess = secret Then
                Console.WriteLine("You guessed correct with " & count & " tries")
                Exit Do
            Else
                If guess > secret Then
                    Console.WriteLine("You guessed too high")
                Else
                    Console.WriteLine("You guessed too low")
                End If
            End If

        Loop While count < 10

        If count >= 10 Then
            Console.WriteLine("You took too many guess, sorry you lost")
            Console.WriteLine("The secret number was " & secret)
        End If

    End Sub

End Module
