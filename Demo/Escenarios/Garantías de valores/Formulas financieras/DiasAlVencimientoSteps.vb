Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio
Imports LogicaDeNegocio.Garantias

Namespace Escenarios

    ' For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

    <Binding()> _
    Public NotInheritable Class DiasAlVencimientoSteps
#Region "días al vencimiento"

        Dim _fechaDeVencimiento As Date
        Dim _fecha As Date

        <TechTalk.SpecFlow.Given("una emisión con una ""(.*)""")> _
        Public Sub DadoUnaEmisionConUna(ByVal fechaDeVencimiento As Date)
            _fechaDeVencimiento = fechaDeVencimiento
        End Sub

        <TechTalk.SpecFlow.When("se realiza la valoración en una ""(.*)""")> _
        Public Sub CuandoSeRealizaLaValoracionEnUna(ByVal fecha As Date)
            _fecha = Date.Parse(fecha, New System.Globalization.CultureInfo("es-ES"))
        End Sub

        <TechTalk.SpecFlow.Then("se obtiene los ""(.*)""")> _
        Public Sub EntoncesSeObtieneLos(ByVal díasAlVencimientoEsperados As MontoEnteroExcel)
            Dim diasAlVencimientoObtenidos As Integer = FormulasDeValoracion.CalcularDiasAlVencimiento(_fecha, _fechaDeVencimiento)
            Assert.AreEqual(díasAlVencimientoEsperados.Valor, diasAlVencimientoObtenidos)
        End Sub

#End Region

    End Class

End Namespace
