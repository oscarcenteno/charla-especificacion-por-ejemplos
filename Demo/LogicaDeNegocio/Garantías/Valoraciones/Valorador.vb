Public Class Valorador

    Public Function CalcularDiasAlVencimiento(fechaActual As Date, fechaVencimiento As Date) As Integer
        Return fechaVencimiento.Date.Subtract(fechaActual.Date).TotalDays()
    End Function

    Public Function CalcularValorDeMercado(montoNominal As Decimal, precioDeMercado As Decimal) As Decimal
        Return montoNominal * precioDeMercado / 100
    End Function

    Public Function CalcularAporteDeGarantias(diasAlVencimientoMinimos As Integer, diasAlVencimiento As Integer, valorDeMercado As Decimal, porcentajeDeCobertura As Decimal) As Decimal

        Dim aporteDeGarantia As Decimal = 0

        If CumpleDiasMinimos(diasAlVencimientoMinimos, diasAlVencimiento) Then
            aporteDeGarantia = valorDeMercado * porcentajeDeCobertura
        End If

        Return aporteDeGarantia

    End Function

    Private Function CumpleDiasMinimos(diasAlVencimientoMinimos As Integer, diasAlVencimento As Integer) As Boolean
        Return diasAlVencimento > diasAlVencimientoMinimos
    End Function

End Class
