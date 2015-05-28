Imports System.Globalization

' Separado por comas: 3,333,122.1551
Public Class MontoEnteroExcel

    Private _montoNumerico As Integer

    Sub New(montoNumerico As Integer)
        _montoNumerico = montoNumerico
    End Sub

    Public ReadOnly Property Valor As Integer
        Get
            Return _montoNumerico
        End Get
    End Property

    Shared Function Parse(elMonto As String) As MontoEnteroExcel
        Dim culture As CultureInfo
        culture = New CultureInfo("en-US")
        Dim montoNumerico As Integer = Integer.Parse(elMonto, Globalization.NumberStyles.Any, culture)
        Return New MontoEnteroExcel(montoNumerico)
    End Function
End Class
