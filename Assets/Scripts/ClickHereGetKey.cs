using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHereGetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Get key now to win the game");
        }
    }
}
