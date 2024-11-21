using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {

            GameContainer<string> potionContainer = new GameContainer<string>();

            potionContainer.SetItem("Healing Potion");

            Debug.Log($"Stored item: {potionContainer.GetItem()}");

            string description = GameUtils.DescribeItem(potionContainer.GetItem());

            Debug.Log(description);

        }
    }
}