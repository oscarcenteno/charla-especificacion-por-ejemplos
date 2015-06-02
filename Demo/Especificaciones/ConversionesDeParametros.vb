Imports TechTalk.SpecFlow
Imports TechTalk.SpecFlow.Assist
Imports LogicaDeNegocio.EntregasGratuitas
Imports LogicaDeNegocio.Garantias

<Binding()> _
Public Class ConversionesDeParametros

    <StepArgumentTransformation()>
    Public Function TransformeAPorcentaje(elPorcentaje As String) As Porcentaje
        Return Porcentaje.Parse(elPorcentaje)
    End Function

    <StepArgumentTransformation()>
    Public Function TransformeAReal(elMonto As String) As MontoRealExcel
        Return MontoRealExcel.Parse(elMonto)
    End Function

    <StepArgumentTransformation()>
    Public Function TransformeAEntero(elMonto As String) As MontoEnteroExcel
        Return MontoEnteroExcel.Parse(elMonto)
    End Function

    <StepArgumentTransformation()>
    Public Function TransformeAMontoEnDolares(monto As String) As MontoEnDolares
        Return MontoEnDolares.Parse(monto)
    End Function

End Class

