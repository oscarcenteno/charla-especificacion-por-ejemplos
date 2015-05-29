Imports System.Globalization

Namespace Garantias

    ' Separado por comas: 3,333,122.1551
    Public Class MontoRealExcel

        Private _montoNumerico As Decimal

        Sub New(montoNumerico As Decimal)
            _montoNumerico = montoNumerico
        End Sub

        Public ReadOnly Property Valor As Decimal
            Get
                Return _montoNumerico
            End Get
        End Property

        Shared Function Parse(elMonto As String) As MontoRealExcel

            Dim culture As CultureInfo
            culture = New CultureInfo("en-US")
            Dim montoNumerico As Decimal = Decimal.Parse(elMonto, Globalization.NumberStyles.Any, culture)
            Return New MontoRealExcel(montoNumerico)
        End Function
    End Class

End Namespace
