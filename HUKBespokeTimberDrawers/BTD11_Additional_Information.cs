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
    ///The BTD11_Additional_Information recording.
    /// </summary>
    [TestModule("2aa6ef90-79c5-49b4-a0e7-194346b441a6", ModuleType.Recording, 1)]
    public partial class BTD11_Additional_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD11_Additional_Information instance = new BTD11_Additional_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD11_Additional_Information()
        {
            Additional_Information = "";
            Upload_Supporting_Files = "";
            Logo_Upload = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD11_Additional_Information Instance
        {
            get { return instance; }
        }

#region Variables

        string _Additional_Information;

        /// <summary>
        /// Gets or sets the value of variable Additional_Information.
        /// </summary>
        [TestVariable("6bef82bd-8aae-45f5-8e48-4b5e1d529e1f")]
        public string Additional_Information
        {
            get { return _Additional_Information; }
            set { _Additional_Information = value; }
        }

        string _Upload_Supporting_Files;

        /// <summary>
        /// Gets or sets the value of variable Upload_Supporting_Files.
        /// </summary>
        [TestVariable("38890c33-02d0-48b5-b7df-f53e3fa8e03c")]
        public string Upload_Supporting_Files
        {
            get { return _Upload_Supporting_Files; }
            set { _Upload_Supporting_Files = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Logo_Upload.
        /// </summary>
        [TestVariable("8ca80ec2-bede-471c-96b1-54da1603a0b7")]
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductRe'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductReInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductRe.EnsureVisible();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductRe'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductReInfo, new RecordItemIndex(1));
                Validate.Exists(repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductReInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductRe' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductReInfo, new RecordItemIndex(2));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductRe.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Additional_Information' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductRe'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductReInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.PleaseSpecifyAnyAdditionalProductRe.PressKeys(Additional_Information);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFiles'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFilesInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFiles.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFiles' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFilesInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFiles.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Upload_Supporting_Files' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFiles'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFilesInfo, new RecordItemIndex(6));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.UploadSupportingFiles.PressKeys(Upload_Supporting_Files);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AdditionalInformation_FileOpenButton' at Center.", repo.AdditionalInformation_FileOpenButtonInfo, new RecordItemIndex(7));
            repo.AdditionalInformation_FileOpenButton.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Validate_LogoUpload'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Validate_LogoUploadInfo, new RecordItemIndex(8));
                Validate.Exists(repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Validate_LogoUploadInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Validate_LogoUpload, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.SupportingInformation_Remove_Logo' at Center.", repo.MyHafelePortal.SupportingInformation_Remove_LogoInfo, new RecordItemIndex(10));
            repo.MyHafelePortal.SupportingInformation_Remove_Logo.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
