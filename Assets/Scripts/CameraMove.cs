using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Left Arrow
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftTurn();
        }
        //A Key
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftTurn();
        }
        //Right Arrow
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightTurn();
        }
        //D Key
        if (Input.GetKeyDown(KeyCode.D))
        {
            RightTurn();
        }
    }

    public void LeftTurn()
    {
        Debug.Log("Left");
        transform.Rotate(new Vector3(0, -90, 0));
    }

    public void RightTurn()
    {
        Debug.Log("Right");
        transform.Rotate(new Vector3(0, 90, 0));
    }
}
