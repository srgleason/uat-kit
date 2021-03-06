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
    [NUnit.Framework.DescriptionAttribute("Revenue")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class RevenueFeature : BaseTest
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext { get; set; }//;
        
#line 1 "Revenue.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Revenue", "\tIn order to validate Revenue functionality\r\n\tAs a user of BBCRM\r\n\tI want to add," +
                    " modify, and validate Pledges and Batches", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Revenue")))
            {
                BlackbaudDemo40.CRMFeatures.RevenueFeature.FeatureSetup(null);
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
        [NUnit.Framework.DescriptionAttribute("Add a pledge")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a pledge")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddAPledge()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a pledge", new string[] {
                        "Revenue"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("constituent \'Paul Simon\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Constituent",
                        "Amount",
                        "Designations",
                        "Date",
                        "Frequency",
                        "Starting on",
                        "No. installments",
                        "Pledge is anonymous"});
            table1.AddRow(new string[] {
                        "Paul Simon",
                        "$300.00",
                        "Camp Kids Scholarship",
                        "01/01/2015",
                        "Monthly",
                        "01/01/2020",
                        "3",
                        "checked"});
#line 10
 testRunner.When("I add a pledge", ((string)(null)), table1, "When ");
#line 13
 testRunner.Then("a pledge exists for constituent \"Paul Simon\" with amount \"$300.00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a pledge with multiple designations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a pledge with multiple designations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddAPledgeWithMultipleDesignations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a pledge with multiple designations", new string[] {
                        "Revenue"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.And("constituent \'Art Garfunkel\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("designation exists \'Building Fund\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("designation exists \'Library Books\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Constituent",
                        "Amount"});
            table2.AddRow(new string[] {
                        "Art Garfunkel",
                        "$300.00"});
#line 21
 testRunner.When("I start to add a pledge", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Amount"});
            table3.AddRow(new string[] {
                        "Building Fund",
                        "$300.00"});
            table3.AddRow(new string[] {
                        "Library Books",
                        "$0.00"});
#line 24
 testRunner.And("split the pledge designations evenly", ((string)(null)), table3, "And ");
#line 28
 testRunner.And("save the pledge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Amount",
                        "Balance"});
            table4.AddRow(new string[] {
                        "Building Fund",
                        "$150.00",
                        "$150.00"});
            table4.AddRow(new string[] {
                        "Library Books",
                        "$150.00",
                        "$150.00"});
#line 29
 testRunner.Then("a pledge exists with designations", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a pledge with multiple designations through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a pledge with multiple designations through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddAPledgeWithMultipleDesignationsThroughABatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a pledge with multiple designations through a batch", new string[] {
                        "Revenue"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.And("constituent \'Tom Brady\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account system",
                        "Constituent",
                        "Amount",
                        "Date",
                        "Revenue type",
                        "Payment method",
                        "GL post status"});
            table5.AddRow(new string[] {
                        "System Generated Account System",
                        "Tom Brady",
                        "$200.00",
                        "01/01/2015",
                        "Pledge",
                        "None",
                        "Do not post"});
#line 38
 testRunner.When("I start to add a batch with template \"Enhanced Revenue Batch\" and description \"To" +
                    "m\'s pledge\"", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Amount"});
            table6.AddRow(new string[] {
                        "Library Books",
                        "$99.00"});
            table6.AddRow(new string[] {
                        "Building Fund",
                        "$101.00"});
#line 41
 testRunner.And("split the designations", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Batch template",
                        "Description"});
            table7.AddRow(new string[] {
                        "Enhanced Revenue Batch",
                        "Tom\'s pledge"});
#line 45
 testRunner.And("save the batch and commit it", ((string)(null)), table7, "And ");
#line 48
 testRunner.Then("the batch commits without errors or exceptions and 1 record processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Amount"});
            table8.AddRow(new string[] {
                        "Library Books",
                        "$99.00"});
            table8.AddRow(new string[] {
                        "Building Fund",
                        "$101.00"});
#line 49
 testRunner.And("the revenue record for \"Tom Brady\" has designations", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a recurring gift with multiple designations through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a recurring gift with multiple designations through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddARecurringGiftWithMultipleDesignationsThroughABatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a recurring gift with multiple designations through a batch", new string[] {
                        "Revenue"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.And("constituent \'Joe Flacco\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Constituent",
                        "Amount",
                        "Date",
                        "Revenue type",
                        "Payment method"});
            table9.AddRow(new string[] {
                        "Joe Flacco",
                        "$100.00",
                        "01/01/2015",
                        "Recurring gift",
                        "None"});
#line 58
 testRunner.When("I start to add a batch with template \"Enhanced Revenue Batch\" and description \"Jo" +
                    "e\'s recurring gift\"", ((string)(null)), table9, "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Amount"});
            table10.AddRow(new string[] {
                        "Library Books",
                        "$75.00"});
            table10.AddRow(new string[] {
                        "Building Fund",
                        "$25.00"});
#line 61
 testRunner.And("split the designations", ((string)(null)), table10, "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Batch template",
                        "Description"});
            table11.AddRow(new string[] {
                        "Enhanced Revenue Batch",
                        "Joe\'s recurring gift"});
#line 65
 testRunner.And("save the batch and commit it", ((string)(null)), table11, "And ");
#line 68
 testRunner.Then("the batch commits without errors or exceptions and 1 record processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Amount"});
            table12.AddRow(new string[] {
                        "Library Books",
                        "$75.00"});
            table12.AddRow(new string[] {
                        "Building Fund",
                        "$25.00"});
#line 69
 testRunner.And("the recurring gift revenue record for \"Joe Flacco\" has designations", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add an enhanced revenue batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add an enhanced revenue batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddAnEnhancedRevenueBatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add an enhanced revenue batch", new string[] {
                        "Revenue"});
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
 testRunner.And("constituent \'Eli Manning\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account system",
                        "Constituent",
                        "Amount",
                        "Date",
                        "Revenue type",
                        "Payment method",
                        "Designation",
                        "Installment frequency",
                        "Installment start date",
                        "No. installments"});
            table13.AddRow(new string[] {
                        "System Generated Account System",
                        "Eli Manning",
                        "$200.00",
                        "01/01/2015",
                        "Pledge",
                        "None",
                        "Library Fund",
                        "Monthly",
                        "01/01/2020",
                        "3"});
            table13.AddRow(new string[] {
                        "System Generated Account System",
                        "Eli Manning",
                        "$200.00",
                        "01/01/2015",
                        "Pledge",
                        "None",
                        "Library Books",
                        "Monthly",
                        "01/01/2020",
                        "3"});
#line 78
 testRunner.When("I add a batch with template \"Enhanced Revenue Batch\" and description \"ERB\"", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Batch template",
                        "Description"});
            table14.AddRow(new string[] {
                        "Enhanced Revenue Batch",
                        "ERB"});
#line 82
 testRunner.Then("a batch exists", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Split a designation in an enhanced revenue batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split a designation in an enhanced revenue batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void SplitADesignationInAnEnhancedRevenueBatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split a designation in an enhanced revenue batch", new string[] {
                        "Revenue"});
#line 87
this.ScenarioSetup(scenarioInfo);
#line 88
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
 testRunner.And("constituent \'Rusell Wilson\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account system",
                        "Constituent",
                        "Amount",
                        "Date",
                        "Revenue type",
                        "Payment method",
                        "Designation",
                        "Installment frequency",
                        "Installment start date",
                        "No. installments"});
            table15.AddRow(new string[] {
                        "System Generated Account System",
                        "Rusell Wilson",
                        "$500.00",
                        "01/01/2015",
                        "Pledge",
                        "None",
                        "Library Books",
                        "Monthly",
                        "01/01/2020",
                        "5"});
#line 90
 testRunner.When("I start to add a batch with template \"Enhanced Revenue Batch\" and description \"ER" +
                    "B\"", ((string)(null)), table15, "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation"});
            table16.AddRow(new string[] {
                        "Library Books"});
            table16.AddRow(new string[] {
                        "Building Fund"});
#line 93
 testRunner.And("split the designations evenly", ((string)(null)), table16, "And ");
#line 97
 testRunner.Then("the \'Designation\' cell value is \'<split>\' for row 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Commit an enhanced revenue batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Commit an enhanced revenue batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void CommitAnEnhancedRevenueBatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Commit an enhanced revenue batch", new string[] {
                        "Revenue"});
#line 100
this.ScenarioSetup(scenarioInfo);
#line 101
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 102
 testRunner.And("constituent \'Drew Brees\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account system",
                        "Constituent",
                        "Amount",
                        "Date",
                        "Revenue type",
                        "Payment method",
                        "Designation",
                        "Installment frequency",
                        "Installment start date",
                        "No. installments",
                        "GL post status"});
            table17.AddRow(new string[] {
                        "System Generated Account System",
                        "Drew Brees",
                        "$500.00",
                        "01/01/2015",
                        "Pledge",
                        "None",
                        "Library Fund",
                        "Monthly",
                        "01/01/2020",
                        "5",
                        "Do not post"});
#line 103
 testRunner.And("an \"Enhanced Revenue Batch\" with description \"TO COMMIT\" exists", ((string)(null)), table17, "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Batch template",
                        "Description"});
            table18.AddRow(new string[] {
                        "Enhanced Revenue Batch",
                        "TO COMMIT"});
#line 106
 testRunner.When("I commit the batch", ((string)(null)), table18, "When ");
#line 109
 testRunner.Then("the batch commits without errors or exceptions and 1 record processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a pledge with a pledge subtype though a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a pledge with a pledge subtype though a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddAPledgeWithAPledgeSubtypeThoughABatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a pledge with a pledge subtype though a batch", new string[] {
                        "Revenue"});
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
 testRunner.And("constituent \'Aaron Rodgers\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("the pledge subtype \'ERBAddPledgeWithSubtype\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account system",
                        "Constituent",
                        "Amount",
                        "Date",
                        "Revenue type",
                        "Payment method",
                        "Designation",
                        "Installment frequency",
                        "Installment start date",
                        "No. installments",
                        "GL post status",
                        "Pledge subtype"});
            table19.AddRow(new string[] {
                        "System Generated Account System",
                        "Aaron Rodgers",
                        "$500.00",
                        "01/01/2015",
                        "Pledge",
                        "None",
                        "Library Fund",
                        "Monthly",
                        "01/01/2020",
                        "5",
                        "Do not post",
                        "ERBAddPledgeWithSubtype"});
#line 116
 testRunner.And("an \"Enhanced Revenue Batch\" with description \"Pledge Subtype\" exists", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Batch template",
                        "Description"});
            table20.AddRow(new string[] {
                        "Enhanced Revenue Batch",
                        "Pledge Subtype"});
#line 119
 testRunner.When("I commit the batch", ((string)(null)), table20, "When ");
#line 122
 testRunner.And("the batch completes successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("navigate to the revenue record for \"Aaron Rodgers\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.Then("the pledge subtype is \"ERBAddPledgeWithSubtype\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a donation payment with multiple designations through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a donation payment with multiple designations through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddADonationPaymentWithMultipleDesignationsThroughABatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a donation payment with multiple designations through a batch", new string[] {
                        "Revenue"});
#line 127
this.ScenarioSetup(scenarioInfo);
#line 128
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 129
 testRunner.And("constituent \'Cam Newton\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account system",
                        "Constituent",
                        "Amount",
                        "Date",
                        "Revenue type",
                        "Payment method",
                        "GL post status"});
            table21.AddRow(new string[] {
                        "System Generated Account System",
                        "Cam Newton",
                        "$200.00",
                        "01/01/2015",
                        "Payment",
                        "Cash",
                        "Do not post"});
#line 130
 testRunner.When("I start to add a batch with template \"Enhanced Revenue Batch\" and description \"Ca" +
                    "m\'s donation\"", ((string)(null)), table21, "When ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Additional applications",
                        "Applied amount",
                        "Designation"});
            table22.AddRow(new string[] {
                        "Donation",
                        "$50.00",
                        "LIBRARY BOOKS"});
            table22.AddRow(new string[] {
                        "Donation",
                        "$150.00",
                        "Camp Kids Scholarship"});
#line 133
 testRunner.And("apply the payment to designations", ((string)(null)), table22, "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Batch template",
                        "Description"});
            table23.AddRow(new string[] {
                        "Enhanced Revenue Batch",
                        "Cam\'s donation"});
#line 137
 testRunner.And("save the batch and commit it", ((string)(null)), table23, "And ");
#line 140
 testRunner.Then("the batch commits without errors or exceptions and 1 record processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Recognition credits"});
            table24.AddRow(new string[] {
                        "Library Books",
                        "$50.00"});
            table24.AddRow(new string[] {
                        "Camp Kids Scholarship",
                        "$150.00"});
#line 141
 testRunner.And("the revenue record for \"Cam Newton\" has payments", ((string)(null)), table24, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add a payment towards multiple commitments through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a payment towards multiple commitments through a batch")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Revenue")]
        [NUnit.Framework.CategoryAttribute("Revenue")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Revenue")]
        public virtual void AddAPaymentTowardsMultipleCommitmentsThroughABatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a payment towards multiple commitments through a batch", new string[] {
                        "Revenue"});
#line 147
this.ScenarioSetup(scenarioInfo);
#line 148
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 149
 testRunner.And("constituent \'Tony Romo\' exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Constituent",
                        "Amount",
                        "Designations",
                        "Frequency",
                        "No. installments",
                        "Post status"});
            table25.AddRow(new string[] {
                        "Tony Romo",
                        "$250.00",
                        "Camp Kids Scholarship",
                        "Monthly",
                        "5",
                        "Do not post"});
            table25.AddRow(new string[] {
                        "Tony Romo",
                        "$500.00",
                        "Smith-Brown Scholarship Fund",
                        "Monthly",
                        "5",
                        "Do not post"});
#line 150
 testRunner.And("pledges exist", ((string)(null)), table25, "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Account system",
                        "Constituent",
                        "Amount",
                        "Date",
                        "Payment method",
                        "GL post status"});
            table26.AddRow(new string[] {
                        "System Generated Account System",
                        "Tony Romo",
                        "$75.00",
                        "01/01/2015",
                        "Cash",
                        "Do not post"});
#line 154
 testRunner.When("I start to add a batch with template \"Enhanced Revenue Batch\" and description \"To" +
                    "ny\'s payment\"", ((string)(null)), table26, "When ");
#line 157
 testRunner.And("set the revenue type for row 1 to \"Payment\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("auto apply the payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Batch template",
                        "Description"});
            table27.AddRow(new string[] {
                        "Enhanced Revenue Batch",
                        "Tony\'s payment"});
#line 159
 testRunner.And("save the batch and commit it", ((string)(null)), table27, "And ");
#line 162
 testRunner.Then("the batch commits without errors or exceptions and 1 record processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Designation",
                        "Recognition credits"});
            table28.AddRow(new string[] {
                        "Smith-Brown Scholarship Fund",
                        "$25.00"});
            table28.AddRow(new string[] {
                        "Camp Kids Scholarship",
                        "$50.00"});
#line 163
 testRunner.And("the revenue record for \"Tony Romo\" has payments", ((string)(null)), table28, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
