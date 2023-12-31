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
    ///The BTD_Gmail_Logout recording.
    /// </summary>
    [TestModule("d047b43a-706b-43ae-9c35-ffbb87411396", ModuleType.Recording, 1)]
    public partial class BTD_Gmail_Logout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD_Gmail_Logout instance = new BTD_Gmail_Logout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD_Gmail_Logout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD_Gmail_Logout Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'GmailInbox.GoogleAccount'.", repo.GmailInbox.GoogleAccountInfo, new RecordItemIndex(0));
            repo.GmailInbox.GoogleAccount.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailInbox.GoogleAccount' at Center.", repo.GmailInbox.GoogleAccountInfo, new RecordItemIndex(1));
            repo.GmailInbox.GoogleAccount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'GmailInbox.SignOut'.", repo.GmailInbox.SignOutInfo, new RecordItemIndex(2));
            repo.GmailInbox.SignOut.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GmailInbox.SignOut' at Center.", repo.GmailInbox.SignOutInfo, new RecordItemIndex(3));
            repo.GmailInbox.SignOut.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'GmailApplicationUnderTest'.", repo.GmailApplicationUnderTest.SelfInfo, new RecordItemIndex(5));
            Host.Current.CloseApplication(repo.GmailApplicationUnderTest.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
