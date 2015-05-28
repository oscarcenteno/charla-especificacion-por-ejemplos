Característica: Retirar en cuenta
Como Paulo, el cliente
Quiero retirar en mi cuenta 
Con el fin de salir de paseo.

@cuentas
Escenario: Retiro en cuenta con saldo suficiente
Dado una cuenta cuyo saldo es de 135000 colones
Cuando retiro 128000
Entonces el saldo ahora es de 7000 colones

@cuentas
Escenario: Retiro en cuenta con saldo insuficiente
Dado una cuenta cuyo saldo es de 135000 colones
Cuando retiro 148000
Entonces el saldo ahora es de 135000 colones