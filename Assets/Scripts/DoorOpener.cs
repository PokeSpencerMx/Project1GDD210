using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpener : MonoBehaviour
{
    public GameObject gottenkey;
    bool keyInInventory = false;
    
    public void DoorOpen()
    {
        keyInInventory = true;
    }

    private void OnMouseDown()
    {
        if (keyInInventory == true)
        {
            Debug.Log("WIN THE GAME");
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("It won't open! I need to find a key first!");
        }
    }
}
