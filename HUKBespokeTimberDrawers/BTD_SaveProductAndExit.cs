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
    ///The BTD_SaveProductAndExit recording.
    /// </summary>
    [TestModule("362a54d6-9529-4412-8f89-827170a584b7", ModuleType.Recording, 1)]
    public partial class BTD_SaveProductAndExit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD_SaveProductAndExit instance = new BTD_SaveProductAndExit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD_SaveProductAndExit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD_SaveProductAndExit Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.NeedToFinishThisLater_SaveProductAndExit' at Center.", repo.MyHafelePortal.NeedToFinishThisLater_SaveProductAndExitInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.NeedToFinishThisLater_SaveProductAndExit.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.RowItemDraft'.", repo.MyHafelePortal.RowItemDraftInfo, new RecordItemIndex(1));
                Validate.Exists(repo.MyHafelePortal.RowItemDraftInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.RowItemDraft, false, new RecordItemIndex(2));
            
            try {
                Report.Log(ReportLevel.Info, "Invoke action", "(Optional Action)\r\nInvoking WaitForDocumentLoaded() on item 'MyHafelePortal'.", repo.MyHafelePortal.SelfInfo, new RecordItemIndex(3));
                repo.MyHafelePortal.Self.WaitForDocumentLoaded();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}