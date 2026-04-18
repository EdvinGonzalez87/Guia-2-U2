Algoritmo sin_titulo
	Definir cantidad Como Entero
    Definir precioUnitario, iva, precioConIVA Como Real
    Definir totalSinDescuento, descuento, totalPagar Como Real
    Definir opcion Como Entero
    Definir formaPago Como Caracter
	
    precioUnitario <- 650
    iva <- 0.12
	
    // Calcular precio con IVA
    precioConIVA <- precioUnitario + (precioUnitario * iva)
	
    Escribir "Ingrese la cantidad de impresoras:"
    Leer cantidad
	
    Escribir "Seleccione la forma de pago:"
    Escribir "1  Efectivo (10%)"
    Escribir "2  Tarjeta de crédito (5%)"
    Escribir "3  Vale de regalo (15%)"
    Leer opcion
	
    // Total sin descuento (ya incluye IVA)
    totalSinDescuento <- cantidad * precioConIVA
	
    Segun opcion Hacer
        1:
            formaPago <- "Efectivo"
            descuento <- totalSinDescuento * 0.10
        2:
            formaPago <- "Tarjeta de crédito"
            descuento <- totalSinDescuento * 0.05
        3:
            formaPago <- "Vale de regalo"
            descuento <- totalSinDescuento * 0.15
        De Otro Modo:
            Escribir "Opción no válida"
            descuento <- 0
            formaPago <- "No válida"
    FinSegun
	
    totalPagar <- totalSinDescuento - descuento
	
    Escribir "===== DETALLE DE PAGO ====="
    Escribir "Cantidad de impresoras: ", cantidad
    Escribir "Precio unitario con IVA: Q", precioConIVA
    Escribir "Total sin descuento: Q", totalSinDescuento
    Escribir "Forma de pago: ", formaPago
    Escribir "Descuento aplicado: Q", descuento
    Escribir "Total a pagar: Q", totalPagar
FinAlgoritmo
