using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public Item item;
    public Image image;

    public void SetItem(Item newItem)
    {
        item = newItem;
        image.sprite = newItem.itemData.icon;
        image.enabled = true;
    }

    public void ClearItem()
    {
        item = null;
        image.sprite = null;
        image.enabled = false;
    }
}
