using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public enum ItemType
    {
        PotionCork,
        PotionThin,
        PotionSmall
    }

    public ItemType itemType;
    public int amount;
}
