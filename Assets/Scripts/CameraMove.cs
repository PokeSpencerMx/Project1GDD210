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
