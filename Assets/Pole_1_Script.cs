using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole_1_Script : MonoBehaviour
{
    public KeyCode pressFront, pressBack;
    public float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string dataText = TcpClientexample.data_from_qt;
        Debug.Log(dataText);
        if (dataText == "Pole1 Forward")
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }
        if (dataText == "Pole1 Backward")
        {
            transform.Rotate(-Vector3.right * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }

    }
}
