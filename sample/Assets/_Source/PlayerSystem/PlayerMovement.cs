using UnityEngine;

namespace _Source.PlayerSystem
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private int speedPlayer;
        
        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        
        public void Move()
        {
            _rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speedPlayer, Input.GetAxis("Vertical") * speedPlayer);
        }
    }
}
