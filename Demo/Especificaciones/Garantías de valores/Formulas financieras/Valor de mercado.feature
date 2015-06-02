Característica: Valor de mercado
Se calcula el valor de mercado de un valor nacional estandarizado

@valoraciones
Esquema del escenario: Valor de mercado

Dado que la emisión reporta un "<monto nominal>"
Cuando se valora con el "<precio de mercado>" reportado en el vector de precios para la emisión
Entonces se obtiene el "<valor de mercado>" de la emisión

Ejemplos: 

| intención del ejemplo | monto nominal    | precio de mercado | valor de mercado   |
| ejemplo 1             | 1,727,000,000.00 | 89.5970           | 1,547,340,190.0000 |
| ejemplo 2             | 250,000,000.00   | 92.9460           | 232,365,000.0000   |
| ejemplo 3             | 384,000,000.00   | 97.3380           | 373,777,920.0000   |
| ejemplo 4             | 500,000,000.00   | 99.000            | 495,000,000.0000   |
