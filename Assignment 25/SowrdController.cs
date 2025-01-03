using UnityEngine;

namespace Assignment25
{
    public class SwordController : MonoBehaviour
    {
        public float swingSpeed = 400f;
        public float maxSwingAngle = 180f;
        public float restingAngle = -33f;

        private float currentAngle;
        private bool isSwinging = false;
        private bool swingForward = true;

        void Start()
        {
            currentAngle = restingAngle;
            transform.localRotation = Quaternion.Euler(0, 0, currentAngle);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse1) && !isSwinging)
            {
                isSwinging = true;
                swingForward = true;
            }

            if (isSwinging)
            {
                if (swingForward)
                {
                    currentAngle += swingSpeed * Time.deltaTime;
                    if (currentAngle >= maxSwingAngle)
                    {
                        currentAngle = maxSwingAngle;
                        swingForward = false;
                    }
                }
                else
                {
                    currentAngle -= swingSpeed * Time.deltaTime;
                    if (currentAngle <= restingAngle)
                    {
                        currentAngle = restingAngle;
                        isSwinging = false;
                    }
                }

                transform.localRotation = Quaternion.Euler(0, 0, currentAngle);
            }
        }
    }
}