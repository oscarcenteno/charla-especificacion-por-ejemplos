﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:1.9.0.77
'     SpecFlow Generator Version:1.9.0.0
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace Escenarios.GarantiasDeValores.Valoraciones
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>  _
    Partial Public Class CalcularAporteDeGarantiasFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("Valores nacionales estandarizados.feature",1)
#End ExternalSource
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>  _
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("es-ES"), "Calcular aporte de garantias", "Como Fideicomisario"&Global.Microsoft.VisualBasic.ChrW(9)&Global.Microsoft.VisualBasic.ChrW(10)&"Quiero valorar las garantias de valores nacionales estandari"& _ 
                    "zados para todos los fideicomitentes"&Global.Microsoft.VisualBasic.ChrW(9)&Global.Microsoft.VisualBasic.ChrW(10)&"Con el fin de actualizar los saldos aporta"& _ 
                    "dos por todos los fideicomitentes", ProgrammingLanguage.VB, CType(Nothing,String()))
            testRunner.OnFeatureStart(featureInfo)
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()>  _
        Public Shared Sub FeatureTearDown()
            testRunner.OnFeatureEnd
            testRunner = Nothing
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()>  _
        Public Overridable Sub TestInitialize()
            If ((Not (TechTalk.SpecFlow.FeatureContext.Current) Is Nothing)  _
                        AndAlso (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title <> "Calcular aporte de garantias")) Then
                Escenarios.GarantiasDeValores.Valoraciones.CalcularAporteDeGarantiasFeature.FeatureSetup(Nothing)
            End If
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()>  _
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd
        End Sub
        
        Public Overridable Sub ScenarioSetup(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioStart(scenarioInfo)
        End Sub
        
        Public Overridable Sub ScenarioCleanup()
            testRunner.CollectScenarioErrors
        End Sub
        
        Public Overridable Sub AporteDeGarantia(ByVal intencionDelEjemplo As String, ByVal diasAlVencimiento As String, ByVal diasMinimosAlVencimiento As String, ByVal valorDeMercado As String, ByVal porcentajeDeCobertura As String, ByVal aporteDeGarantia As String, ByVal exampleTags() As String)
            Dim __tags() As String = New String() {"valoraciones"}
            If (Not (exampleTags) Is Nothing) Then
                __tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(__tags, exampleTags))
            End If
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Aporte de garantía", __tags)
#ExternalSource("Valores nacionales estandarizados.feature",7)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("Valores nacionales estandarizados.feature",9)
testRunner.Given(String.Format("que restan ""{0}"" de una emisión con un ""{1}""", diasAlVencimiento, valorDeMercado), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Dado ")
#End ExternalSource
#ExternalSource("Valores nacionales estandarizados.feature",10)
testRunner.And(String.Format("el emisor requiere ""{0}"" para que una emisión sea garantía", diasMinimosAlVencimiento), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Y ")
#End ExternalSource
#ExternalSource("Valores nacionales estandarizados.feature",11)
testRunner.When(String.Format("se realiza la valoración de la emisión según un ""{0}"" del activo", porcentajeDeCobertura), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Cuando ")
#End ExternalSource
#ExternalSource("Valores nacionales estandarizados.feature",12)
testRunner.Then(String.Format("la emisión cuenta con un ""{0}""", aporteDeGarantia), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Entonces ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Aporte de garantía"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calcular aporte de garantias"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "valor vigente"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "valor vigente"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "3,606"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días mínimos al vencimiento", "7"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor de mercado", "1,547,340,190.0000"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:porcentaje de cobertura", "85%"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:aporte de garantía", "1,315,239,161.50")>  _
        Public Overridable Sub AporteDeGarantia_ValorVigente()
            Me.AporteDeGarantia("valor vigente", "3,606", "7", "1,547,340,190.0000", "85%", "1,315,239,161.50", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Aporte de garantía"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calcular aporte de garantias"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "valor por vencer"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "valor por vencer"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "7"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días mínimos al vencimiento", "7"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor de mercado", "495,000,000.0000"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:porcentaje de cobertura", "97%"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:aporte de garantía", "0.00")>  _
        Public Overridable Sub AporteDeGarantia_ValorPorVencer()
            Me.AporteDeGarantia("valor por vencer", "7", "7", "495,000,000.0000", "97%", "0.00", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Aporte de garantía"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calcular aporte de garantias"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "valor vencido hoy"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "valor vencido hoy"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "0"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días mínimos al vencimiento", "7"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor de mercado", "495,000,000.0000"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:porcentaje de cobertura", "97%"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:aporte de garantía", "0.00")>  _
        Public Overridable Sub AporteDeGarantia_ValorVencidoHoy()
            Me.AporteDeGarantia("valor vencido hoy", "0", "7", "495,000,000.0000", "97%", "0.00", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Aporte de garantía"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calcular aporte de garantias"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "valor vencido pasado"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "valor vencido pasado"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "-365"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días mínimos al vencimiento", "7"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor de mercado", "495,000,000.0000"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:porcentaje de cobertura", "98%"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:aporte de garantía", "0.00")>  _
        Public Overridable Sub AporteDeGarantia_ValorVencidoPasado()
            Me.AporteDeGarantia("valor vencido pasado", "-365", "7", "495,000,000.0000", "98%", "0.00", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Aporte de garantía"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Calcular aporte de garantias"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "sin porcentaje de cobertura"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "sin porcentaje de cobertura"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "300"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días mínimos al vencimiento", "7"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor de mercado", "495,000,000.0000"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:porcentaje de cobertura", "0%"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:aporte de garantía", "0.00")>  _
        Public Overridable Sub AporteDeGarantia_SinPorcentajeDeCobertura()
            Me.AporteDeGarantia("sin porcentaje de cobertura", "300", "7", "495,000,000.0000", "0%", "0.00", CType(Nothing,String()))
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region
