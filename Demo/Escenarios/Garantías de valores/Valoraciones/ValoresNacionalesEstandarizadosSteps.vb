Imports System
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio
Imports LogicaDeNegocio.Garantias

Namespace Escenarios

    <Binding()> _
    Public Class ValorarGarantiasDeValoresNacionalesEstandarizadosSteps

        Private _díasAlVencimiento As Integer
        Private _valorDeMercado As Integer
        Private _díasMínimosAlVencimiento As Integer
        Private _aporteObtenido As Decimal

        <TechTalk.SpecFlow.Given("que restan ""(.*)"" de una emisión con un ""(.*)""")> _
        Public Sub DadoQueRestanDeUnaEmisionConUn(ByVal díasAlVencimiento As MontoEnteroExcel, ByVal valorDeMercado As MontoRealExcel)
            _díasAlVencimiento = díasAlVencimiento.Valor
            _valorDeMercado = valorDeMercado.Valor
        End Sub

        <TechTalk.SpecFlow.Given("el emisor requiere ""(.*)"" para que una emisión sea garantía")> _
        Public Sub DadoElEmisorRequiereParaQueUnaEmisionSeaGarantia(ByVal díasMínimosAlVencimiento As Integer)
            _díasMínimosAlVencimiento = díasMínimosAlVencimiento
        End Sub

        <TechTalk.SpecFlow.When("se realiza la valoración de la emisión según un ""(.*)"" del activo")> _
        Public Sub CuandoSeRealizaLaValoracionDeLaEmisionSegunUnDelActivo(ByVal porcentajeDeCobertura As Porcentaje)
            Dim elValorador As New Valorador
            _aporteObtenido = elValorador.CalcularAporteDeGarantias(_díasMínimosAlVencimiento, _díasAlVencimiento, _valorDeMercado, porcentajeDeCobertura.Valor)
        End Sub

        <TechTalk.SpecFlow.Then("la emisión cuenta con un ""(.*)""")> _
        Public Sub EntoncesLaEmisionCuentaConUn(ByVal aporteDeGarantiaEsperado As MontoRealExcel)
            Assert.AreEqual(aporteDeGarantiaEsperado.Valor, _aporteObtenido)
        End Sub

    End Class

End Namespace
