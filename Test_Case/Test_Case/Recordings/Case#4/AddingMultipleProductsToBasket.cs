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

namespace Test_Case.Recordings.CaseHash4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddingMultipleProductsToBasket recording.
    /// </summary>
    [TestModule("d3bad912-b205-46d8-a017-8d49bc4f6add", ModuleType.Recording, 1)]
    public partial class AddingMultipleProductsToBasket : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Test_Case.Test_CaseRepository repository.
        /// </summary>
        public static global::Test_Case.Test_CaseRepository repo = global::Test_Case.Test_CaseRepository.Instance;

        static AddingMultipleProductsToBasket instance = new AddingMultipleProductsToBasket();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddingMultipleProductsToBasket()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddingMultipleProductsToBasket Instance
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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestCaseStudy.BtnEGift' at 56;49.", repo.TestCaseStudy.BtnEGiftInfo, new RecordItemIndex(0));
            repo.TestCaseStudy.BtnEGift.Click("56;49");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'TestCaseStudy.ProductList.Product1' at 183;399.", repo.TestCaseStudy.ProductList.Product1Info, new RecordItemIndex(1));
            repo.TestCaseStudy.ProductList.Product1.MoveTo("183;399");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestCaseStudy.BtnQuickLk1' at 40;15.", repo.TestCaseStudy.BtnQuickLk1Info, new RecordItemIndex(2));
            repo.TestCaseStudy.BtnQuickLk1.Click("40;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3s to exist. Associated repository item: 'TestCaseStudy.BtnAddBasket1'", repo.TestCaseStudy.BtnAddBasket1Info, new ActionTimeout(3000), new RecordItemIndex(3));
            repo.TestCaseStudy.BtnAddBasket1Info.WaitForExists(3000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestCaseStudy.BtnAddBasket1' at 138;44.", repo.TestCaseStudy.BtnAddBasket1Info, new RecordItemIndex(4));
            repo.TestCaseStudy.BtnAddBasket1.Click("138;44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'TestCaseStudy.ProductList.Product2' at 131;371.", repo.TestCaseStudy.ProductList.Product2Info, new RecordItemIndex(5));
            repo.TestCaseStudy.ProductList.Product2.MoveTo("131;371");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestCaseStudy.ProductList.BtnQuickLk2' at 34;3.", repo.TestCaseStudy.ProductList.BtnQuickLk2Info, new RecordItemIndex(6));
            repo.TestCaseStudy.ProductList.BtnQuickLk2.Click("34;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'TestCaseStudy.BtnAddBasket2'", repo.TestCaseStudy.BtnAddBasket2Info, new ActionTimeout(5000), new RecordItemIndex(7));
            repo.TestCaseStudy.BtnAddBasket2Info.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestCaseStudy.BtnAddBasket2' at 16;5.", repo.TestCaseStudy.BtnAddBasket2Info, new RecordItemIndex(8));
            repo.TestCaseStudy.BtnAddBasket2.Click("16;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'TestCaseStudy.PageWrapper.BtnBasket'", repo.TestCaseStudy.PageWrapper.BtnBasketInfo, new ActionTimeout(5000), new RecordItemIndex(9));
            repo.TestCaseStudy.PageWrapper.BtnBasketInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'TestCaseStudy.RegisterForm.HeaderUserMenu' at 394;4.", repo.TestCaseStudy.RegisterForm.HeaderUserMenuInfo, new RecordItemIndex(10));
            repo.TestCaseStudy.RegisterForm.HeaderUserMenu.MoveTo("394;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TestCaseStudy.PageWrapper.BtnBasket' at 87;11.", repo.TestCaseStudy.PageWrapper.BtnBasketInfo, new RecordItemIndex(11));
            repo.TestCaseStudy.PageWrapper.BtnBasket.DoubleClick("87;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n                Sepetim (2 Ürün)\n            ') on item 'TestCaseStudy.H1TagBasketCount'.", repo.TestCaseStudy.H1TagBasketCountInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TestCaseStudy.H1TagBasketCountInfo, "InnerText", "\n                Sepetim (2 Ürün)\n            ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TestCaseStudy.BasketItem1'.", repo.TestCaseStudy.BasketItem1Info, new RecordItemIndex(13));
            Validate.Exists(repo.TestCaseStudy.BasketItem1Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TestCaseStudy.BasketItem2'.", repo.TestCaseStudy.BasketItem2Info, new RecordItemIndex(14));
            Validate.Exists(repo.TestCaseStudy.BasketItem2Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
