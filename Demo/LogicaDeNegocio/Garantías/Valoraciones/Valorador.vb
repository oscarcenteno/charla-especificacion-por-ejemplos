Namespace Garantias

    Public Class Valorador

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

End Namespace
