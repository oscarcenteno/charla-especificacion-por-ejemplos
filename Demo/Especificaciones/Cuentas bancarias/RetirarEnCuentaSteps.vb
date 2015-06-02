Imports System
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio.CuentasBancarias

Namespace Escenarios

    <Binding()> _
    Public Class RetirarEnCuentaSteps

        Private laCuenta As Cuenta

        <TechTalk.SpecFlow.Given("una cuenta cuyo saldo es de (.*) colones")> _
        Public Sub DadoUnaCuentaCuyoSaldoEsDeColones(ByVal saldoInicial As Int32)
            laCuenta = New Cuenta(saldoInicial)
        End Sub

        <TechTalk.SpecFlow.When("retiro (.*)")> _
        Public Sub CuandoRetiro(ByVal montoPorRetirar As Int32)
            laCuenta.Retirar(montoPorRetirar)
        End Sub



        <TechTalk.SpecFlow.Then("el saldo ahora es de (.*) colones")> _
        Public Sub EntoncesElSaldoAhoraEsDeColones(ByVal saldoEsperado As Int32)
            Dim saldoObtenido = laCuenta.ConsultarSaldo()
            Assert.AreEqual(saldoEsperado, saldoObtenido)
        End Sub

        <TechTalk.SpecFlow.When("solicito retirar (.*)")> _
        Public Sub CuandoSolicitoRetirar(ByVal monto As Int32)
            laCuenta.Retirar(monto)
        End Sub

        <TechTalk.SpecFlow.Then("el saldo se mantiene en (.*) colones")> _
        Public Sub EntoncesElSaldoSeMantieneEnColones(ByVal saldoEsperado As Int32)
            Dim saldoObtenido = laCuenta.ConsultarSaldo()
            Assert.AreEqual(saldoEsperado, saldoObtenido)
        End Sub

    End Class

End Namespace
