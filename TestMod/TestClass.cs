using UnityEngine;

namespace TestMod
{
    public class TestClass : MonoBehaviour
    {
        public float TestValue = 500f;

        float delay = 1f;
        float c_delay = 0f;

        private void Start()
        {

        }

        private void Update()
        {
            c_delay += Time.deltaTime;
            if (c_delay >= delay)
            {
                c_delay = 0f;
                if (gameObject.name == "lel")
                {
                    gameObject.name = "kek";
                }
                else
                {
                    gameObject.name = "lel";
                }
            }
        }
    }
}
