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
    ///The BTD8_Specification_FrontAndBack recording.
    /// </summary>
    [TestModule("4bb684e5-d8d3-458b-97cc-0efac3a49daf", ModuleType.Recording, 1)]
    public partial class BTD8_Specification_FrontAndBack : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD8_Specification_FrontAndBack instance = new BTD8_Specification_FrontAndBack();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD8_Specification_FrontAndBack()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD8_Specification_FrontAndBack Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBack'", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBackInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBackInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBack'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBackInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBack.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(2));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBack' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBackInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBack.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBack'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBackInfo, new RecordItemIndex(4));
            Validate.Exists(repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Specification_FrontAndBackInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_SpecificationOptionValidation'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_SpecificationOptionValidationInfo, new RecordItemIndex(5));
            Validate.Exists(repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_SpecificationOptionValidationInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_SpecificationOptionValidation, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
