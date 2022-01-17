using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AzureCommunicationServicesWrapper;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var test = new Class1(); // Class1 is a wrapper class for the Azure Communication Services SDK, in the namespace of AzureCommunicationServicesWrapper
        Debug.Log(test.UnityTest());
        Debug.Log(test.InitCallClient());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
