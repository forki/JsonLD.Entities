﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace JsonLD.Entities.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Serializing")]
    public partial class SerializingFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Serializing.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Serializing", "  Test serializing models to JSON-LD", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Serialize simple model with blank id")]
        public virtual void SerializeSimpleModelWithBlankId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize simple model with blank id", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("a person without id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 7
    testRunner.Then("the resulting JSON-LD should be:", @"{
    ""@context"": {
        ""foaf"": ""http://xmlns.com/foaf/0.1/"",
        ""name"": ""foaf:givenName"",
        ""surname"": ""foaf:familyName"",
        ""birthDate"": ""http://example.com/ontology#dateOfBirth""
    },
    ""name"": ""Tomasz"",
    ""surname"": ""Pluskiewicz"",
    ""birthDate"": ""1972-09-04T00:00:00""
}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize model with single element in set")]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsArray", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsSet", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsCollection", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsEnumerable", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsGenerator", null)]
        public virtual void SerializeModelWithSingleElementInSet(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize model with single element in set", exampleTags);
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
    testRunner.Given(string.Format("model of type \'{0}\'", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
      testRunner.And("model has interest \'RDF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
     testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
     testRunner.Then("the resulting JSON-LD should be:", "{\r\n    \"@context\": {\r\n       \"foaf\": \"http://xmlns.com/foaf/0.1/\",\r\n       \"inter" +
                    "ests\": { \"@id\": \"foaf:topic_interest\", \"@container\": \"@set\" }\r\n    },\r\n    \"inte" +
                    "rests\": [ \"RDF\" ]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize model with single element in list")]
        public virtual void SerializeModelWithSingleElementInList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize model with single element in list", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
    testRunner.Given("model of type \'JsonLD.Entities.Tests.Entities.HasInterestsList\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
      testRunner.And("model has interest \'RDF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
     testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
     testRunner.Then("the resulting JSON-LD should be:", "{\r\n    \"@context\": {\r\n       \"foaf\": \"http://xmlns.com/foaf/0.1/\",\r\n       \"inter" +
                    "ests\": { \"@id\": \"foaf:topic_interest\", \"@container\": \"@list\" }\r\n    },\r\n    \"int" +
                    "erests\": [ \"RDF\" ]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize model with empty collection")]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsGenerator", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsSet", null)]
        public virtual void SerializeModelWithEmptyCollection(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize model with empty collection", exampleTags);
#line 59
this.ScenarioSetup(scenarioInfo);
#line 60
    testRunner.Given(string.Format("model of type \'{0}\'", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
     testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
     testRunner.Then("the resulting JSON-LD should be:", "{\r\n    \"@context\": {\r\n       \"foaf\": \"http://xmlns.com/foaf/0.1/\",\r\n       \"inter" +
                    "ests\": { \"@id\": \"foaf:topic_interest\", \"@container\": \"@set\" }\r\n    }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
