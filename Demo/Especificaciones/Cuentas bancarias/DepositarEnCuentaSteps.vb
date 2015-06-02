Imports System
Imports TechTalk.SpecFlow
Imports LogicaDeNegocio.CuentasBancarias

Namespace Escenarios

    <Binding()> _
    Public Class DepositarEnCuentaSteps
        Dim laCuenta As Cuenta

        <TechTalk.SpecFlow.Given("una cuenta con saldo (.*)")> _
        Public Sub DadoUnaCuentaConSaldo(ByVal saldoInicial As Int32)

            laCuenta = New Cuenta(saldoInicial)

        End Sub

        <TechTalk.SpecFlow.When("deposito (.*) colones")> _
        Public Sub CuandoDepositoColones(ByVal monto As Int32)
            laCuenta.Depositar(monto)
        End Sub

        <TechTalk.SpecFlow.Then("el saldo es de (.*) colones")> _
        Public Sub EntoncesElSaldoEsDeColones(ByVal saldoEsperado As Int32)

            Dim saldoObtenido As Integer = laCuenta.ConsultarSaldo

            Assert.AreEqual(saldoEsperado, saldoObtenido)

        End Sub

    End Class

End Namespace
