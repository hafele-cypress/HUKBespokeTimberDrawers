﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace HUKBespokeTimberDrawers
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BTD_Gmail_Login recording.
    /// </summary>
    [TestModule("cf7cfbd9-5796-47e4-ae68-d504c0ed5355", ModuleType.Recording, 1)]
    public partial class BTD_Gmail_Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD_Gmail_Login instance = new BTD_Gmail_Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD_Gmail_Login()
        {
            Gmail_Address = "";
            Gmail_Password = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD_Gmail_Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _Gmail_Address;

        /// <summary>
        /// Gets or sets the value of variable Gmail_Address.
        /// </summary>
        [TestVariable("ac501000-d776-478b-90b5-ea14265c1ba9")]
        public string Gmail_Address
        {
            get { return _Gmail_Address; }
            set { _Gmail_Address = value; }
        }

        string _Gmail_Password;

        /// <summary>
        /// Gets or sets the value of variable Gmail_Password.
        /// </summary>
        [TestVariable("c93c3235-7087-4b28-890a-87c998959a86")]
        public string Gmail_Password
        {
            get { return _Gmail_Password; }
            set { _Gmail_Password = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailApplicationUnderTest.UseAnotherAccount' at Center.", repo.GmailApplicationUnderTest.UseAnotherAccountInfo, new RecordItemIndex(0));
            repo.GmailApplicationUnderTest.UseAnotherAccount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailApplicationUnderTest.Email_Address' at Center.", repo.GmailApplicationUnderTest.Email_AddressInfo, new RecordItemIndex(1));
            repo.GmailApplicationUnderTest.Email_Address.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Gmail_Address' with focus on 'GmailApplicationUnderTest.Email_Address'.", repo.GmailApplicationUnderTest.Email_AddressInfo, new RecordItemIndex(2));
            repo.GmailApplicationUnderTest.Email_Address.PressKeys(Gmail_Address, 20);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailApplicationUnderTest.Email_NextButton' at Center.", repo.GmailApplicationUnderTest.Email_NextButtonInfo, new RecordItemIndex(4));
            repo.GmailApplicationUnderTest.Email_NextButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'GmailApplicationUnderTest.Password'.", repo.GmailApplicationUnderTest.PasswordInfo, new RecordItemIndex(5));
            repo.GmailApplicationUnderTest.Password.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailApplicationUnderTest.Password' at Center.", repo.GmailApplicationUnderTest.PasswordInfo, new RecordItemIndex(6));
            repo.GmailApplicationUnderTest.Password.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Gmail_Password' with focus on 'GmailApplicationUnderTest.Password'.", repo.GmailApplicationUnderTest.PasswordInfo, new RecordItemIndex(7));
            repo.GmailApplicationUnderTest.Password.PressKeys(Gmail_Password, 20);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailApplicationUnderTest.Password_NextButton' at Center.", repo.GmailApplicationUnderTest.Password_NextButtonInfo, new RecordItemIndex(8));
            repo.GmailApplicationUnderTest.Password_NextButton.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'GmailInbox.Gmail_Inbox'", repo.GmailInbox.Gmail_InboxInfo, new ActionTimeout(5000), new RecordItemIndex(9));
            //repo.GmailInbox.Gmail_InboxInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'GmailInbox.Gmail_Inbox'.", repo.GmailInbox.Gmail_InboxInfo, new RecordItemIndex(10));
            repo.GmailInbox.Gmail_Inbox.EnsureVisible();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
