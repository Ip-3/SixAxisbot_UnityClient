using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Threading;
public class RotationScript : MonoBehaviour
{

    public KeyCode pressLeft, pressRight;
    public float baseRotation = 0.0f, speed = 50.0f;
    public InputField inputField;
    public Text textElement;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        string dataText = TcpClientexample.data_from_qt;
        Debug.Log(dataText);
        if (dataText != null) { textElement.text = dataText; }
        if (dataText == "Right")
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }
        if (dataText == "Left")
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
            TcpClientexample.data_from_qt = "";
        }

    }

}
