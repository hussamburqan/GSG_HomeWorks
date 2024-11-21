using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory WeaponsInventory = new Inventory();

            WeaponsInventory.AddItem("Sword");
            WeaponsInventory.AddItem("Shield");

            Inventory GearInventory = new Inventory();

            GearInventory.AddItem("cap gear");
            GearInventory.AddItem("pants gear"); // ??????

            Inventory combinedInventory = WeaponsInventory + GearInventory;

            combinedInventory.ShowItems();
        }
    }
}