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
    ///The BTD2_SelectProduct_SpiceRackInsert recording.
    /// </summary>
    [TestModule("f7e187af-ee38-49a8-8bb5-ae6258be2d9e", ModuleType.Recording, 1)]
    public partial class BTD2_SelectProduct_SpiceRackInsert : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD2_SelectProduct_SpiceRackInsert instance = new BTD2_SelectProduct_SpiceRackInsert();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD2_SelectProduct_SpiceRackInsert()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD2_SelectProduct_SpiceRackInsert Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.SpiceRackInsert' at Center.", repo.MyHafelePortal.SpiceRackInsertInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.SpiceRackInsert.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Continue' at Center.", repo.MyHafelePortal.ContinueInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.Continue.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.MoreInfo' at Center.", repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.MoreInfoInfo, new RecordItemIndex(2));
            repo.MyHafelePortal.HttpsQmyHafeleCoUkQuotesBespoke.MoreInfo.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://qmy.hafele.co.uk/assets/img/quotes/btd/moreinfo/spice-rack-insert_dimensions.png') on item 'MyHafelePortal.Dimensions'.", repo.MyHafelePortal.DimensionsInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.MyHafelePortal.DimensionsInfo, "Src", "https://qmy.hafele.co.uk/assets/img/quotes/btd/moreinfo/spice-rack-insert_dimensions.png");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.Dimensions, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Close' at Center.", repo.MyHafelePortal.CloseInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.Close.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
