using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour
{
    public GameObject game;

    

    public void OnMouseDown()
    {
        Destroy(game);
    }
}
