using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        PurpleKey,
        Book,
        RedKey
    }

    public ItemType itemType;
    public int amount;

}
