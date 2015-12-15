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
namespace Habitat.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class LoginFeature : Xunit.IUseFixture<LoginFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        public LoginFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Login", "\r\nIn order to access secure pages\r\nAs a website visitor\r\nI want to be able to log" +
                    " in", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(LoginFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC1_Open Login form")]
        public virtual void Accounts_LoginForm_UC1_OpenLoginForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC1_Open Login form", new string[] {
                        "NeedImplementation"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("Login title presents on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table1.AddRow(new string[] {
                        "Email"});
            table1.AddRow(new string[] {
                        "Password"});
#line 13
 testRunner.And("Following fields present on Login form", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login Form Buttons"});
            table2.AddRow(new string[] {
                        "Cancel"});
            table2.AddRow(new string[] {
                        "Login"});
#line 17
 testRunner.And("Following buttons present on Login Form", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Aссounts_Login form_UC2_Check required fields")]
        public virtual void Aссounts_LoginForm_UC2_CheckRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aссounts_Login form_UC2_Check required fields", new string[] {
                        "NeedImplementation"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Required fields error message"});
            table3.AddRow(new string[] {
                        "E-mail is required"});
            table3.AddRow(new string[] {
                        "Password is required"});
#line 28
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC3_Enter correct Username and Password")]
        public virtual void Accounts_LoginForm_UC3_EnterCorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC3_Enter correct Username and Password", new string[] {
                        "NeedImplementation"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table4.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k",
                        "k"});
#line 36
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table4, "Given ");
#line 39
 testRunner.And("User was logged out from the Habitat", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table5.AddRow(new string[] {
                        "kov10@sitecore.net",
                        "k"});
#line 42
 testRunner.When("Actor enteres following data into Login form fields", ((string)(null)), table5, "When ");
#line 45
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table6.AddRow(new string[] {
                        "Login"});
            table6.AddRow(new string[] {
                        "Register"});
#line 46
 testRunner.Then("Following buttons is no longer present under User drop-drop down menu", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table7.AddRow(new string[] {
                        "Logout"});
#line 50
 testRunner.And("Following buttons present under User drop-drop down menu", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC4_Enter correct username and incorrect password")]
        public virtual void Accounts_LoginForm_UC4_EnterCorrectUsernameAndIncorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC4_Enter correct username and incorrect password", new string[] {
                        "NeedImplementation"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table8.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 57
 testRunner.Given("User is registered in Habitat", ((string)(null)), table8, "Given ");
#line 60
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table9.AddRow(new string[] {
                        "kov@sitecore.net",
                        "m"});
#line 63
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table9, "When ");
#line 66
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table10.AddRow(new string[] {
                        "Username or password is not valid."});
#line 67
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC5_Enter incorrect username and correct password")]
        public virtual void Accounts_LoginForm_UC5_EnterIncorrectUsernameAndCorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC5_Enter incorrect username and correct password", new string[] {
                        "NeedImplementation"});
#line 73
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table11.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 74
    testRunner.Given("User is registered in Habitat", ((string)(null)), table11, "Given ");
#line 77
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table12.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k"});
#line 80
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table12, "When ");
#line 83
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table13.AddRow(new string[] {
                        "Username or password is not valid"});
#line 84
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC6_Enter incorrect username and password")]
        public virtual void Accounts_LoginForm_UC6_EnterIncorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC6_Enter incorrect username and password", new string[] {
                        "NeedImplementation"});
#line 90
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table14.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 91
    testRunner.Given("User is registered in Habitat", ((string)(null)), table14, "Given ");
#line 94
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table15.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k1"});
#line 97
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table15, "When ");
#line 100
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table16.AddRow(new string[] {
                        "Username or password is not valid"});
#line 101
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table16, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC7_Login with username and password of recently removed user" +
            "")]
        public virtual void Accounts_LoginForm_UC7_LoginWithUsernameAndPasswordOfRecentlyRemovedUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC7_Login with username and password of recently removed user" +
                    "", new string[] {
                        "NeedImplementation"});
#line 107
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table17.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 108
    testRunner.Given("User is recently deleted from Habitat", ((string)(null)), table17, "Given ");
#line 111
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table18.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 113
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table18, "When ");
#line 116
 testRunner.And("User clicks Login button on Login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table19.AddRow(new string[] {
                        "Username or password is not valid"});
#line 117
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table19, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login form_UC8_Click Cancel button on login form")]
        public virtual void Accounts_LoginForm_UC8_ClickCancelButtonOnLoginForm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login form_UC8_Click Cancel button on login form", new string[] {
                        "NeedImplementation"});
#line 122
this.ScenarioSetup(scenarioInfo);
#line 123
    testRunner.Given("Login form is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table20.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 124
 testRunner.When("Actor enters following data into fields", ((string)(null)), table20, "When ");
#line 127
 testRunner.And("Actor clicks Cancel button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("User clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table21.AddRow(new string[] {
                        "",
                        ""});
#line 130
 testRunner.Then("Actor presented with following data in fields", ((string)(null)), table21, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC9_Open Login page")]
        public virtual void Accounts_LoginPage_UC9_OpenLoginPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC9_Open Login page", new string[] {
                        "NeedImplementation"});
#line 136
this.ScenarioSetup(scenarioInfo);
#line 137
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 138
 testRunner.When("Actor moves to any secure page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.Then("Login title presents on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.And("Page URL ends on /Login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table22.AddRow(new string[] {
                        "Email"});
            table22.AddRow(new string[] {
                        "Password"});
#line 141
 testRunner.And("Following fields present on Login page", ((string)(null)), table22, "And ");
#line 145
 testRunner.And("Login button presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.And("Forgot your password? link presents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Aссounts_Login page_UC10_Check required fields")]
        public virtual void Aссounts_LoginPage_UC10_CheckRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aссounts_Login page_UC10_Check required fields", new string[] {
                        "NeedImplementation"});
#line 150
this.ScenarioSetup(scenarioInfo);
#line 151
 testRunner.Given("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table23.AddRow(new string[] {
                        "",
                        ""});
#line 152
 testRunner.When("Actor enters data in to the following login fields", ((string)(null)), table23, "When ");
#line 155
 testRunner.And("User clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Required fields error message"});
            table24.AddRow(new string[] {
                        "E-mail is required"});
            table24.AddRow(new string[] {
                        "Password is required"});
#line 156
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table24, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC11_Enter correct Username and Password")]
        public virtual void Accounts_LoginPage_UC11_EnterCorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC11_Enter correct Username and Password", new string[] {
                        "NeedImplementation"});
#line 163
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table25.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 164
 testRunner.Given("User is registered in Habitat", ((string)(null)), table25, "Given ");
#line 167
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table26.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 168
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table26, "When ");
#line 171
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.Then("Habitat website openes on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table27.AddRow(new string[] {
                        "Logout"});
            table27.AddRow(new string[] {
                        "Edit details"});
#line 173
 testRunner.And("Following buttons present under User drop-drop down menu", ((string)(null)), table27, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC12_Enter correct username and incorrect password")]
        public virtual void Accounts_LoginPage_UC12_EnterCorrectUsernameAndIncorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC12_Enter correct username and incorrect password", new string[] {
                        "NeedImplementation"});
#line 180
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table28.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 181
 testRunner.Given("User is registered in Habitat", ((string)(null)), table28, "Given ");
#line 184
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table29.AddRow(new string[] {
                        "kov@sitecore.net",
                        "m"});
#line 185
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table29, "When ");
#line 188
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login page error message"});
            table30.AddRow(new string[] {
                        "Username or password is not valid."});
#line 189
 testRunner.Then("System shows following message for the Login form", ((string)(null)), table30, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC13_Enter incorrect username and correct password")]
        public virtual void Accounts_LoginPage_UC13_EnterIncorrectUsernameAndCorrectPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC13_Enter incorrect username and correct password", new string[] {
                        "NeedImplementation"});
#line 195
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table31.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 196
    testRunner.Given("User is registered in Habitat", ((string)(null)), table31, "Given ");
#line 199
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table32.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k"});
#line 200
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table32, "When ");
#line 203
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table33.AddRow(new string[] {
                        "Username or password is not valid."});
#line 204
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table33, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC14_Enter incorrect username and password")]
        public virtual void Accounts_LoginPage_UC14_EnterIncorrectUsernameAndPassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC14_Enter incorrect username and password", new string[] {
                        "NeedImplementation"});
#line 210
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table34.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 211
    testRunner.Given("User is registered in Habitat", ((string)(null)), table34, "Given ");
#line 214
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table35.AddRow(new string[] {
                        "kov1@sitecore.net",
                        "k1"});
#line 215
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table35, "When ");
#line 218
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table36.AddRow(new string[] {
                        "Username or password is not valid."});
#line 219
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table36, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Login")]
        [Xunit.TraitAttribute("Description", "Accounts_Login page_UC15_Login with username and password of recently removed use" +
            "r")]
        public virtual void Accounts_LoginPage_UC15_LoginWithUsernameAndPasswordOfRecentlyRemovedUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Login page_UC15_Login with username and password of recently removed use" +
                    "r", new string[] {
                        "NeedImplementation"});
#line 225
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table37.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 226
    testRunner.Given("User is recently deleted from Habitat", ((string)(null)), table37, "Given ");
#line 229
 testRunner.And("Habitat website is opened on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password"});
            table38.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 230
 testRunner.When("Actor enteres following data into fields", ((string)(null)), table38, "When ");
#line 233
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "Login form error message"});
            table39.AddRow(new string[] {
                        "Username or password is not valid."});
#line 234
 testRunner.Then("System shows following error message for the Login form", ((string)(null)), table39, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LoginFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LoginFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
