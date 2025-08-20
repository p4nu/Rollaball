using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float speed;

        PlayerInput playerInput;
        Rigidbody rb;

        HUDController hudController;

        int _totalPickUps;
        int _count;
        float _movementX;
        float _movementY;

        void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Start()
        {
            playerInput = GetComponent<PlayerInput>();
            InputSystem.actions.Disable();
            playerInput.currentActionMap?.Enable();

            hudController = FindFirstObjectByType<HUDController>();

            _totalPickUps = GameObject.FindGameObjectsWithTag("PickUp").Length;
            _count = 0;
        }

        void FixedUpdate()
        {
            Vector3 movement = new Vector3(_movementX, 0, _movementY);
            rb.AddForce(movement * speed);
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PickUp"))
            {
                other.gameObject.SetActive(false);
                hudController.SetCountText(++_count);

                if (_count >= _totalPickUps)
                {
                    hudController.ShowYouWin();
                    Destroy(GameObject.FindGameObjectWithTag("Enemy"));
                }
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                gameObject.SetActive(false);
                hudController.ShowYouLose();
            }
        }

        // Ignore unused warning here. It gets called using SendMessage() on the GameObject
        void OnMove(InputValue movementValue)
        {
            Vector2 movementVector = movementValue.Get<Vector2>();
            _movementX = movementVector.x;
            _movementY = movementVector.y;
        }
    }
}
