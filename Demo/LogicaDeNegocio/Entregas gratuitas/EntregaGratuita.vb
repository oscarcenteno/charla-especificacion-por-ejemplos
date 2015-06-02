Namespace EntregasGratuitas

    Public Class EntregaGratuita

        Private _elMinimo As MontoEnDolares

        Public Sub New(elMinimo As MontoEnDolares)
            _elMinimo = elMinimo
        End Sub

        Public Function CumpleLasCondiciones(tipoDeCliente As CategoriaDeCliente,
                                                    cantidadDeProductos As Integer,
                                                    tipoDeProducto As TipoDeProducto,
                                                    precioTotal As MontoEnDolares
                                                    ) As Respuesta

            Dim laRespuesta As Respuesta = Nothing

            If tipoDeCliente = CategoriaDeCliente.Normal Then
                laRespuesta = Respuesta.No
            ElseIf tipoDeProducto = tipoDeProducto.Libros _
                And precioTotal.Valor > _elMinimo.Valor Then
                laRespuesta = Respuesta.Sí
            ElseIf tipoDeProducto = tipoDeProducto.Digital Then
                laRespuesta = Respuesta.NA
            Else
                laRespuesta = Respuesta.No
            End If

            Return laRespuesta

        End Function

    End Class

End Namespace
