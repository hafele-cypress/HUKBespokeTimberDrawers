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
    ///The BTD7_Customisations_SlideOut recording.
    /// </summary>
    [TestModule("b6eb7f64-a05f-4ec4-bd3d-f736731460d2", ModuleType.Recording, 1)]
    public partial class BTD7_Customisations_SlideOut : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD7_Customisations_SlideOut instance = new BTD7_Customisations_SlideOut();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD7_Customisations_SlideOut()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD7_Customisations_SlideOut Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable SlideOutBase.
        /// </summary>
        [TestVariable("72e158f5-e396-4eb7-99fa-834cbe0ceaf8")]
        public string SlideOutBase
        {
            get { return repo.SlideOutBase; }
            set { repo.SlideOutBase = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Customisations_DrawerBase_SlideOutBase' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Customisations_DrawerBase_SlideOutBaseInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Customisations_DrawerBase_SlideOutBase.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}