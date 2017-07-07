﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BlackbaudDemo40.CRMFeatures
{
    using TechTalk.SpecFlow;
    using System.Configuration;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.IO;
    using System.Drawing.Imaging;
    using ICSharpCode.SharpZipLib.Zip;
    using Blackbaud.UAT.SpecFlow.Selenium;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AdHocQuery")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AdHocQueryFeature : BaseTest
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext { get; set; }//;
        
#line 1 "AdHocQuery.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AdHocQuery", "\tIn order to validate AdHoc Query functionality\r\n\tAs a user of BBCRM\r\n\tI want to " +
                    "add, modify, and validate AdHoc Queries", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "AdHocQuery")))
            {
                BlackbaudDemo40.CRMFeatures.AdHocQueryFeature.FeatureSetup(null);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
            SaveChromeArtifacts(IsPass());
            StopDriver();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            ScenarioContext.Current.Add("Test", this);
            ScenarioContext.Current.Add("uniqueStamp", (DateTime.UtcNow.Subtract(new DateTime(1970, 7, 4)).TotalSeconds).ToString());
            StartDriver();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual bool IsPass()
        {
            Boolean pass = false;
            try { 
                pass = (NUnit.Framework.TestContext.CurrentContext.Result.Status == NUnit.Framework.TestStatus.Passed);
            } catch {
                pass = (TestContext.CurrentTestOutcome == Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestOutcome.Passed);
            }
            return pass;
        }
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        protected virtual void FeatureSetup()
        {
            FeatureSetup(null);
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add an Ad-Hoc Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add an Ad-Hoc Query")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "AdHocQuery")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        [NUnit.Framework.CategoryAttribute("AdHocQuery")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Browser:Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("AdHocQuery")]
        public virtual void AddAnAd_HocQuery()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add an Ad-Hoc Query", new string[] {
                        "Browser:Chrome",
                        "AdHocQuery"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("I add ad-hoc query type \'Revenue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("filter by \'Revenue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FILTEROPERATOR",
                        "VALUE1"});
            table1.AddRow(new string[] {
                        "Greater than",
                        "30000"});
#line 12
 testRunner.And("add filter field \'Amount\'", ((string)(null)), table1, "And ");
#line 15
 testRunner.And("filter by \'Revenue\\Constituent\\Spouse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FILTEROPERATOR",
                        "COMBOVALUE"});
            table2.AddRow(new string[] {
                        "Not equal to",
                        "Male"});
#line 16
 testRunner.And("add filter field \'Gender\'", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Path",
                        "Field"});
            table3.AddRow(new string[] {
                        "Revenue",
                        "Revenue ID"});
            table3.AddRow(new string[] {
                        "Revenue\\Constituent",
                        "Name"});
#line 19
 testRunner.And("add output fields", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Suppress duplicate row",
                        "Create a selection?",
                        "Create a dynamic selection"});
            table4.AddRow(new string[] {
                        "AdHocQuery_472636",
                        "some description",
                        "checked",
                        "checked",
                        "on"});
#line 23
 testRunner.And("set save options", ((string)(null)), table4, "And ");
#line 26
 testRunner.Then("ad-hoc query \'AdHocQuery_472636\' is saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion