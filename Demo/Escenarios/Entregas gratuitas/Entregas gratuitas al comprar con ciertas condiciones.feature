Característica: Entregas gratuitas
	Se ofrece entregas gratuitas a clientes premium una vez que compran cierta cantidad de libros.
	La entrega gratuita no se ofrece a clientes normales o clientes premium que compran otro tipo de producto.

Esquema del escenario: Entregas gratuitas

Dado un cliente de cierta "<categoria>"
Cuando la orden contiene una "<cantidad>" de "<productos>" con un "<precio total>"
Entonces "<podria tener una entrega gratuita>"

Ejemplos: 
| intención del ejemplo                                | categoria | cantidad | productos | precio total | podria tener una entrega gratuita |
| clientes normales nunca aplican                      | normal    | 5        | libros    | $25         | No                                |
| clientes premium tienen promocion de envío en libros | premium   | 5        | libros    | $50         | Sí                                |
| las lavadoras no se entregan gratis                  | premium   | 1        | lavadoras | $250        | No                                |
| bienes digitales no aplican                          | premium   | 5        | digital   | $2500       | NA                                |

#| clientes premium tienen minimo                       | premium   | 5        | libros    | $25         | Sí                                |