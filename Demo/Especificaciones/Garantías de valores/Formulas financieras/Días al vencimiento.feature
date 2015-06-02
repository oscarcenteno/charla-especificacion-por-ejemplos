Característica: Días al vencimiento

@valoraciones
Esquema del escenario: días al vencimiento

Dada una emisión con una "<fecha de vencimiento>"
Cuando se realiza la valoración en una "<fecha>"
Entonces se obtiene los "<días al vencimiento>"

Ejemplos: 

| intención del ejemplo | fecha de vencimiento | fecha     | días al vencimiento |
| diez anos a futuro    | 2021/9/22            | 2011/11/8 | 3,606               |
| una semana a futuro   | 2011/11/15           | 2011/11/8 | 7                   |
| hoy                   | 2011/11/8            | 2011/11/8 | 0                   |
| un año atrás          | 2010/11/8            | 2011/11/8 | -365                |  

