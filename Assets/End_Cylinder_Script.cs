using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class End_Cylinder_Script : MonoBehaviour
{
    public KeyCode pressLeft, pressRight;
    float speed = 50.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        string dataText = TcpClientexample.data_from_qt;
        Debug.Log(dataText);
        if (dataText == "Pole4 Forward")
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }
        if (dataText == "Pole4 Backward")
        {
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }

    }

    
}
