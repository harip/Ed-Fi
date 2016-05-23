﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EdFi.Ods.WebService.Tests.Profiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Profiles assigned to callers must be used for covered resources")]
    [NUnit.Framework.CategoryAttribute("API")]
    public partial class ProfilesAssignedToCallersMustBeUsedForCoveredResourcesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Profiles assigned to callers must be used for covered resources.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Profiles assigned to callers must be used for covered resources", "", ProgrammingLanguage.CSharp, new string[] {
                        "API"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The caller is assigned a profile and requests a covered resource using the correc" +
            "t content type header")]
        public virtual void TheCallerIsAssignedAProfileAndRequestsACoveredResourceUsingTheCorrectContentTypeHeader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The caller is assigned a profile and requests a covered resource using the correc" +
                    "t content type header", ((string[])(null)));
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given("the caller is assigned the \"Test-Profile-Resource-IncludeOnly\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
    testRunner.And("the caller is using the \"Test-Profile-Resource-IncludeOnly\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
    testRunner.When("a GET (by id) request is submitted to schools with an accept header content type " +
                    "of the appropriate value for the profile in use", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
    testRunner.Then("the response should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The caller is assigned a profile and requests a covered resource using a differen" +
            "t profile\'s content type")]
        public virtual void TheCallerIsAssignedAProfileAndRequestsACoveredResourceUsingADifferentProfileSContentType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The caller is assigned a profile and requests a covered resource using a differen" +
                    "t profile\'s content type", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
    testRunner.Given("the caller is assigned the \"Test-Profile-StudentOnly-Resource-IncludeAll\" profile" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
    testRunner.And("the caller is using the \"Test-Profile-StudentOnly2-Resource-IncludeAll\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
    testRunner.When("a GET (by id) request is submitted to students with an accept header content type" +
                    " of the appropriate value for the profile in use", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
    testRunner.Then("the response should contain a 403 Forbidden failure indicating that \"one of the f" +
                    "ollowing profile-specific content types is required when requesting this resourc" +
                    "e\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The caller is assigned a profile and requests a covered resource using the standa" +
            "rd content type header")]
        public virtual void TheCallerIsAssignedAProfileAndRequestsACoveredResourceUsingTheStandardContentTypeHeader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The caller is assigned a profile and requests a covered resource using the standa" +
                    "rd content type header", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
    testRunner.Given("the caller is assigned the \"Test-Profile-Resource-IncludeAll\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
    testRunner.When("a GET (by id) request is submitted to schools with an accept header content type " +
                    "of \"application/json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
    testRunner.Then("the response should contain a 403 Forbidden failure indicating that \"one of the f" +
                    "ollowing profile-specific content types is required when requesting this resourc" +
                    "e\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The caller is assigned a profile and attempts to update a covered resource using " +
            "the correct content type header")]
        public virtual void TheCallerIsAssignedAProfileAndAttemptsToUpdateACoveredResourceUsingTheCorrectContentTypeHeader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The caller is assigned a profile and attempts to update a covered resource using " +
                    "the correct content type header", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
    testRunner.Given("the caller is assigned the \"Test-Profile-Resource-IncludeAll\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
    testRunner.And("the caller is using the \"Test-Profile-Resource-IncludeAll\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.When("a POST request with a resource is submitted to schools with a request body conten" +
                    "t type of the appropriate value for the profile in use", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
    testRunner.Then("the response should indicate success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The caller is assigned a profile and attempts to update a covered resource using " +
            "a different profile\'s content type")]
        public virtual void TheCallerIsAssignedAProfileAndAttemptsToUpdateACoveredResourceUsingADifferentProfileSContentType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The caller is assigned a profile and attempts to update a covered resource using " +
                    "a different profile\'s content type", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
    testRunner.Given("the caller is assigned the \"Test-Profile-StudentOnly-Resource-IncludeAll\" profile" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
    testRunner.And("the caller is using the \"Test-Profile-StudentOnly2-Resource-IncludeAll\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
    testRunner.When("a POST request with a resource is submitted to students with a request body conte" +
                    "nt type of the appropriate value for the profile in use", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
    testRunner.Then("the response should contain a 403 Forbidden failure indicating that \"based on the" +
                    " assigned profiles, one of the following profile-specific content types is requi" +
                    "red when updating this resource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The caller is assigned a profile and attempts to update a covered resource using " +
            "the standard content type header")]
        public virtual void TheCallerIsAssignedAProfileAndAttemptsToUpdateACoveredResourceUsingTheStandardContentTypeHeader()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The caller is assigned a profile and attempts to update a covered resource using " +
                    "the standard content type header", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
    testRunner.Given("the caller is assigned the \"Test-Profile-Resource-IncludeAll\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
    testRunner.When("a POST request with a resource is submitted to schools with a request body conten" +
                    "t type of \"application/json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
    testRunner.Then("the response should contain a 403 Forbidden failure indicating that \"based on the" +
                    " assigned profiles, one of the following profile-specific content types is requi" +
                    "red when updating this resource\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion