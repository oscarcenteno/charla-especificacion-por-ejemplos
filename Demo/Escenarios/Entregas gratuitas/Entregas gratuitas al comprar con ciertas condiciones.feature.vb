﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:1.9.0.77
'     SpecFlow Generator Version:1.9.0.0
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace Escenarios.EntregasGratuitas
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>  _
    Partial Public Class EntregasGratuitasFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("Entregas gratuitas al comprar con ciertas condiciones.feature",1)
#End ExternalSource
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>  _
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("es-ES"), "Entregas gratuitas", "Se ofrece entregas gratuitas a clientes premium una vez que compran cierta cantid"& _ 
                    "ad de libros."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"La entrega gratuita no se ofrece a clientes normales o clientes p"& _ 
                    "remium que compran otro tipo de producto.", ProgrammingLanguage.VB, CType(Nothing,String()))
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
                        AndAlso (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title <> "Entregas gratuitas")) Then
                Escenarios.EntregasGratuitas.EntregasGratuitasFeature.FeatureSetup(Nothing)
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
        
        Public Overridable Sub EntregasGratuitas(ByVal intencionDelEjemplo As String, ByVal categoria As String, ByVal cantidad As String, ByVal productos As String, ByVal precioTotal As String, ByVal podriaTenerUnaEntregaGratuita As String, ByVal exampleTags() As String)
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Entregas gratuitas", exampleTags)
#ExternalSource("Entregas gratuitas al comprar con ciertas condiciones.feature",5)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("Entregas gratuitas al comprar con ciertas condiciones.feature",7)
testRunner.Given(String.Format("un cliente de cierta ""{0}""", categoria), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Dado ")
#End ExternalSource
#ExternalSource("Entregas gratuitas al comprar con ciertas condiciones.feature",8)
testRunner.When(String.Format("la orden contiene una ""{0}"" de ""{1}"" con un ""{2}""", cantidad, productos, precioTotal), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Cuando ")
#End ExternalSource
#ExternalSource("Entregas gratuitas al comprar con ciertas condiciones.feature",9)
testRunner.Then(String.Format("""{0}""", podriaTenerUnaEntregaGratuita), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Entonces ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "clientes normales nunca aplican"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "clientes normales nunca aplican"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoria", "normal"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:cantidad", "5"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:productos", "libros"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:precio total", "$25"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:podria tener una entrega gratuita", "No")>  _
        Public Overridable Sub EntregasGratuitas_ClientesNormalesNuncaAplican()
            Me.EntregasGratuitas("clientes normales nunca aplican", "normal", "5", "libros", "$25", "No", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "clientes premium tienen promocion de envío en libros"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "clientes premium tienen promocion de envío en libros"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoria", "premium"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:cantidad", "5"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:productos", "libros"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:precio total", "$50"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:podria tener una entrega gratuita", "Sí")>  _
        Public Overridable Sub EntregasGratuitas_ClientesPremiumTienenPromocionDeEnvioEnLibros()
            Me.EntregasGratuitas("clientes premium tienen promocion de envío en libros", "premium", "5", "libros", "$50", "Sí", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "las lavadoras no se entregan gratis"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "las lavadoras no se entregan gratis"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoria", "premium"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:cantidad", "1"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:productos", "lavadoras"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:precio total", "$250"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:podria tener una entrega gratuita", "No")>  _
        Public Overridable Sub EntregasGratuitas_LasLavadorasNoSeEntreganGratis()
            Me.EntregasGratuitas("las lavadoras no se entregan gratis", "premium", "1", "lavadoras", "$250", "No", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Entregas gratuitas"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "bienes digitales no aplican"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "bienes digitales no aplican"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoria", "premium"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:cantidad", "5"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:productos", "digital"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:precio total", "$2500"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:podria tener una entrega gratuita", "NA")>  _
        Public Overridable Sub EntregasGratuitas_BienesDigitalesNoAplican()
            Me.EntregasGratuitas("bienes digitales no aplican", "premium", "5", "digital", "$2500", "NA", CType(Nothing,String()))
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region
