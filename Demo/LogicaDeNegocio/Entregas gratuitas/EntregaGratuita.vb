Namespace EntregasGratuitas

    Public Class EntregaGratuita

        Private _elMinimo As MontoEnDolares

        Public Sub New(elMinimo As MontoEnDolares)
            _elMinimo = elMinimo
        End Sub

        ' Ejemplo inicial
        Public Function CumpleLasCondiciones(tipoDeCliente As CategoriaDeCliente,
                                                    cantidadDeProductos As Integer,
                                                    tipoDeProducto As TipoDeProducto,
                                                    precioTotal As MontoEnDolares
                                                    ) As Respuesta

            Dim laRespuesta As Respuesta = Nothing

            If tipoDeCliente = CategoriaDeCliente.Normal Then
                laRespuesta = Respuesta.No
            ElseIf tipoDeProducto = tipoDeProducto.Libros _
                And precioTotal.Valor >= _elMinimo.Valor Then
                laRespuesta = Respuesta.Sí
            ElseIf tipoDeProducto = tipoDeProducto.Digitales Then
                laRespuesta = Respuesta.NA
            Else
                laRespuesta = Respuesta.No
            End If

            Return laRespuesta

        End Function

        ' Ejemplo con múltiples productos
        Function CumpleLasCondiciones(categoriaDeCliente As CategoriaDeCliente, tipos As IEnumerable(Of TipoDeProducto), precioTotal As MontoEnDolares) As Respuesta
            Dim respuesta As Respuesta = respuesta.No

            If OrdenSoloContieneProductosDigitales(tipos) Then
                respuesta = respuesta.NA
            ElseIf ClienteCalifica(categoriaDeCliente) And _
                PrecioCalifica(precioTotal) And _
                OrdenContieneProductosCalificados(tipos) And _
                OrdenNoContieneProductosDesCalificados(tipos) Then
                respuesta = respuesta.Sí
            Else
                respuesta = respuesta.No
            End If

            Return respuesta

        End Function

        Private Function PrecioCalifica(precioTotal As MontoEnDolares) As Boolean
            Return precioTotal.Valor >= _elMinimo.Valor
        End Function

        Private Function OrdenSoloContieneProductosDigitales(tipos As IEnumerable(Of TipoDeProducto)) As Boolean
            Dim cantidadDeDigitales As Integer = 0
            Dim cantidadDeTiposEnOrden As Integer = tipos.Count
            cantidadDeDigitales = tipos.Where(Function(c) c.Equals(TipoDeProducto.Digitales)).Count
            Return cantidadDeDigitales = cantidadDeTiposEnOrden
        End Function

        Private Function OrdenContieneProductosCalificados(tipos As IEnumerable(Of TipoDeProducto)) As Boolean
            Dim contiene As Boolean = False
            contiene = tipos.Contains(TipoDeProducto.Libros)
            Return contiene
        End Function

        Private Function OrdenNoContieneProductosDesCalificados(tipos As IEnumerable(Of TipoDeProducto)) As Boolean
            Dim contiene As Boolean = False
            contiene = tipos.Contains(TipoDeProducto.Lavadoras)
            Return Not contiene
        End Function

        Private Function ClienteCalifica(categoriaDeCliente As CategoriaDeCliente) As Boolean
            Return categoriaDeCliente = categoriaDeCliente.Premium
        End Function

    End Class

End Namespace
