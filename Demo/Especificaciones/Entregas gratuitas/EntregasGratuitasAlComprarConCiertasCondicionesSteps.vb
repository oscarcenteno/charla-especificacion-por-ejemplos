Imports System
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio.EntregasGratuitas

Namespace Escenarios

    <Binding()> _
    Public Class EntregasGratuitasAlComprarConCiertasCondicionesSteps

        Dim categoriaDeCliente As CategoriaDeCliente
        Dim minimo As MontoEnDolares
        Dim respuestaObtenida As Respuesta

        <TechTalk.SpecFlow.Given("un cliente de cierta ""(.*)""")> _
        Public Sub DadoUnClienteDeCierta(ByVal categoria As CategoriaDeCliente)
            categoriaDeCliente = categoria
        End Sub

        <TechTalk.SpecFlow.Given("que el mínimo para entrega gratuita es de ""(.*)""")> _
        Public Sub DadoQueElMinimoParaEntregaGratuitaEsDe(ByVal elMinimo As MontoEnDolares)
            minimo = elMinimo
        End Sub

        <TechTalk.SpecFlow.When("la orden contiene una ""(.*)"" de ""(.*)"" con un ""(.*)""")> _
        Public Sub CuandoLaOrdenContieneUnaDeConUn(ByVal cantidad As Integer, ByVal tipo As TipoDeProducto, ByVal precioTotal As MontoEnDolares)
            Dim validadorDeEntregas = New EntregaGratuita(minimo)
            respuestaObtenida = validadorDeEntregas.CumpleLasCondiciones(categoriaDeCliente, cantidad, tipo, precioTotal)
        End Sub

        <TechTalk.SpecFlow.Then("""(.*)""")> _
        Public Sub Entonces(ByVal respuestaEsperada As Respuesta)
            Assert.AreEqual(respuestaEsperada, respuestaObtenida)
        End Sub

    End Class

End Namespace
