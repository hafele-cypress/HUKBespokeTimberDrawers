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
    ///The BTD8_Notching_Hettich recording.
    /// </summary>
    [TestModule("eb375849-9332-4060-913b-dc0bf2e1e3d2", ModuleType.Recording, 1)]
    public partial class BTD8_Notching_Hettich : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD8_Notching_Hettich instance = new BTD8_Notching_Hettich();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD8_Notching_Hettich()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD8_Notching_Hettich Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_MoreInfo' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_MoreInfoInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_MoreInfo.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyHafelePortal.MaterialInformation'.", repo.MyHafelePortal.MaterialInformationInfo, new RecordItemIndex(1));
            Validate.Exists(repo.MyHafelePortal.MaterialInformationInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.MaterialInformation, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Close' at Center.", repo.MyHafelePortal.CloseInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.Close.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_Hettich'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_HettichInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_Hettich.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_Hettich' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_HettichInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_Hettich.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=135,Height=44}) on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_Hettich'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_HettichInfo, new RecordItemIndex(6));
            Validate.ContainsImage(repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_HettichInfo, Notching_Hettich_Screenshot2, Notching_Hettich_Screenshot2_Options);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_SpecificationOptionValidation'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_SpecificationOptionValidationInfo, new RecordItemIndex(7));
            Validate.Exists(repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_SpecificationOptionValidationInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Notching_Hettich_Screenshot2
        { get { return repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Notching_HettichInfo.GetScreenshot2(new Rectangle(0, 0, 135, 44)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Notching_Hettich_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
