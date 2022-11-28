using UnityEngine;

namespace _Source.BulletSystem
{
    public class Force : MonoBehaviour
    {
        [SerializeField] private Vector2 vector2;
    
        private Rigidbody2D _rb;
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _rb.AddForce(vector2, ForceMode2D.Impulse);
        }
    }
}
