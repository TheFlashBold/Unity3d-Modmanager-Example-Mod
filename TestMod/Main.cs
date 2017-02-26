using System.Collections.Generic;
using UnityEngine;

namespace TestMod
{
    public class Main
    {
        public static string ModName = "TestMod";
        public static string ModVersion = "1.0";

        public float testValue = 500f;

        GameObject g;
        
        // Required, will be run once the mod was loaded
        public void Start()
        {
            Debug.Log("It's a test!");

            g = new GameObject();
            g.name = "Created from a mod";
            g.AddComponent<TestClass>();

            foreach(KeyValuePair<string, string> c in Modmanager.ModConfig[ModName])
            {
                Debug.Log(c.Key + " = " + c.Value);
            }            
        }
    }
}
