using UnityEngine;

namespace _Source.BulletSystem
{
    public class TimerLive : MonoBehaviour
    {
        [SerializeField] private float secondLive;

        private void Update()
        {
            secondLive -= Time.deltaTime;
            if (secondLive <= 0)
                Destroy(gameObject);
        }
    }
}