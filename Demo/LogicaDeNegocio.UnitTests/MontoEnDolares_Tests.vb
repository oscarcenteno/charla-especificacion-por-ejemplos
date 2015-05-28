Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class MontoEnDolares_Tests

    <TestMethod()> Public Sub Constructor_Basico()
        Dim valorEsperado As Double = 25
        Dim sut As New LogicaDeNegocio.MontoEnDolares(valorEsperado)
        Dim valorObtenido As Double = sut.Valor
        Assert.AreEqual(Of Double)(valorEsperado, valorObtenido)

    End Sub

    <TestMethod()> _
    Public Sub Parse_Exitoso()
        Dim esperado = New MontoEnDolares(25)
        Dim obtenido = LogicaDeNegocio.MontoEnDolares.Parse("$25")
        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))> _
    Public Sub Parse_Fallido()
        Dim valorObtenido = LogicaDeNegocio.MontoEnDolares.Parse("NA25")
    End Sub

    <TestMethod()> _
    Public Sub Equals_Me()
        Dim sut As New MontoEnDolares(25)
        Assert.IsTrue(sut.Equals(sut))
    End Sub

    <TestMethod()> _
    Public Sub Equals_Nothing()
        Dim sut As New MontoEnDolares(25)
        Assert.IsFalse(sut.Equals(Nothing))
    End Sub

    <TestMethod()> _
    Public Sub Equals_OtroTipo()
        Dim sut As New MontoEnDolares(25)
        Assert.IsFalse(sut.Equals(New ArrayList))
    End Sub

End Class