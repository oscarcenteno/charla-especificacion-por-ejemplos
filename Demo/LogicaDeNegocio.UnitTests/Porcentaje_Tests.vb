<TestClass()> Public Class Porcentaje_Tests

    <TestMethod(), ExpectedException(GetType(ArgumentException))> _
    Public Sub Parse_Fallido_SignoPorcentaje()
        Dim valorObtenido = LogicaDeNegocio.Porcentaje.Parse("25#")
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))> _
    Public Sub Parse_Fallido_MontoNumerico()
        Dim valorObtenido = LogicaDeNegocio.Porcentaje.Parse("veinte%")
    End Sub


End Class
