Public Module FormulasDeValoracion

    Public Function CalcularDiasAlVencimiento(fechaActual As Date, fechaVencimiento As Date) As Integer
        Return fechaVencimiento.Date.Subtract(fechaActual.Date).TotalDays()
    End Function

    Public Function CalcularValorDeMercado(montoNominal As Decimal, precioDeMercado As Decimal) As Decimal
        Return montoNominal * precioDeMercado / 100
    End Function

End Module
