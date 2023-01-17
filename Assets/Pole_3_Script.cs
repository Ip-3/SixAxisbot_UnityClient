using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole_3_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode pressFront, pressBack;
    float speed = 50.0f;
    void Start()
    {
        
    }

    void Update()
    {
        string dataText = TcpClientexample.data_from_qt;
        Debug.Log(dataText);
        if (dataText == "Pole3 Forward")
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }
        if (dataText == "Pole3 Backward")
        {
            transform.Rotate(-Vector3.right * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }

    }
}
