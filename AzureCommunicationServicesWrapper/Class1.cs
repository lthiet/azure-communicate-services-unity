using Azure.Communication.Calling;

namespace AzureCommunicationServicesWrapper
{

    /// <summary>
    /// This is a summary
    /// </summary>
    public class Class1
    {
        public float UnityTest()
        {
            return 5.5f;
        }

        public string InitCallClient()
        {
            CallClient callClient = new CallClient();
            return callClient.ToString();
        }
    }
}
