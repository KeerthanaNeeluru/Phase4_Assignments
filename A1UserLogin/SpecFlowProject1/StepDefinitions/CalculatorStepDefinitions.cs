using A1UserLogin;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        private readonly UserLogin ul;
        private string myresult;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        public CalculatorStepDefinitions(UserLogin userl)
        {
            ul = userl;
        }
        [Given("the UserName is \"(.*)\"")]
        public void GivenTheUserNameIs(string un)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            ul.UserName = un == "null" ? null : un;
        }

        [Given("the Password is \"(.*)\"")]
        public void GivenThePasswordIs(string pwd)
        {
            //TODO: implement arrange (precondition) logic

            ul.Password = pwd == "null" ? null : pwd;
        }

        [When("TryLogin")]
        public void WhenTryLogin()
        {
            //TODO: implement act (action) logic

            myresult = ul.Login();
        }

        [Then("the result should be \"(.*)\"")]
        public void ThenTheResultShouldBe(string result)
        {
            //TODO: implement assert (verification) logic

           myresult.Should().Be(result);
        }
    }
}