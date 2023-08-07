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
    ///The See_summary_of_the_quote_including_address_reference_etc__status_ordered recording.
    /// </summary>
    [TestModule("50e8b5c7-5803-47a1-8fac-a2e9336501b2", ModuleType.Recording, 1)]
    public partial class See_summary_of_the_quote_including_address_reference_etc__status_ordered : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static See_summary_of_the_quote_including_address_reference_etc__status_ordered instance = new See_summary_of_the_quote_including_address_reference_etc__status_ordered();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public See_summary_of_the_quote_including_address_reference_etc__status_ordered()
        {
            YourReference = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static See_summary_of_the_quote_including_address_reference_etc__status_ordered Instance
        {
            get { return instance; }
        }

#region Variables

        string _YourReference;

        /// <summary>
        /// Gets or sets the value of variable YourReference.
        /// </summary>
        [TestVariable("df7c1aec-662b-4e43-9ffe-b6d61ca66301")]
        public string YourReference
        {
            get { return _YourReference; }
            set { _YourReference = value; }
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

            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'MyHafelePortal'.", repo.MyHafelePortal.SelfInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.BespokeDrawers' at Center.", repo.MyHafelePortal.BespokeDrawersInfo, new RecordItemIndex(2));
            repo.MyHafelePortal.BespokeDrawers.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'MyHafelePortal.Quote_OrderSearch'.", repo.MyHafelePortal.Quote_OrderSearchInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.Quote_OrderSearch.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Quote_OrderSearch' at Center.", repo.MyHafelePortal.Quote_OrderSearchInfo, new RecordItemIndex(4));
            repo.MyHafelePortal.Quote_OrderSearch.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$YourReference' with focus on 'MyHafelePortal.Quote_OrderSearch'.", repo.MyHafelePortal.Quote_OrderSearchInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.Quote_OrderSearch.PressKeys(YourReference);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.Quotes_Overview, false, new RecordItemIndex(7));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.Quotes_Overview'.", repo.MyHafelePortal.Quotes_OverviewInfo, new RecordItemIndex(8));
                Validate.Exists(repo.MyHafelePortal.Quotes_OverviewInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.Ordered_Badge, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.Ordered_Badge' at Center.", repo.MyHafelePortal.Ordered_BadgeInfo, new RecordItemIndex(10));
            repo.MyHafelePortal.Ordered_Badge.Click();
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.DeliveryAddress_Overview, false, new RecordItemIndex(11));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.DeliveryAddress_Overview'.", repo.MyHafelePortal.DeliveryAddress_OverviewInfo, new RecordItemIndex(12));
                Validate.Exists(repo.MyHafelePortal.DeliveryAddress_OverviewInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.QuoteSummary, false, new RecordItemIndex(13));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.QuoteSummary'.", repo.MyHafelePortal.QuoteSummaryInfo, new RecordItemIndex(14));
                Validate.Exists(repo.MyHafelePortal.QuoteSummaryInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.MyHafelePortal.Quote_You_placed_this_order_on, false, new RecordItemIndex(15));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.Quote_You_placed_this_order_on'.", repo.MyHafelePortal.Quote_You_placed_this_order_onInfo, new RecordItemIndex(16));
                Validate.Exists(repo.MyHafelePortal.Quote_You_placed_this_order_onInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
