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
    ///The BTD1_BespokeDrawers recording.
    /// </summary>
    [TestModule("6a568138-75c7-4c72-b319-33d44b940318", ModuleType.Recording, 1)]
    public partial class BTD1_BespokeDrawers : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD1_BespokeDrawers instance = new BTD1_BespokeDrawers();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD1_BespokeDrawers()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD1_BespokeDrawers Instance
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'MyHafelePortal'.", repo.MyHafelePortal.SelfInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.BespokeDrawers' at Center.", repo.MyHafelePortal.BespokeDrawersInfo, new RecordItemIndex(2));
            repo.MyHafelePortal.BespokeDrawers.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
