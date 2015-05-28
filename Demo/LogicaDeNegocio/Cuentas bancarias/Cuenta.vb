Public Class Cuenta

    Private _saldo As Integer

    Public Sub New()
        _saldo = 0
    End Sub

    Sub New(saldoInicial As Integer)
        _saldo = saldoInicial
    End Sub

    'Depositar
    Public Sub Depositar(monto As Integer)
        _saldo = _saldo + monto
    End Sub

    'Retirar
    Sub Retirar(montoPorRetirar As Integer)
        If montoPorRetirar <= _saldo Then
            _saldo = _saldo - montoPorRetirar
        End If
    End Sub

    'Consulta el saldo
    Public Function ConsultarSaldo() As Integer
        Return _saldo
    End Function

End Class
