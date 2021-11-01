using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }


    //public Sprite X for each of the assets for items that go into the iventory.
    //Timestamp 8:20 to continue when we have the sprites.
}
