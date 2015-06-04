Característica: Entregas gratuitas con multiples productos
	Una orden califica si el cliente es Premium y compra un precio mínimo.
	La entrega gratuita nunca se ofrece a clientes normales.
	Se debe considerar que las órdenes pueden tener bienes digitales.
	La entrega gratuita es solo para órdenes de Libros.

Esquema del escenario: Reglas 

Dado un cliente que tenia cierta "<categoria>"
Y que el mínimo para optar por una entrega gratuita era de "$25"
Cuando se procesa una orden con "<tipos de producto>" con un "<precio total>"
Entonces la orden "<califica para una entrega gratuita>"

Ejemplos: 
| intención del ejemplo                                       | categoria | tipos de producto    | precio total | califica para una entrega gratuita |
| los clientes normales nunca califican                             | normal    | libros               | $25          | No                                 |
| los clientes premium tienen un monto minimo para calificar                           | premium   | libros               | $25          | Sí                                 |
| los clientes premium tienen promocion de envío en libros        | premium   | libros               | $50          | Sí                                 |
| solo los libros se entregan gratis                          | premium   | lavadoras            | $250         | No                                 |
| la orden no califica si contiene más que libros             | premium   | libros, lavadoras    | $250         | No                                 |
| la oferta no aplica si la orden solo contiene bienes digitales                                  | premium   | digitales            | $2500        | NA                                 |
| los bienes digitales no afectan calificacion de otros productos | premium   | libros, digitales    | $250         | Sí                                 |
| los bienes digitales no descalifican otros productos            | premium   | lavadoras, digitales | $500         | No                                 |
