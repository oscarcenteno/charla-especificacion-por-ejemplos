Imports System
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio.EntregasGratuitas

Namespace Especificaciones

    <Binding()> _
    Public Class EntregasGratuitasConMultiplesProductosSteps

        Dim categoriaDeCliente As CategoriaDeCliente
        Dim minimo As MontoEnDolares
        Dim respuestaObtenida As Respuesta


        <TechTalk.SpecFlow.Given("un cliente que tenia cierta ""(.*)""")> _
        Public Sub DadoUnClienteQueTeniaCierta(ByVal categoria As CategoriaDeCliente)
            categoriaDeCliente = categoria
        End Sub

        <TechTalk.SpecFlow.Given("que el mínimo para optar por una entrega gratuita era de ""(.*)""")> _
        Public Sub DadoQueElMinimoParaOptarPorUnaEntregaGratuitaEraDe(ByVal elMinimo As MontoEnDolares)
            minimo = elMinimo
        End Sub

        <TechTalk.SpecFlow.When("se procesa una orden con ""(.*)"" y un ""(.*)""")> _
        Public Sub CuandoSeProcesaUnaOrdenConYTieneYUn(ByVal tipos As IEnumerable(Of TipoDeProducto), ByVal precioTotal As MontoEnDolares)
            Dim validadorDeEntregas = New EntregaGratuita(minimo)
            respuestaObtenida = validadorDeEntregas.CumpleLasCondiciones(categoriaDeCliente, tipos, precioTotal)
        End Sub

        <TechTalk.SpecFlow.Then("la orden ""(.*)""")> _
        Public Sub EntoncesLaOrden(ByVal respuestaEsperada As Respuesta)
            Assert.AreEqual(respuestaEsperada, respuestaObtenida)
        End Sub

    End Class

End Namespace
