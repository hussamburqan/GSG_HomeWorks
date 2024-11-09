using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Character
{
    private string name;
    private int health;
    public string CharacterName
    {
        get { return name; }
        set { name = value; }
    }
    public int CharacterHealth
    {
        get { return health; }
        set { health = value; }

    }
    public Character(string name, int health)
    {
        CharacterName = name;
        CharacterHealth = health;
    }
}
