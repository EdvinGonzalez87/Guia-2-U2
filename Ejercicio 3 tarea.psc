Algoritmo sin_titulo
	Definir sector, cantidad Como Entero
    Definir precio, total Como Real
	
    Escribir "===== ESTADIO ====="
    Escribir "1  Palco (Q300.00)"
    Escribir "2  Tribuna (Q100 - Q125)"
    Escribir "3  Preferencia (Q50 - Q75)"
    Escribir "4  Generales (Q30 - Q50)"
    Escribir "Seleccione el sector:"
    Leer sector
	
    Escribir "Ingrese la cantidad de entradas:"
    Leer cantidad
	
    Segun sector Hacer
        1:
            precio <- 300
        2:
            Escribir "Ingrese el precio (entre Q100 y Q125):"
            Leer precio
            Si precio < 100 O precio > 125 Entonces
                Escribir "Precio fuera de rango"
                precio <- 0
            FinSi
        3:
            Escribir "Ingrese el precio (entre Q50 y Q75):"
            Leer precio
            Si precio < 50 O precio > 75 Entonces
                Escribir "Precio fuera de rango"
                precio <- 0
            FinSi
        4:
            Escribir "Ingrese el precio (entre Q30 y Q50):"
            Leer precio
            Si precio < 30 O precio > 50 Entonces
                Escribir "Precio fuera de rango"
                precio <- 0
            FinSi
        De Otro Modo:
            Escribir "Opción no válida"
            precio <- 0
    FinSegun
	
    total <- precio * cantidad
    Escribir "Total a pagar: Q", total
FinAlgoritmo
