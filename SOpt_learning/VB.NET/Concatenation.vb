Option Strict On
Imports System

Public Module Module1
	Public Sub Main()
		Console.WriteLine(2 + 1) 'dentro do esperado
		Console.WriteLine(2 & 1) 'pra mim essa linha deveria gerar erro
'		Console.WriteLine("2" + 1) 'não compila
		Console.WriteLine("2" & 1) 'dentro do esperado
		Console.WriteLine("2" + "1") 'dentro do esperado
		Console.WriteLine("2" & "1") 'dentro do esperado
	End Sub
End Module

'https://pt.stackoverflow.com/q/154231/101
