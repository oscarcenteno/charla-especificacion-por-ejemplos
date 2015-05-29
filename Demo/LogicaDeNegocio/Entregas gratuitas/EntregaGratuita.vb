Namespace EntregasGratuitas

    Public Class EntregaGratuita

        Public Shared Function CumpleLasCondiciones(tipoDeCliente As CategoriaDeCliente,
                                                    cantidadDeProductos As Integer,
                                                    tipoDeProducto As TipoDeProducto,
                                                    precioBase As MontoEnDolares
                                                    ) As Respuesta

            Dim laRespuesta As Respuesta = Nothing
            If tipoDeCliente = CategoriaDeCliente.Normal Then
                laRespuesta = Respuesta.No
            ElseIf tipoDeProducto = tipoDeProducto.Libros And precioBase.Valor > New MontoEnDolares(25).Valor Then
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
