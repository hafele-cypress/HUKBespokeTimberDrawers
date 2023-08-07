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
    ///The MyHafele_Cancel_Quote recording.
    /// </summary>
    [TestModule("f13babb9-e288-4101-8f2f-c7ef985ad74d", ModuleType.Recording, 1)]
    public partial class MyHafele_Cancel_Quote : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static MyHafele_Cancel_Quote instance = new MyHafele_Cancel_Quote();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MyHafele_Cancel_Quote()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MyHafele_Cancel_Quote Instance
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

            try {
                Report.Log(ReportLevel.Info, "Invoke action", "(Optional Action)\r\nInvoking EnsureVisible() on item 'MyHafelePortal.SaveProductAndExit'.", repo.MyHafelePortal.SaveProductAndExitInfo, new RecordItemIndex(0));
                repo.MyHafelePortal.SaveProductAndExit.EnsureVisible();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'MyHafelePortal.SaveProductAndExit' at Center.", repo.MyHafelePortal.SaveProductAndExitInfo, new RecordItemIndex(1));
                repo.MyHafelePortal.SaveProductAndExit.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.CancelQuote' at Center.", repo.MyHafelePortal.CancelQuoteInfo, new RecordItemIndex(2));
            repo.MyHafelePortal.CancelQuote.Click();
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.AreYouSure_DialogueBox, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.AreYouSure_DialogueBox' at Center.", repo.MyHafelePortal.AreYouSure_DialogueBoxInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.AreYouSure_DialogueBox.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'MyHafelePortal'.", repo.MyHafelePortal.SelfInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
