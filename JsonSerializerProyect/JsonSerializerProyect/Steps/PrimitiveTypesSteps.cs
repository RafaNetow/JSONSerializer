using JsonSerializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace JsonSerializerProyect.Steps
{
    [Binding]
    public class PrimitiveTypesSteps
    {
        Serializer JsonSerializer = new Serializer();
        string currentString = "";
        
        [Given(@"the string '(.*)'")]
        public void GivenTheString(string p0)
        {
            currentString = p0;
        }
        
        [When(@"it is serialized")]
        public void WhenItIsSerialized()
        {
            currentString = JsonSerializer.Serialize(currentString);
        }
        
        [Then(@"the result should be """"(.*)""""")]
        public void ThenTheResultShouldBe(string expectedResult)
        {
            Assert.AreEqual(expectedResult, currentString);
        }
    }
}
