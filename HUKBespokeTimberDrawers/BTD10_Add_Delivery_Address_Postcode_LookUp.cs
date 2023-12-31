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
    ///The BTD10_Add_Delivery_Address_Postcode_LookUp recording.
    /// </summary>
    [TestModule("da47bbcd-f9df-47ae-b40a-f4eed9931e7f", ModuleType.Recording, 1)]
    public partial class BTD10_Add_Delivery_Address_Postcode_LookUp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HUKBespokeTimberDrawersRepository repository.
        /// </summary>
        public static HUKBespokeTimberDrawersRepository repo = HUKBespokeTimberDrawersRepository.Instance;

        static BTD10_Add_Delivery_Address_Postcode_LookUp instance = new BTD10_Add_Delivery_Address_Postcode_LookUp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BTD10_Add_Delivery_Address_Postcode_LookUp()
        {
            ContactName = "";
            TelephoneNumber = "";
            AddressLine1 = "";
            Postcode = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BTD10_Add_Delivery_Address_Postcode_LookUp Instance
        {
            get { return instance; }
        }

#region Variables

        string _ContactName;

        /// <summary>
        /// Gets or sets the value of variable ContactName.
        /// </summary>
        [TestVariable("1978a2b1-10ae-4ff8-91e8-ada15caea7e0")]
        public string ContactName
        {
            get { return _ContactName; }
            set { _ContactName = value; }
        }

        string _TelephoneNumber;

        /// <summary>
        /// Gets or sets the value of variable TelephoneNumber.
        /// </summary>
        [TestVariable("0cfd3004-2140-4dde-8202-7add7cc42e44")]
        public string TelephoneNumber
        {
            get { return _TelephoneNumber; }
            set { _TelephoneNumber = value; }
        }

        string _AddressLine1;

        /// <summary>
        /// Gets or sets the value of variable AddressLine1.
        /// </summary>
        [TestVariable("36614de3-09a1-4bdd-95f9-adce9ee3a239")]
        public string AddressLine1
        {
            get { return _AddressLine1; }
            set { _AddressLine1 = value; }
        }

        string _Postcode;

        /// <summary>
        /// Gets or sets the value of variable Postcode.
        /// </summary>
        [TestVariable("4e49f22a-cef5-4954-8a68-d42e1a35891b")]
        public string Postcode
        {
            get { return _Postcode; }
            set { _Postcode = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.AddDeliveryAddress' at Center.", repo.MyHafelePortal.AddDeliveryAddressInfo, new RecordItemIndex(0));
            repo.MyHafelePortal.AddDeliveryAddress.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ContactName' with focus on 'MyHafelePortal.DeliveryContact_ContactName'.", repo.MyHafelePortal.DeliveryContact_ContactNameInfo, new RecordItemIndex(1));
            repo.MyHafelePortal.DeliveryContact_ContactName.PressKeys(ContactName);
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.DeliveryContact_ContactName'.", repo.MyHafelePortal.DeliveryContact_ContactNameInfo, new RecordItemIndex(2));
                Validate.Exists(repo.MyHafelePortal.DeliveryContact_ContactNameInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TelephoneNumber' with focus on 'MyHafelePortal.DeliveryContact_TelephoneNumber'.", repo.MyHafelePortal.DeliveryContact_TelephoneNumberInfo, new RecordItemIndex(3));
            repo.MyHafelePortal.DeliveryContact_TelephoneNumber.PressKeys(TelephoneNumber);
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'MyHafelePortal.DeliveryContact_TelephoneNumber'.", repo.MyHafelePortal.DeliveryContact_TelephoneNumberInfo, new RecordItemIndex(4));
                Validate.Exists(repo.MyHafelePortal.DeliveryContact_TelephoneNumberInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.DeliveryAddress_BuildingNumberOrName' at Center.", repo.MyHafelePortal.DeliveryAddress_BuildingNumberOrNameInfo, new RecordItemIndex(5));
            repo.MyHafelePortal.DeliveryAddress_BuildingNumberOrName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AddressLine1' with focus on 'MyHafelePortal.DeliveryAddress_BuildingNumberOrName'.", repo.MyHafelePortal.DeliveryAddress_BuildingNumberOrNameInfo, new RecordItemIndex(6));
            repo.MyHafelePortal.DeliveryAddress_BuildingNumberOrName.PressKeys(AddressLine1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.DeliveryAddress_SearchByPostcode' at Center.", repo.MyHafelePortal.DeliveryAddress_SearchByPostcodeInfo, new RecordItemIndex(7));
            repo.MyHafelePortal.DeliveryAddress_SearchByPostcode.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Postcode' with focus on 'MyHafelePortal.DeliveryAddress_SearchByPostcode'.", repo.MyHafelePortal.DeliveryAddress_SearchByPostcodeInfo, new RecordItemIndex(8));
            repo.MyHafelePortal.DeliveryAddress_SearchByPostcode.PressKeys(Postcode);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.DeliveryAddress_FindAddressButton' at Center.", repo.MyHafelePortal.DeliveryAddress_FindAddressButtonInfo, new RecordItemIndex(9));
            repo.MyHafelePortal.DeliveryAddress_FindAddressButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyHafelePortal.AddDeliveryAddressButton' at Center.", repo.MyHafelePortal.AddDeliveryAddressButtonInfo, new RecordItemIndex(10));
            repo.MyHafelePortal.AddDeliveryAddressButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
