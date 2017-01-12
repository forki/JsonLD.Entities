﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Serializing")]
    public partial class SerializingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Serializing.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Serializing", "    Test serializing models to JSON-LD", ProgrammingLanguage.CSharp, ((string[])(null)));
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
    testRunner.Then("the resulting JSON-LD should be:", "{\r\n    \"name\": \"Tomasz\",\r\n    \"surname\": \"Pluskiewicz\",\r\n    \"birthDate\": \"1972-0" +
                    "9-04T00:00:00\"\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize model with single element in set")]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsArray", new string[0])]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsSet", new string[0])]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsCollection", new string[0])]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsEnumerable", new string[0])]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsGenerator", new string[0])]
        public virtual void SerializeModelWithSingleElementInSet(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize model with single element in set", exampleTags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
    testRunner.Given(string.Format("model of type \'{0}\'", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
      testRunner.And("model has interest \'RDF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
     testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
     testRunner.Then("the resulting JSON-LD should be:", "{\r\n    \"interests\": [ \"RDF\" ]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize model with single element in list")]
        public virtual void SerializeModelWithSingleElementInList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize model with single element in list", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
    testRunner.Given("model of type \'JsonLD.Entities.Tests.Entities.HasInterestsList\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
      testRunner.And("model has interest \'RDF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
     testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
     testRunner.Then("the resulting JSON-LD should be:", "{\r\n    \"interests\": [ \"RDF\" ]\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize model with empty collection")]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsGenerator", new string[0])]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsSet", new string[0])]
        public virtual void SerializeModelWithEmptyCollection(string type, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize model with empty collection", exampleTags);
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
    testRunner.Given(string.Format("model of type \'{0}\'", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
     testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
     testRunner.Then("the resulting JSON-LD should be:", "{\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serialize model with prefixed name in ClassAttribute")]
        public virtual void SerializeModelWithPrefixedNameInClassAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serialize model with prefixed name in ClassAttribute", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
    testRunner.Given("model of type \'JsonLD.Entities.Tests.Entities.PersonWithPrefixedClass\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 60
    testRunner.And("@context is:", "{\r\n   \"ex\": \"http://example.com/ontology#\"\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
    testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
    testRunner.Then("the resulting JSON-LD should be:", "{\r\n    \"@type\": \"ex:Person\"\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serializing primitive values should produce short literals for Boolean, Double an" +
            "d String")]
        public virtual void SerializingPrimitiveValuesShouldProduceShortLiteralsForBooleanDoubleAndString()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serializing primitive values should produce short literals for Boolean, Double an" +
                    "d String", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table1.AddRow(new string[] {
                        "string",
                        "Hello"});
            table1.AddRow(new string[] {
                        "double",
                        "3.14"});
            table1.AddRow(new string[] {
                        "bool",
                        "true"});
#line 75
 testRunner.Given("model of type \'JsonLD.Entities.Tests.Entities.AllPrimitives\'", ((string)(null)), table1, "Given ");
#line 80
 testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("the resulting JSON-LD should be:", "{\r\n\"string\": \"Hello\",\r\n\"double\": 3.14,\r\n\"bool\": true\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Serializing primitive values should produce typed literals")]
        [NUnit.Framework.TestCaseAttribute("date", "2016-01-03", "2016-01-03T00:00:00", "dateTime", new string[0])]
        [NUnit.Framework.TestCaseAttribute("decimal", "3.4", "3.4", "decimal", new string[0])]
        [NUnit.Framework.TestCaseAttribute("long", "100", "100", "long", new string[0])]
        [NUnit.Framework.TestCaseAttribute("ulong", "100", "100", "unsignedLong", new string[0])]
        [NUnit.Framework.TestCaseAttribute("int", "1567", "1567", "int", new string[0])]
        [NUnit.Framework.TestCaseAttribute("uint", "15", "15", "unsignedInt", new string[0])]
        [NUnit.Framework.TestCaseAttribute("short", "17", "17", "short", new string[0])]
        [NUnit.Framework.TestCaseAttribute("ushort", "3", "3", "unsignedShort", new string[0])]
        [NUnit.Framework.TestCaseAttribute("byte", "20", "20", "unsignedByte", new string[0])]
        [NUnit.Framework.TestCaseAttribute("sbyte", "-3", "-3", "byte", new string[0])]
        [NUnit.Framework.TestCaseAttribute("float", "2.3456", "2.3456", "float", new string[0])]
        [NUnit.Framework.TestCaseAttribute("timeSpan", "100", "100", "duration", new string[0])]
        public virtual void SerializingPrimitiveValuesShouldProduceTypedLiterals(string property, string value, string jsonValue, string xsdType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serializing primitive values should produce typed literals", exampleTags);
#line 90
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table2.AddRow(new string[] {
                        string.Format("{0}", property),
                        string.Format("{0}", value)});
#line 91
 testRunner.Given("model of type \'JsonLD.Entities.Tests.Entities.AllPrimitives\'", ((string)(null)), table2, "Given ");
#line 94
 testRunner.When("the object is serialized", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("the resulting JSON-LD should be:", string.Format("{{\r\n\"{0}\": {{\r\n\"@value\": \"{1}\",\r\n\"@type\": \"http://www.w3.org/2001/XMLSchema#{0}\"\r" +
                        "\n}}\r\n}}", property, jsonValue), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
