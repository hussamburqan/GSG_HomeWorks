using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{

    public class CreatureManager : MonoBehaviour
    {
       
        void Start()
        {
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            List<Creature> creatures = new List<Creature> { kangaroo, duck };

            List<IRunnable> runnableCreatures = new List<IRunnable> { kangaroo, duck };
            List<IJumpable> jumpableCreatures = new List<IJumpable> { kangaroo };
            List<ISwimmable> swimmableCreatures = new List<ISwimmable> { duck };

            foreach (Creature creature in creatures) { 
                creature.Speak();
            }
            foreach (IRunnable runnable in runnableCreatures)
            {
                runnable.Run();
            }

            foreach (IJumpable jumpable in jumpableCreatures)
            {
                jumpable.Jump();
            }

            foreach (ISwimmable swimmable in swimmableCreatures)
            {
                swimmable.Swim();
            }
        }
    }
}
