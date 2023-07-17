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
    ///The BTD4_Material_Ply recording.
    /// </summary>
    [TestModule("82a3c235-1197-42be-b43a-1ac73be29f9f", ModuleType.Recording, 1)]
    public partial class BTD4_Material_Ply : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD4_Material_Ply instance = new BTD4_Material_Ply();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD4_Material_Ply()
        {
            Thickness = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD4_Material_Ply Instance
        {
            get { return instance; }
        }

#region Variables

        string _Thickness;

        /// <summary>
        /// Gets or sets the value of variable Thickness.
        /// </summary>
        [TestVariable("8ad0f429-e886-4ef4-85d0-3b2c36e27678")]
        public string Thickness
        {
            get { return _Thickness; }
            set { _Thickness = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.Material_Ply'.", repo.MyHafelePortal.Material_PlyInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.Material_Ply.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.MoreInfo_Material' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.MoreInfo_MaterialInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.MoreInfo_Material.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.MaterialInformation'.", repo.MyHafelePortal.MaterialInformationInfo, new RecordItemIndex(2));
                Validate.Exists(repo.MyHafelePortal.MaterialInformationInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.MaterialInformation, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.Close'.", repo.MyHafelePortal.CloseInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.Close.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Close' at Center.", repo.MyHafelePortal.CloseInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.Close.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Material_Ply' at Center.", repo.MyHafelePortal.Material_PlyInfo, new RecordItemIndex(6));
            repo.MyHafelePortal.Material_Ply.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'MyHafelePortal.SelectThickness' at Center.", repo.MyHafelePortal.SelectThicknessInfo, new RecordItemIndex(7));
                repo.MyHafelePortal.SelectThickness.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$Thickness' with focus on 'MyHafelePortal.SelectThickness'.", repo.MyHafelePortal.SelectThicknessInfo, new RecordItemIndex(8));
                repo.MyHafelePortal.SelectThickness.PressKeys(Thickness);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.QuoteSummery_Overview'.", repo.MyHafelePortal.QuoteSummery_OverviewInfo, new RecordItemIndex(9));
                Validate.Exists(repo.MyHafelePortal.QuoteSummery_OverviewInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.QuoteSummery_Overview, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
