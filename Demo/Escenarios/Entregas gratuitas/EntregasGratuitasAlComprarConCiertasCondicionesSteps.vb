Imports System
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio

Namespace Escenarios

    <Binding()> _
    Public Class EntregasGratuitasAlComprarConCiertasCondicionesSteps

        Dim categoriaDeCliente As CategoriaDeCliente
        Dim respuestaObtenida As Respuesta

        <TechTalk.SpecFlow.Given("un cliente de cierta ""(.*)""")> _
        Public Sub DadoUnClienteDeCierta(ByVal categoria As CategoriaDeCliente)
            categoriaDeCliente = categoria
        End Sub

        <TechTalk.SpecFlow.When("la orden contiene una ""(.*)"" de ""(.*)"" con un ""(.*)""")> _
        Public Sub CuandoLaOrdenContieneUnaDeConUn(ByVal cantidad As Int32, ByVal productos As TipoDeProducto, ByVal precioBase As MontoEnDolares)
            respuestaObtenida = EntregaGratuita.CumpleLasCondiciones(categoriaDeCliente, cantidad, productos, precioBase)
        End Sub


        <TechTalk.SpecFlow.Then("""(.*)""")> _
        Public Sub Entonces(ByVal respuestaEsperada As Respuesta)
            Assert.AreEqual(respuestaEsperada, respuestaObtenida)
        End Sub

    End Class

End Namespace
