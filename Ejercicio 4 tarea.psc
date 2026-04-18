Algoritmo sin_titulo
	Definir opcion Como Entero
    Definir valor, metros, pies, cm, pulgadas Como Real
	
    Escribir "===== CONVERSOR DE LONGITUD ====="
    Escribir "1 Metros?"
    Escribir "2 Pies?"
    Escribir "3 Centímetros?"
    Escribir "4 Pulgadas?"
    Escribir "Seleccione la unidad de origen:"
    Leer opcion
	
    Escribir "Ingrese el valor:"
    Leer valor
	
    // Convertir a metros
    Segun opcion Hacer
        1:
            metros <- valor
        2:
            metros <- valor * 0.3048
        3:
            metros <- valor / 100
        4:
            metros <- valor * 0.0254
        De Otro Modo:
            Escribir "Opción no válida"
            metros <- 0
    FinSegun
	
    // Convertir desde metros a todas las unidades
    pies <- metros / 0.3048
    cm <- metros * 100
    pulgadas <- metros / 0.0254
	
    Escribir "===== RESULTADOS ====="
    Escribir "Metros: ", metros
    Escribir "Pies: ", pies
    Escribir "Centímetros: ", cm
    Escribir "Pulgadas: ", pulgadas
FinAlgoritmo
