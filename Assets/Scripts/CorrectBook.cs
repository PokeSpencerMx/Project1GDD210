using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBook : MonoBehaviour
{
    public GameObject keyacquired;
    public GameObject dooropener;
    
    private void OnMouseDown()
    {
        Debug.Log("Get the key!");
        keyacquired.SetActive(true);
        dooropener.GetComponent<DoorOpener>().DoorOpen();
    }
}
