Característica: Entregas gratuitas
	Se ofrece entregas gratuitas a clientes premium basado en un precio mínimo.
	La entrega gratuita no se ofrece a clientes normales o a clientes premium cuyas órdenes contienen bienes digitales.

Esquema del escenario: Cuando aplica la entrega gratuita 

Dado un cliente de cierta "<categoria>"
Y que el mínimo para entrega gratuita es de "$25"
Cuando la orden contiene una "<cantidad>" de "<productos>" con un "<precio total>"
Entonces "<podria tener una entrega gratuita>"

Ejemplos: 
| intención del ejemplo                                | categoria | cantidad | productos | precio total | podria tener una entrega gratuita |
| clientes normales nunca aplican                      | normal    | 5        | libros    | $25          | No                                |
| clientes premium tienen promocion de envío en libros | premium   | 5        | libros    | $50          | Sí                                |
| las lavadoras no se entregan gratis                  | premium   | 1        | lavadoras | $250         | No                                |
| bienes digitales no aplican                          | premium   | 5        | digitales | $2500        | NA                                |

