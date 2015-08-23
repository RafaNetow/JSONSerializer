using JsonSerializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace JsonSerializerProyect
{
    [Binding]
    public class CalculetorSteps
    {
        private int resultado { get; set; }
        Calculetor calculadora = new Calculetor();
       

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p1)
        {
            calculadora.FirstNumber = p1;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            calculadora.SecondNumber = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {

            resultado = calculadora.add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, resultado);
        }
    }
}
