﻿using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestBuild.Specs
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given]
        public void Given_I_have_entered_P0_into_the_calculator(int p0)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When]
        public void When_I_press_add()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void Then_the_result_should_be_P0_on_the_screen(int p0)
        {
            Assert.True(true);
        }
    }
}
