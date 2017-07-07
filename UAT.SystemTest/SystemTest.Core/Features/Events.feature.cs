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
namespace SystemTest.Core.Features
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
    [NUnit.Framework.DescriptionAttribute("Events")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class EventsFeature : BaseTest
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext { get; set; }//;
        
#line 1 "Events.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Events", "\tIn order to test event functionality \r\n\tAs a BBCRM user\r\n\tI want to manage Event" +
                    " records, registrations, invitations and responses", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Events")))
            {
                SystemTest.Core.Features.EventsFeature.FeatureSetup(null);
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
        [NUnit.Framework.DescriptionAttribute("Events: Add a multilevel Event record")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Events: Add a multilevel Event record")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Events")]
        [NUnit.Framework.CategoryAttribute("Ready")]
        [NUnit.Framework.CategoryAttribute("Events")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Ready")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Events")]
        public virtual void EventsAddAMultilevelEventRecord()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Events: Add a multilevel Event record", new string[] {
                        "Ready",
                        "Events"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Start date",
                        "Category"});
            table1.AddRow(new string[] {
                        "EventA",
                        "Today",
                        "Sport"});
            table1.AddRow(new string[] {
                        "EventB",
                        "Today",
                        "Sport"});
            table1.AddRow(new string[] {
                        "EventC",
                        "Today",
                        "Sport"});
#line 10
 testRunner.And("an event exists", ((string)(null)), table1, "And ");
#line 15
 testRunner.And("Event management template \"Sample Template 1\" exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "event",
                        "parent"});
            table2.AddRow(new string[] {
                        "EventA",
                        ""});
            table2.AddRow(new string[] {
                        "EventB",
                        "EventA"});
            table2.AddRow(new string[] {
                        "EventC",
                        "EventB"});
#line 16
 testRunner.When("I create a multi-event using template \"Sample Template 1\"", ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "event",
                        "parent"});
            table3.AddRow(new string[] {
                        "EventA",
                        ""});
            table3.AddRow(new string[] {
                        "EventB",
                        "EventA"});
            table3.AddRow(new string[] {
                        "EventC",
                        "EventB"});
#line 21
 testRunner.Then("a multi-level event \"EventA - Default Summary\" exists with hierarchy", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Events: Add multiple Registration options to a single event")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Events: Add multiple Registration options to a single event")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Events")]
        [NUnit.Framework.CategoryAttribute("Ready")]
        [NUnit.Framework.CategoryAttribute("Events")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Ready")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Events")]
        public virtual void EventsAddMultipleRegistrationOptionsToASingleEvent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Events: Add multiple Registration options to a single event", new string[] {
                        "Ready",
                        "Events"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Start date",
                        "Category"});
            table4.AddRow(new string[] {
                        "Brunch Event",
                        "Today",
                        "Brunch"});
#line 31
 testRunner.And("an event exists", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Registration type",
                        "Registration count",
                        "Registration fee"});
            table5.AddRow(new string[] {
                        "Adult",
                        "1",
                        "$75.00"});
            table5.AddRow(new string[] {
                        "Couple",
                        "2",
                        "$150.00"});
#line 34
 testRunner.When("I add a Registration Option to event \"Brunch Event\"", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Registration type",
                        "Registration fee"});
            table6.AddRow(new string[] {
                        "Adult",
                        "$75.00"});
            table6.AddRow(new string[] {
                        "Couple",
                        "$150.00"});
#line 38
 testRunner.Then("event \"Brunch Event\" has registration option", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Events: Add multiple invitees to an invitation using selection and excluding Dece" +
            "ased")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Events: Add multiple invitees to an invitation using selection and excluding Dece" +
            "ased")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Events")]
        [NUnit.Framework.CategoryAttribute("Ready")]
        [NUnit.Framework.CategoryAttribute("Events")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Ready")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Events")]
        public virtual void EventsAddMultipleInviteesToAnInvitationUsingSelectionAndExcludingDeceased()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Events: Add multiple invitees to an invitation using selection and excluding Dece" +
                    "ased", new string[] {
                        "Ready",
                        "Events"});
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Last name",
                        "First name",
                        "Title",
                        "Nickname",
                        "Information source"});
            table7.AddRow(new string[] {
                        "Salmon",
                        "Jon",
                        "Mr.",
                        "Lord Salmon",
                        "Other"});
            table7.AddRow(new string[] {
                        "Lange",
                        "Ty",
                        "Mr.",
                        "Lord Ty",
                        "Other"});
            table7.AddRow(new string[] {
                        "Strong",
                        "Andrea",
                        "Ms.",
                        "Lady Andrea",
                        "Other"});
            table7.AddRow(new string[] {
                        "Taylor",
                        "Al",
                        "Mr.",
                        "Lord Al",
                        "Other"});
#line 47
 testRunner.And("I add individual(s)", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Start date",
                        "Category"});
            table8.AddRow(new string[] {
                        "Wedding",
                        "today",
                        "Formal"});
#line 53
 testRunner.And("an event exists", ((string)(null)), table8, "And ");
#line 56
 testRunner.And("an invitation \"Wedding Invitation\" exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("I add a Constituent ad-hoc query", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table9.AddRow(new string[] {
                        "FILTEROPERATOR",
                        "One of"});
            table9.AddRow(new string[] {
                        "VALUE",
                        "Jon Salmon"});
            table9.AddRow(new string[] {
                        "VALUE",
                        "Ty Lange"});
            table9.AddRow(new string[] {
                        "VALUE",
                        "Andrea Strong"});
            table9.AddRow(new string[] {
                        "VALUE",
                        "Al Taylor"});
#line 58
 testRunner.And("include \"Constituent\" record \"Constituent record\" field with criteria", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Create Selection",
                        "Static",
                        "Show in Query Designer"});
            table10.AddRow(new string[] {
                        "Invitees for Wedding",
                        "Ad-hoc Query UAT Test",
                        "true",
                        "",
                        ""});
#line 65
 testRunner.And("I save Query Designer with the following options", ((string)(null)), table10, "And ");
#line 68
 testRunner.And("Constituent \"Al Taylor\" is marked as deceased with source of \"Test\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("I select event \"Wedding\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.When("I Add multiple invitees to invitation \"Wedding Invitation\" from selection \"Invite" +
                    "es for Wedding\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Forename",
                        "Surname",
                        "Include in next send"});
            table11.AddRow(new string[] {
                        "Ty",
                        "Lange",
                        "checked"});
            table11.AddRow(new string[] {
                        "Jon",
                        "Salmon",
                        "checked"});
            table11.AddRow(new string[] {
                        "Andrea",
                        "Strong",
                        "checked"});
#line 71
 testRunner.Then("Event Invitation Invitee List shows Invitees", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Events: Register an event invitee for a single event with a guest who is not a co" +
            "nstituent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Events: Register an event invitee for a single event with a guest who is not a co" +
            "nstituent")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Events")]
        [NUnit.Framework.CategoryAttribute("Ready")]
        [NUnit.Framework.CategoryAttribute("Events")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Ready")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Events")]
        public virtual void EventsRegisterAnEventInviteeForASingleEventWithAGuestWhoIsNotAConstituent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Events: Register an event invitee for a single event with a guest who is not a co" +
                    "nstituent", new string[] {
                        "Ready",
                        "Events"});
#line 79
this.ScenarioSetup(scenarioInfo);
#line 80
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Address type",
                        "Country",
                        "Address",
                        "City",
                        "State",
                        "ZIP",
                        "Information source",
                        "Last name",
                        "First name"});
            table12.AddRow(new string[] {
                        "Home",
                        "United States",
                        "12 Hope Road",
                        "Charleston",
                        "SC",
                        "12345",
                        "Other",
                        "Brown",
                        "Merideth"});
#line 81
 testRunner.And("Individual constituent exists with an address", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Registration type",
                        "Registration count",
                        "Registration fee"});
            table13.AddRow(new string[] {
                        "Adult",
                        "1",
                        "$100.00"});
#line 84
 testRunner.And("Event \"Test Event\" exists with Registration Option and start date \"Today +6 month" +
                    "s\"", ((string)(null)), table13, "And ");
#line 87
 testRunner.And("Marketing Export Definitions \"UAT Test Export\" exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("Mail Package record \"UAT Events\" exists with Export Definition \"UAT Test Export\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Mail date",
                        "Mail package",
                        "How to send invitation"});
            table14.AddRow(new string[] {
                        "College Reunion Invitation",
                        "College Reunion Invitation UAT",
                        "Today",
                        "UAT Events",
                        "Send through mail only"});
#line 89
 testRunner.And("Invitation to the event \"Test Event\" includes a mail package", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Invitee"});
            table15.AddRow(new string[] {
                        "Merideth Brown"});
#line 92
 testRunner.And("I add Invitees to invitation \"College Reunion Invitation\"", ((string)(null)), table15, "And ");
#line 95
 testRunner.When("I send the invitation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Registration option",
                        "Registrant"});
            table16.AddRow(new string[] {
                        "Adult",
                        "Merideth Brown"});
            table16.AddRow(new string[] {
                        "Adult",
                        "(Unnamed guest)"});
#line 96
 testRunner.And("I register the invitee", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Status",
                        "Registrant",
                        "Guest 1",
                        "Guest 2"});
            table17.AddRow(new string[] {
                        "Invitation",
                        "Registered",
                        "Merideth Brown",
                        "Guest of Merideth Brown",
                        ""});
#line 100
 testRunner.Then("Registration(s) are listed on Registrant page", ((string)(null)), table17, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Registrant First Name",
                        "Registrant Last Name",
                        "Extra",
                        "Balance"});
            table18.AddRow(new string[] {
                        "Merideth",
                        "Brown",
                        "",
                        "$200.00"});
            table18.AddRow(new string[] {
                        "Merideth",
                        "Brown",
                        "Guest of",
                        "$0.00"});
#line 103
 testRunner.And("Event \"Test Event\" displays registrant(s) on Registrations tab", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Events: Mark Event invitee as declined")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Events: Mark Event invitee as declined")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Events")]
        [NUnit.Framework.CategoryAttribute("Ready")]
        [NUnit.Framework.CategoryAttribute("Events")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Ready")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Events")]
        public virtual void EventsMarkEventInviteeAsDeclined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Events: Mark Event invitee as declined", new string[] {
                        "Ready",
                        "Events"});
#line 110
this.ScenarioSetup(scenarioInfo);
#line 111
 testRunner.Given("I have logged into the BBCRM home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Address type",
                        "Country",
                        "Address",
                        "City",
                        "State",
                        "ZIP",
                        "Information source",
                        "Last name",
                        "First name"});
            table19.AddRow(new string[] {
                        "Home",
                        "United States",
                        "14 Shadow Road",
                        "Greenville",
                        "SC",
                        "12345",
                        "Other",
                        "Holland",
                        "Mary"});
#line 112
 testRunner.And("Individual constituent exists with an address", ((string)(null)), table19, "And ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Registration type",
                        "Registration count",
                        "Registration fee"});
            table20.AddRow(new string[] {
                        "Adult",
                        "1",
                        "$100.00"});
#line 115
 testRunner.And("Event \"Test Event\" exists with Registration Option and start date \"Today +6 month" +
                    "s\"", ((string)(null)), table20, "And ");
#line 118
 testRunner.And("Marketing Export Definitions \"UAT Test Export\" exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("Mail Package record \"UAT Events\" exists with Export Definition \"UAT Test Export\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Mail date",
                        "Mail package",
                        "How to send invitation"});
            table21.AddRow(new string[] {
                        "College Reunion Invitation",
                        "College Reunion Invitation UAT",
                        "Today",
                        "UAT Events",
                        "Send through mail only"});
#line 120
 testRunner.And("Invitation to the event \"Test Event\" includes a mail package", ((string)(null)), table21, "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Invitee"});
            table22.AddRow(new string[] {
                        "Mary Holland"});
#line 123
 testRunner.And("I add Invitees to invitation \"College Reunion Invitation\"", ((string)(null)), table22, "And ");
#line 126
 testRunner.And("I send the invitation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.When("I mark the invitee \"Mary Holland\" as declined", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Invitee",
                        "Invitation sent on"});
            table23.AddRow(new string[] {
                        "Mary Holland",
                        "Today"});
#line 128
 testRunner.Then("Invitees list displays where Declined is \"true\"", ((string)(null)), table23, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion