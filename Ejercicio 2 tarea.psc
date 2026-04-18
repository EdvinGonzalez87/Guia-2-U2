Algoritmo sin_titulo
	Definir c Como Caracter
	
    Escribir "Ingrese un carácter:"
    Leer c
	
    c <- Minusculas(c)
	
    Si c = "a" O c = "e" O c = "i" O c = "o" O c = "u" Entonces
        Escribir "Es una vocal"
    Sino
        Si c >= "0" Y c <= "9" Entonces
            Escribir "Es un dígito"
        Sino
            Escribir "No es vocal ni dígito"
        FinSi
    FinSi
FinAlgoritmo
