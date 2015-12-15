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
    public partial class ForgotPasswordFeature : Xunit.IUseFixture<ForgotPasswordFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Forgot Password.feature"
#line hidden
        
        public ForgotPasswordFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Forgot Password", "\nIn order to be able to login \nAs a site visitor\nI want to be able to restore pas" +
                    "sword", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void SetFixture(ForgotPasswordFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC1_Open Password Resert page")]
        public virtual void Accounts_ForgotPassword_UC1_OpenPasswordResertPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC1_Open Password Resert page", new string[] {
                        "NeedImplementation"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("Habitat website is opened on Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("Actor clicks Forgot your password? link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Password reset title presents on Forgot Password page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And("Page URL ends on /ForgotPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Text on page"});
            table1.AddRow(new string[] {
                        "The new password will be sent to your e-mail."});
#line 13
 testRunner.And("following text is present on the page", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC2_Check required fields")]
        public virtual void Accounts_ForgotPassword_UC2_CheckRequiredFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC2_Check required fields", new string[] {
                        "NeedImplementation"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("Habitat website is opened on Forgot Password Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When("Actor clicks Reset Password button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Required field error message"});
            table2.AddRow(new string[] {
                        "E-mail is required"});
#line 22
 testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table2, "Then ");
#line 25
 testRunner.And("Page URL ends on /ForgotPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC3_Reset password for registered user")]
        public virtual void Accounts_ForgotPassword_UC3_ResetPasswordForRegisteredUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC3_Reset password for registered user", new string[] {
                        "NeedImplementation"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table3.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 30
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table3, "Given ");
#line 33
 testRunner.And("Habitat website is opened on Forgot Password Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail"});
            table4.AddRow(new string[] {
                        "kov@sitecore.net"});
#line 34
 testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table4, "When ");
#line 37
 testRunner.And("Actor clicks Reset Password button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Info message on Forgot Password page"});
            table5.AddRow(new string[] {
                        "Your password has been reset."});
#line 38
 testRunner.Then("Systen shows following message", ((string)(null)), table5, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Button name"});
            table6.AddRow(new string[] {
                        "Reset Password"});
#line 41
 testRunner.And("Then Following buttons is no longer present on Forgot Password page", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field name"});
            table7.AddRow(new string[] {
                        "E-mail"});
#line 44
 testRunner.Then("Following fields is no longer present on Forgot Password page", ((string)(null)), table7, "Then ");
#line 47
 testRunner.And("User receives an e-mail with new password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC4_Invalid e-mail")]
        public virtual void Accounts_ForgotPassword_UC4_InvalidE_Mail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC4_Invalid e-mail", new string[] {
                        "NeedImplementation"});
#line 51
this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given("Habitat website is opened on Forgot Password Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail"});
            table8.AddRow(new string[] {
                        "kov$sitecore.net"});
#line 53
 testRunner.When("Actor enters following text to E-mail field", ((string)(null)), table8, "When ");
#line 56
 testRunner.And("Actor clicks Reset Password button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail field error message"});
            table9.AddRow(new string[] {
                        "Invalid email address"});
#line 57
 testRunner.Then("System shows following error message for the E-mail field", ((string)(null)), table9, "Then ");
#line 60
 testRunner.And("Page URL ends on /ForgotPassword", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Forgot Password")]
        [Xunit.TraitAttribute("Description", "Accounts_Forgot Password_UC5_Try to reset password for unknown user")]
        public virtual void Accounts_ForgotPassword_UC5_TryToResetPasswordForUnknownUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Forgot Password_UC5_Try to reset password for unknown user", new string[] {
                        "NeedImplementation"});
#line 64
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table10.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 65
 testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table10, "Given ");
#line 68
 testRunner.And("Habitat website is opened on Forgot Password Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail"});
            table11.AddRow(new string[] {
                        "kov1@sitecore.net"});
#line 69
 testRunner.When("Actor enters following data into E-mail field", ((string)(null)), table11, "When ");
#line 72
 testRunner.And("Actor clicks Reset Password button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail field error message"});
            table12.AddRow(new string[] {
                        "User with specified email does not exist"});
#line 73
 testRunner.Then("Systen shows following message", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ForgotPasswordFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ForgotPasswordFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
