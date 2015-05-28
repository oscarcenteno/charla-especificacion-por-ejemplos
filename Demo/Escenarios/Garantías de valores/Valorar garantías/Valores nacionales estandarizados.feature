Característica: Calcular aporte de garantias
	Como Fideicomisario	
	Quiero valorar las garantias de valores nacionales estandarizados para todos los fideicomitentes	
	Con el fin de actualizar los saldos aportados por todos los fideicomitentes

@valoraciones
Esquema del escenario: Aporte de garantía

Dado que restan "<días al vencimiento>" de una emisión con un "<valor de mercado>" 
Y el emisor requiere "<días mínimos al vencimiento>" para que una emisión sea garantía
Cuando se realiza la valoración de la emisión según un "<porcentaje de cobertura>" del activo
Entonces la emisión cuenta con un "<aporte de garantía>"

# En este escenario, vemos el uso de una descripcion para diferenciar 
# claramente la intencion de cada ejemplo

Ejemplos: 
| intención del ejemplo       | días al vencimiento | días mínimos al vencimiento | valor de mercado   | porcentaje de cobertura | aporte de garantía |
| valor vigente               | 3,606               | 7                           | 1,547,340,190.0000 | 85%                     | 1,315,239,161.50   |
| valor por vencer            | 7                   | 7                           | 495,000,000.0000   | 97%                     | 0.00               |
| valor vencido hoy           | 0                   | 7                           | 495,000,000.0000   | 97%                     | 0.00               |
| valor vencido pasado        | -365                | 7                           | 495,000,000.0000   | 98%                     | 0.00               |
| sin porcentaje de cobertura | 300                 | 7                           | 495,000,000.0000   | 0%                      | 0.00               |