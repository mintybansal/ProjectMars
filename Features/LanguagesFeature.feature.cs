﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mars.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LanguageFeature")]
    public partial class LanguageFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LanguagesFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LanguageFeature", "\tIn order to update my profile\r\n\tAs a skill trader\r\n\tI want to add, update, delet" +
                    "e language", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add new language")]
        [NUnit.Framework.CategoryAttribute("autoamte")]
        [NUnit.Framework.TestCaseAttribute("English", null)]
        [NUnit.Framework.TestCaseAttribute("French", null)]
        [NUnit.Framework.TestCaseAttribute("Hindi", null)]
        [NUnit.Framework.TestCaseAttribute("German", null)]
        public virtual void CheckIfUserIsAbleToAddNewLanguage(string language, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "autoamte"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add new language", null, @__tags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("I clicked on the Languages tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I clicked on add {0}", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
    testRunner.Then(string.Format("the new {0} should display on my listings", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to update the language")]
        [NUnit.Framework.CategoryAttribute("automate")]
        public virtual void CheckIfUserIsAbleToUpdateTheLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to update the language", null, new string[] {
                        "automate"});
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
testRunner.Given("I clicked on the Languages tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
testRunner.When("I clicked on pencil icon and update language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then("the updated language should display on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to delete the language")]
        [NUnit.Framework.CategoryAttribute("automate")]
        public virtual void CheckIfUserIsAbleToDeleteTheLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to delete the language", null, new string[] {
                        "automate"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
testRunner.Given("I clicked on the Languages tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.When("I clicked on delete icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.Then("the deleted language should not display on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add more than four language")]
        [NUnit.Framework.CategoryAttribute("manual")]
        [NUnit.Framework.TestCaseAttribute("English", null)]
        [NUnit.Framework.TestCaseAttribute("French", null)]
        [NUnit.Framework.TestCaseAttribute("Hindi", null)]
        [NUnit.Framework.TestCaseAttribute("Irish", null)]
        [NUnit.Framework.TestCaseAttribute("German", null)]
        public virtual void CheckIfUserIsAbleToAddMoreThanFourLanguage(string language, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "manual"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add more than four language", null, @__tags);
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
testRunner.Given("I clicked on the Languages tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
testRunner.Given(string.Format("I have four {0} in my list", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
testRunner.Then("I should not able to add more language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add language without choosing the language level")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddLanguageWithoutChoosingTheLanguageLevel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add language without choosing the language level", null, new string[] {
                        "manual"});
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 47
testRunner.Given("I clicked on the Languages tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
testRunner.When("I clicked on AddNew button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
testRunner.And("I entered the new language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
testRunner.But("I don\'t choose the language level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 51
testRunner.Then("I should not able to add language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

