Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio

Namespace Escenarios

    ' For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

    <Binding()> _
    Public NotInheritable Class ValorDeMercadoSteps
#Region "valor de mercado"

        Private _montoNominal As MontoRealExcel
        Private _valorDeMercadoObtenido As Decimal

        <TechTalk.SpecFlow.Given("que la emisión reporta un ""(.*)""")> _
        Public Sub DadoQueLaEmisionReportaUn(ByVal montoNominal As MontoRealExcel)
            _montoNominal = montoNominal
        End Sub

        <TechTalk.SpecFlow.When("se valora con el ""(.*)"" reportado en el vector de precios para la emisión")> _
        Public Sub CuandoSeValoraConElReportadoEnElVectorDePreciosParaLaEmision(ByVal precioDeMercado As MontoRealExcel)
            _valorDeMercadoObtenido = LogicaDeNegocio.FormulasDeValoracion.CalcularValorDeMercado(_montoNominal.Valor, precioDeMercado.Valor)
        End Sub

        <TechTalk.SpecFlow.Then("se obtiene el ""(.*)"" de la emisión")> _
        Public Sub EntoncesSeObtieneElDeLaEmision(ByVal valorDeMercadoEsperado As MontoRealExcel)
            Assert.AreEqual(Of Decimal)(valorDeMercadoEsperado.Valor, _valorDeMercadoObtenido)
        End Sub

#End Region

    End Class

End Namespace
