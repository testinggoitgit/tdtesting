using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUI;

    public static Action OnInventoryUpdate;

    public Inventory inventory;

    public Item selectedItem;

    private void Awake()
    {
        InputManager.OnItemChoosed += EquipItem;
    }

    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EquipItem(int itemIndex)
    {
        selectedItem = inventory.items[itemIndex - 1];
        textUI.text = $"Equiped item: {selectedItem}";
        OnInventoryUpdate.Invoke();
    }
}
