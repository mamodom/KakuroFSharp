﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Kakuro.Core.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Parse Kakuro Board")]
    public partial class ParseKakuroBoardFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ParseKakuroBoard.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Parse Kakuro Board", "In order to play kakuro\r\nAs a kakuro lover\r\nI want to be able to open a kakuro bo" +
                    "ard", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Parse Board")]
        public virtual void ParseBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse Board", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "A",
                        "B",
                        "C",
                        "D",
                        "E"});
            table1.AddRow(new string[] {
                        "\\",
                        "17\\",
                        "11\\",
                        "30\\",
                        "\\"});
            table1.AddRow(new string[] {
                        "\\19",
                        "",
                        "",
                        "",
                        "\\"});
            table1.AddRow(new string[] {
                        "\\15",
                        "",
                        "",
                        "",
                        "\\17"});
            table1.AddRow(new string[] {
                        "\\",
                        "\\20",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "\\",
                        "\\21",
                        "",
                        "",
                        ""});
#line 7
 testRunner.Given("this board named \'Kakuro1\' exists", ((string)(null)), table1, "Given ");
#line 14
 testRunner.When("I parse the board named \'Kakuro1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "A",
                        "B",
                        "C",
                        "D",
                        "E"});
            table2.AddRow(new string[] {
                        "\\",
                        "17\\",
                        "11\\",
                        "30\\",
                        "\\"});
            table2.AddRow(new string[] {
                        "\\19",
                        "",
                        "",
                        "",
                        "\\"});
            table2.AddRow(new string[] {
                        "\\15",
                        "",
                        "",
                        "",
                        "\\17"});
            table2.AddRow(new string[] {
                        "\\",
                        "\\20",
                        "",
                        "",
                        ""});
            table2.AddRow(new string[] {
                        "\\",
                        "\\21",
                        "",
                        "",
                        ""});
#line 15
 testRunner.Then("I should be able to see this board", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion