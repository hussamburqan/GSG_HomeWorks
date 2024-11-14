using System.Collections;
using System.Collections.Generic;
using System; // for math :)
using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        public float X, Y, Z;

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void PrintPosition()
        {
            Debug.Log($"Position X = {X} Y = {Y} Z = {Z}");
        }
    }

    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set { health = Math.Min(value, 100); }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}");
            Debug.Log($"Health: {Health}");
            position.PrintPosition();
        }

        public void Attack(int damage, Character target)
        {
            Attack(damage, target, "");
        }

        public void Attack(int damage, Character target, string typeAttack)
        {
            target.Health -= damage;
            Debug.Log($"Type of attack : {typeAttack}");
            
        }
    }

    public class Soldier : Character
    {
        public Soldier() : base() { }

        public Soldier(string name, int health, Position position)
            : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }

    public class Officer : Character
    {
        public Officer(string name, int health, Position position)
            : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }

    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character[] characters = new Character[2];
            characters[0] = new Soldier();
            characters[1] = new Officer("hacker", 1000, new Position(0, 0, 0));

            foreach (Character character in characters)
            {
                character.DisplayInfo();
            }

            Debug.Log($"Soldier health before attack: {characters[0].Health}");
            characters[1].Attack(30, characters[0], "kicking");
            Debug.Log($"Soldier health after attack: {characters[0].Health}");
        }
    }
}