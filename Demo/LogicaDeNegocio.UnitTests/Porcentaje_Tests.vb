Imports LogicaDeNegocio.Garantias

<TestClass()> Public Class Porcentaje_Tests

    <TestMethod(), ExpectedException(GetType(ArgumentException))> _
    Public Sub Parse_Fallido_SignoPorcentaje()
        Dim valorObtenido = Porcentaje.Parse("25#")
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))> _
    Public Sub Parse_Fallido_MontoNumerico()
        Dim valorObtenido = Porcentaje.Parse("veinte%")
    End Sub


End Class
