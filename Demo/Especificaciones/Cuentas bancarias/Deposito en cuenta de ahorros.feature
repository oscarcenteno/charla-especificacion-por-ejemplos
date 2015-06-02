Característica: Depositar en cuenta
Como Paulo, el cliente
Quiero depositar en mi cuenta 
Con el fin de ahorrar.

@cuentas
Escenario: Deposito en cuenta sin saldo

Dado una cuenta con saldo 0
Cuando deposito 1000 colones
Entonces el saldo es de 1000 colones

@cuentas
Escenario: Deposito en cuenta con saldo

Dado una cuenta con saldo 2500
Cuando deposito 1000 colones
Entonces el saldo es de 3500 colones
