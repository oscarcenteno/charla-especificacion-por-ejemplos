
Public Class Porcentaje

    Private _porcentajeNumerico As Double

    Sub New(porcentajeNumerico As Double)
        _porcentajeNumerico = porcentajeNumerico
    End Sub

    Public ReadOnly Property Valor As Double
        Get
            Return _porcentajeNumerico
        End Get
    End Property

    Shared Function Parse(elPorcentaje As String) As Porcentaje
        elPorcentaje = elPorcentaje.Trim
        Dim montoSinSimboloDePorcentaje As String = elPorcentaje.Replace("%", String.Empty)
        Dim porcentajeNumerico As Double = 0
        If elPorcentaje.EndsWith("%") And Double.TryParse(montoSinSimboloDePorcentaje, porcentajeNumerico) Then
            Return New Porcentaje(porcentajeNumerico / 100)
        Else
            Throw New ArgumentException(String.Format("'{0}' no es un porcentaje", elPorcentaje))
        End If
    End Function
End Class
