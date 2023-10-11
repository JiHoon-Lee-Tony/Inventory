using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvenUI : MonoBehaviour
{
    public GameObject inventory;
    Button itemBtn;
    bool activeInventory = false;
    void Start()
    {
        inventory.SetActive(activeInventory);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            inventory.SetActive(activeInventory);
        }
    }

    void AddItemButton(Weapon item)
    {
        
        /*
         * TODO
         * Find, SetParent, Instantiate
         */
    }

    void RemoveItemButton(Weapon item)
    {
        /*
         * TODO
         * Destroy()
         */
    }
}
