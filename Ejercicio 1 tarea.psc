Algoritmo sin_titulo
	Definir angulo, rad, resultado Como Real
    Definir opcion Como Entero
	
    Escribir "Ingrese el ángulo en grados:"
    Leer angulo
	
    // Convertir a radianes
    rad <- angulo * PI / 180
	
    Escribir "Seleccione la función:"
    Escribir "1  Seno"
    Escribir "2  Coseno"
    Escribir "3  Tangente"
    Leer opcion
	
    Segun opcion Hacer
        1:
            resultado <- Sen(rad)
            Escribir "Seno: ", resultado
        2:
            resultado <- Cos(rad)
            Escribir "Coseno: ", resultado
        3:
            resultado <- Tan(rad)
            Escribir "Tangente: ", resultado
        De Otro Modo:
            Escribir "Opción no válida"
    FinSegun
FinAlgoritmo
