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
    ///The BTD3_Dimensions recording.
    /// </summary>
    [TestModule("2a29ef17-ba2f-4dce-821b-5fd17102bf2f", ModuleType.Recording, 1)]
    public partial class BTD3_Dimensions : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD3_Dimensions instance = new BTD3_Dimensions();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD3_Dimensions()
        {
            ExWidth_mm = "";
            ExDepth_mm = "";
            ExHeight_mm = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD3_Dimensions Instance
        {
            get { return instance; }
        }

#region Variables

        string _ExWidth_mm;

        /// <summary>
        /// Gets or sets the value of variable ExWidth_mm.
        /// </summary>
        [TestVariable("c4b9f133-8cf8-4d1f-a97e-c54b46e04a2b")]
        public string ExWidth_mm
        {
            get { return _ExWidth_mm; }
            set { _ExWidth_mm = value; }
        }

        string _ExDepth_mm;

        /// <summary>
        /// Gets or sets the value of variable ExDepth_mm.
        /// </summary>
        [TestVariable("cd5dec60-919e-43fb-b96f-640daccdef6e")]
        public string ExDepth_mm
        {
            get { return _ExDepth_mm; }
            set { _ExDepth_mm = value; }
        }

        string _ExHeight_mm;

        /// <summary>
        /// Gets or sets the value of variable ExHeight_mm.
        /// </summary>
        [TestVariable("0c982358-cbb0-41dd-9e15-5fab2c43eebc")]
        public string ExHeight_mm
        {
            get { return _ExHeight_mm; }
            set { _ExHeight_mm = value; }
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

            // Dimensions
            Report.Log(ReportLevel.Info, "Section", "Dimensions", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_TextInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_TextInfo, new RecordItemIndex(2));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ExWidth_mm' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_TextInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text.PressKeys(ExWidth_mm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text' at 27;22.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_TextInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text.Click("27;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ExDepth_mm' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_TextInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text.PressKeys(ExDepth_mm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text' at 21;21.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_TextInfo, new RecordItemIndex(6));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text.Click("21;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ExHeight_mm' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_TextInfo, new RecordItemIndex(7));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text.PressKeys(ExHeight_mm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
