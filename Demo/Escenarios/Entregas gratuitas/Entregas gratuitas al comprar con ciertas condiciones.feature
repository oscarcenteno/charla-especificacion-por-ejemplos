﻿Característica: Entregas gratuitas al comprar con ciertas condiciones
	Como un cliente
	Quiero tener una entrega gratuita cuando compro ciertos productos
	Con el fin de abaratar mis costos.

Esquema del escenario: Entregas gratuitas

Dado un cliente de cierta "<categoria>"
Cuando la orden contiene una "<cantidad>" de "<productos>" con un precio mayor a un "<precio base>"
Entonces "<podria tener una entrega gratuita>"

Ejemplos: 
| intención del ejemplo                                | categoria | cantidad | productos | precio base | podria tener una entrega gratuita |
| clientes normales nunca aplican                      | normal    | 5        | libros    | $25         | No                                |
| clientes premium tienen promocion de envío en libros | premium   | 5        | libros    | $50         | Sí                                |
| las lavadoras no se entregan gratis                  | premium   | 1        | lavadoras | $250        | No                                |
| bienes digitales no aplican                          | premium   | 5        | digital   | $2500       | NA                                |

#| clientes premium tienen minimo                       | premium   | 5        | libros    | $25         | Sí                                |

# este ejemplo falla y es porque la 
# especificacion pide un precio mayor que $25 
# para la orden de un cliente premium
