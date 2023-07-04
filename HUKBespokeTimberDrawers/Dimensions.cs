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
    ///The Dimensions recording.
    /// </summary>
    [TestModule("2f73323e-cd96-46d5-b2d2-d41279ab4fa2", ModuleType.Recording, 1)]
    public partial class Dimensions : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static Dimensions instance = new Dimensions();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dimensions()
        {
            ExWidth_mm = "";
            ExDepth_mm = "";
            ExHeight_mm = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dimensions Instance
        {
            get { return instance; }
        }

#region Variables

        string _ExWidth_mm;

        /// <summary>
        /// Gets or sets the value of variable ExWidth_mm.
        /// </summary>
        [TestVariable("13c88922-273c-4f0c-a2eb-1ebc52028f37")]
        public string ExWidth_mm
        {
            get { return _ExWidth_mm; }
            set { _ExWidth_mm = value; }
        }

        string _ExDepth_mm;

        /// <summary>
        /// Gets or sets the value of variable ExDepth_mm.
        /// </summary>
        [TestVariable("48d1a986-3459-4eb1-9a03-9c2f3f347603")]
        public string ExDepth_mm
        {
            get { return _ExDepth_mm; }
            set { _ExDepth_mm = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ExHeight_mm.
        /// </summary>
        [TestVariable("033ca110-3a3c-4942-993f-c0acaf982af0")]
        public string ExHeight_mm
        {
            get { return repo.ExHeight_mm; }
            set { repo.ExHeight_mm = value; }
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
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ExWidth_mm' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_TextInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Width_Text.PressKeys(ExWidth_mm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text' at 27;22.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_TextInfo, new RecordItemIndex(2));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text.Click("27;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ExDepth_mm' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_TextInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Depth_Text.PressKeys(ExDepth_mm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text' at 21;21.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_TextInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text.Click("21;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ExHeight_mm' with focus on 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text'.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_TextInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.Height_Text.PressKeys(ExHeight_mm);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
