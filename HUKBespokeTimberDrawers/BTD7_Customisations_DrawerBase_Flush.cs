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
    ///The BTD7_Customisations_DrawerBase_Flush recording.
    /// </summary>
    [TestModule("9939faae-707f-4598-9943-43f6cae78222", ModuleType.Recording, 1)]
    public partial class BTD7_Customisations_DrawerBase_Flush : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD7_Customisations_DrawerBase_Flush instance = new BTD7_Customisations_DrawerBase_Flush();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD7_Customisations_DrawerBase_Flush()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD7_Customisations_DrawerBase_Flush Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.DrawerBase_MoreInfo' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.DrawerBase_MoreInfoInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.DrawerBase_MoreInfo.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.MoreInfo_img'.", repo.MyHafelePortal.MoreInfo_imgInfo, new RecordItemIndex(1));
                Validate.Exists(repo.MyHafelePortal.MoreInfo_imgInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.MoreInfo_img, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.Close'.", repo.MyHafelePortal.CloseInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.Close.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Close' at Center.", repo.MyHafelePortal.CloseInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.Close.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Customisations_DrawerBase_FlushBase' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Customisations_DrawerBase_FlushBaseInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Customisations_DrawerBase_FlushBase.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
