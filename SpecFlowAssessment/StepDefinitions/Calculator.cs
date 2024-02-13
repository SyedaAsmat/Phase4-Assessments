namespace SpecFlowAssessment.StepDefinitions
{
    public class Calculator
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Substract()
        {
            int res;
            res = num1 - num2;
            return res;
        }
        public int Multiply()
        {
            int res;
            res = num1 * num2;
            return res;
        }
        public int Divide()
        {
            int res;
            res = num1 / num2;
            return res;
        }
    }
}