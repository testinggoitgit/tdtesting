using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
    public List<ItemUI> itemsUI;

    public GameObject inventoryUI;

    private void Awake()
    {
        Player.OnInventoryUpdate += UpdateInventoryUI;
    }

    private void Start()
    {
        itemsUI = inventoryUI.GetComponentsInChildren<ItemUI>().ToList();
    }

    public void UpdateInventoryUI()
    {
        for (int i = 0; i < items.Count; i++)
        {
            itemsUI[i].SetItem(items[i]);
        }
    }
}
