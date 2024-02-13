namespace SpecFlowAssessment.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator;
        private int result;

        public CalculatorStepDefinitions(ScenarioContext sc)
        {
            scenarioContext = sc;
            calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.num1 = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.num2 = number;
        }

        //Substracted
        [When("the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            result = calculator.Substract();
        }

        //Multiplied
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calculator.Multiply();
        }

        //Divideed
        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calculator.Substract();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            result.Should().Be(result);
        }
    }
}
