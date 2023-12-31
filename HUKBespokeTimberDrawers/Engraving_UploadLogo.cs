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
    ///The Engraving_UploadLogo recording.
    /// </summary>
    [TestModule("aca0f41d-3b46-4f42-acdd-c61f0cdf93a0", ModuleType.Recording, 1)]
    public partial class Engraving_UploadLogo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static Engraving_UploadLogo instance = new Engraving_UploadLogo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Engraving_UploadLogo()
        {
            Logo_Upload = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Engraving_UploadLogo Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Logo_Upload.
        /// </summary>
        [TestVariable("704aa281-e937-4e20-9f1e-74d5f0c29a5b")]
        public string Logo_Upload
        {
            get { return repo.Logo_Upload; }
            set { repo.Logo_Upload = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Engraving_UploadLogo'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Engraving_UploadLogoInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Engraving_UploadLogo.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Engraving_UploadLogo' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Engraving_UploadLogoInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Engraving_UploadLogo.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Logo_Upload' with focus on 'FileUploadWindow'.", repo.FileUploadWindowInfo, new RecordItemIndex(2));
            repo.FileUploadWindow.PressKeys(Logo_Upload);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FileUpload_OpenButton' at Center.", repo.FileUpload_OpenButtonInfo, new RecordItemIndex(4));
            repo.FileUpload_OpenButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
