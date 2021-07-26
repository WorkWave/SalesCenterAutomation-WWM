using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.PestPac.TA.Model;
using WorkWave.PestPac.TA.SharedData;
using WorkWave.TA.TestEngine;

namespace WorkWave.PestPac.TA.Steps
{
    [Binding]

    public class SalesCenterSteps : TestSteps
    {
        private PestPacData pestPacData;
        private MainPage mainPage;

        public SalesCenterSteps(PestPacData pestPacData)
        {
            this.pestPacData = pestPacData;
            mainPage = new MainPage();
        }

        [Then(@"Verify Sales & Marketing - Sub Menu Option")]
        public void ThenVerifySalesMarketing_SubMenuOption(Table data)
        {
            pestPacData.SalesCenter = data.CreateInstance<SalesCenter>();

            Assert.True(mainPage.VerifySubMenuOptions("Sales & Marketing", pestPacData.SalesCenter.SubMenuOption));
        }

        [Then(@"Verify Add New Lead golden button in PestPac side bar")]
        public void ThenVerifyAddNewLeadGoldenButtonInPestPacSideBar()
        {
            Assert.True(mainPage.IsLoaded(), "Expected to be on {0} Page", mainPage.GetType());
            Assert.True(mainPage.VerifyAddNewLeadButtonInPestPacSideBar(), "+ New Lead Golden Button is not visible");
        }

    }
}
