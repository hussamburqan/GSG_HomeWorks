using UnityEngine;

namespace Assignment25
{
    public class BookController : MonoBehaviour
    {
        public float openSpeed = 100f;
        public float maxOpenAngle = 120f;
        public GameObject bookContent;

        public float minScale = 0.1f;
        public float maxScale = 1f;
        public float scaleThreshold = 30f;

        private float currentAngle = 0f;
        private Vector3 originalScale;

        void Start()
        {

            bookContent.SetActive(false);
            originalScale = bookContent.transform.localScale;
            bookContent.transform.localScale = originalScale * minScale;

        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {

                currentAngle = Mathf.Min(currentAngle + openSpeed * Time.deltaTime, maxOpenAngle);
                if (currentAngle > 5)
                {
                    bookContent.SetActive(true);

                }
            }
            else
            {

                currentAngle = Mathf.Max(currentAngle - openSpeed * Time.deltaTime, 0);
                if (currentAngle < 5)
                {
                    bookContent.SetActive(false);

                }
            }

            transform.localRotation = Quaternion.Euler(0, 0, -currentAngle);

            float scaleRatio = Mathf.Clamp01((currentAngle - scaleThreshold) / (maxOpenAngle - scaleThreshold));
            float currentScaleFactor = Mathf.Lerp(minScale, maxScale, scaleRatio);

            bookContent.transform.localScale = originalScale * currentScaleFactor;

        }
    }
}