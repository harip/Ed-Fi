﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
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
    [NUnit.Framework.DescriptionAttribute("Profile definitions can include and exclude certain properties on resources")]
    [NUnit.Framework.CategoryAttribute("API")]
    [NUnit.Framework.CategoryAttribute("SDK")]
    public partial class ProfileDefinitionsCanIncludeAndExcludeCertainPropertiesOnResourcesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Profile definitions can include and exclude certain properties on resources.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Profile definitions can include and exclude certain properties on resources", "", ProgrammingLanguage.CSharp, new string[] {
                        "API",
                        "SDK"});
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
        [NUnit.Framework.DescriptionAttribute("The Read content type only includes certain properties")]
        [NUnit.Framework.TestCaseAttribute("the SDK", null)]
        [NUnit.Framework.TestCaseAttribute("raw JSON", null)]
        public virtual void TheReadContentTypeOnlyIncludesCertainProperties(string callMechanism, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Read content type only includes certain properties", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("the caller is using the \"Test-Profile-Resource-IncludeOnly\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.When(string.Format("a GET (by id) request is submitted using {0} to schools with an accept header con" +
                        "tent type of the appropriate value for the profile in use", callMechanism), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
    testRunner.Then("the response model should contain the id and the primary key properties of [schoo" +
                    "lId]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
    testRunner.And("the response model should contain the explicitly included properties of [nameOfIn" +
                    "stitution, operationalStatusType, charterApprovalSchoolYearTypeReference, type, " +
                    "administrativeFundingControlDescriptor, addresses, schoolCategories]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
    testRunner.And("the number of properties on the response model should reflect the number of inclu" +
                    "ded properties plus the primary key properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Read content type only excludes certain properties")]
        [NUnit.Framework.TestCaseAttribute("the SDK", null)]
        [NUnit.Framework.TestCaseAttribute("raw JSON", null)]
        public virtual void TheReadContentTypeOnlyExcludesCertainProperties(string callMechanism, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Read content type only excludes certain properties", exampleTags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
    testRunner.Given("the caller is using the \"Test-Profile-Resource-ExcludeOnly\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
    testRunner.When(string.Format("a GET (by id) request is submitted using {0} to schools with an accept header con" +
                        "tent type of the appropriate value for the profile in use", callMechanism), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
    testRunner.Then("the response model should contain the id and the primary key properties of [schoo" +
                    "lId]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
    testRunner.And("the response model should not contain the explicitly excluded properties of [name" +
                    "OfInstitution, operationalStatusType, charterApprovalSchoolYearTypeReference, ty" +
                    "pe, administrativeFundingControlDescriptor, addresses, schoolCategories]", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.And("the number of properties on the response model should reflect the number of prope" +
                    "rties on the full School resource model less the explicitly excluded ones", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Write content type only includes certain properties")]
        [NUnit.Framework.TestCaseAttribute("the SDK", null)]
        [NUnit.Framework.TestCaseAttribute("raw JSON", null)]
        public virtual void TheWriteContentTypeOnlyIncludesCertainProperties(string callMechanism, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Write content type only includes certain properties", exampleTags);
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
    testRunner.Given("the caller is using the \"Test-Profile-Resource-IncludeOnly\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
    testRunner.When(string.Format("a PUT request with a completely updated resource is submitted using {0} to school" +
                        "s with a request body content type of the appropriate value for the profile in u" +
                        "se", callMechanism), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
    testRunner.Then("the persisted entity model should have unmodified primary key values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
    testRunner.And("the only values changed should be the explicitly included values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Write content type only excludes certain properties")]
        [NUnit.Framework.TestCaseAttribute("the SDK", null)]
        [NUnit.Framework.TestCaseAttribute("raw JSON", null)]
        public virtual void TheWriteContentTypeOnlyExcludesCertainProperties(string callMechanism, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Write content type only excludes certain properties", exampleTags);
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
    testRunner.Given("the caller is using the \"Test-Profile-Resource-ExcludeOnly\" profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
    testRunner.When(string.Format("a PUT request with a completely updated resource is submitted using {0} to school" +
                        "s with a request body content type of the appropriate value for the profile in u" +
                        "se", callMechanism), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
    testRunner.Then("the persisted entity model should have unmodified primary key values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
    testRunner.And("the persisted entity model should not have the new values assigned to the explici" +
                    "tly excluded properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
    testRunner.And("the only values not changed should be the explicitly excluded values, the id, and" +
                    " the primary key values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
