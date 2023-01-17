using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tip_Bones_Grab_Script : MonoBehaviour
{
    // Start is called before the first frame update
    //public 
    public Component tip_1, tip_2, tip_3, tip_4;
    public KeyCode converge, diverge;
    float speed = 10.0f;
    float movement = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(converge))
        {
            //tip_1.transform.Rotate(Vector3.right * speed * Time.deltaTime);
            //tip_2.transform.Rotate(Vector3.up * speed * Time.deltaTime);
            //tip_3.transform.Rotate(-Vector3.right * speed * Time.deltaTime);
            //tip_4.transform.Rotate(Vector3.up * speed * Time.deltaTime);
            //movement = tip_1.transform.position.y;
            //tip_1.transform.position = new Vector3(movement-=0.1f, tip_1.transform.position.y, tip_1.transform.position.z);
        }

        if (Input.GetKey(diverge))
        {
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);
        }
    }
}
