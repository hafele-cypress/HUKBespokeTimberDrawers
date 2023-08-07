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
    ///The BTD3_Dimensions_Internal_Drawer_Yes recording.
    /// </summary>
    [TestModule("4f52501e-21ca-4953-9d65-5f11910b6e54", ModuleType.Recording, 1)]
    public partial class BTD3_Dimensions_Internal_Drawer_Yes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD3_Dimensions_Internal_Drawer_Yes instance = new BTD3_Dimensions_Internal_Drawer_Yes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD3_Dimensions_Internal_Drawer_Yes()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD3_Dimensions_Internal_Drawer_Yes Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.Dimensions_InternalCabinetDrawer_Yes'.", repo.MyHafelePortal.Dimensions_InternalCabinetDrawer_YesInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.Dimensions_InternalCabinetDrawer_Yes.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Dimensions_InternalCabinetDrawer_Yes' at Center.", repo.MyHafelePortal.Dimensions_InternalCabinetDrawer_YesInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.Dimensions_InternalCabinetDrawer_Yes.Click();
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=135,Height=44}) on item 'MyHafelePortal.Dimensions_InternalCabinetDrawer_Yes'.", repo.MyHafelePortal.Dimensions_InternalCabinetDrawer_YesInfo, new RecordItemIndex(2));
                Validate.ContainsImage(repo.MyHafelePortal.Dimensions_InternalCabinetDrawer_YesInfo, Dimensions_InternalCabinetDrawer_Yes_Screenshot1, Dimensions_InternalCabinetDrawer_Yes_Screenshot1_Options, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage Dimensions_InternalCabinetDrawer_Yes_Screenshot1
        { get { return repo.MyHafelePortal.Dimensions_InternalCabinetDrawer_YesInfo.GetScreenshot1(new Rectangle(0, 0, 135, 44)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions Dimensions_InternalCabinetDrawer_Yes_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}