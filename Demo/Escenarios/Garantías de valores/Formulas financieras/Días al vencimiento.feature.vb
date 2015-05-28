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

Namespace Escenarios.GarantiasDeValores.FormulasFinancieras
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()>  _
    Partial Public Class DiasAlVencimientoFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("Días al vencimiento.feature",1)
#End ExternalSource
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()>  _
        Public Shared Sub FeatureSetup(ByVal testContext As Microsoft.VisualStudio.TestTools.UnitTesting.TestContext)
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("es-ES"), "Días al vencimiento", "", ProgrammingLanguage.VB, CType(Nothing,String()))
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
                        AndAlso (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title <> "Días al vencimiento")) Then
                Escenarios.GarantiasDeValores.FormulasFinancieras.DiasAlVencimientoFeature.FeatureSetup(Nothing)
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
        
        Public Overridable Sub DiasAlVencimiento(ByVal intencionDelEjemplo As String, ByVal fechaDeVencimiento As String, ByVal fecha As String, ByVal diasAlVencimiento As String, ByVal exampleTags() As String)
            Dim __tags() As String = New String() {"valoraciones"}
            If (Not (exampleTags) Is Nothing) Then
                __tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(__tags, exampleTags))
            End If
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("días al vencimiento", __tags)
#ExternalSource("Días al vencimiento.feature",4)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("Días al vencimiento.feature",6)
testRunner.Given(String.Format("una emisión con una ""{0}""", fechaDeVencimiento), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Dada ")
#End ExternalSource
#ExternalSource("Días al vencimiento.feature",7)
testRunner.When(String.Format("se realiza la valoración en una ""{0}""", fecha), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Cuando ")
#End ExternalSource
#ExternalSource("Días al vencimiento.feature",8)
testRunner.Then(String.Format("se obtiene los ""{0}""", diasAlVencimiento), CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Entonces ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "diez anos a futuro"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "diez anos a futuro"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha de vencimiento", "2021/9/22"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha", "2011/11/8"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "3,606")>  _
        Public Overridable Sub DiasAlVencimiento_DiezAnosAFuturo()
            Me.DiasAlVencimiento("diez anos a futuro", "2021/9/22", "2011/11/8", "3,606", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "una semana a futuro"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "una semana a futuro"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha de vencimiento", "2011/11/15"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha", "2011/11/8"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "7")>  _
        Public Overridable Sub DiasAlVencimiento_UnaSemanaAFuturo()
            Me.DiasAlVencimiento("una semana a futuro", "2011/11/15", "2011/11/8", "7", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "hoy"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "hoy"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha de vencimiento", "2011/11/8"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha", "2011/11/8"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "0")>  _
        Public Overridable Sub DiasAlVencimiento_Hoy()
            Me.DiasAlVencimiento("hoy", "2011/11/8", "2011/11/8", "0", CType(Nothing,String()))
        End Sub
        
        <Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Días al vencimiento"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("valoraciones"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "un año atrás"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:intención del ejemplo", "un año atrás"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha de vencimiento", "2010/11/8"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:fecha", "2011/11/8"),  _
         Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:días al vencimiento", "-365")>  _
        Public Overridable Sub DiasAlVencimiento_UnAnoAtras()
            Me.DiasAlVencimiento("un año atrás", "2010/11/8", "2011/11/8", "-365", CType(Nothing,String()))
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region
