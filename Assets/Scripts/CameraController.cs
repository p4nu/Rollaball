using UnityEngine;

namespace Scripts
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] GameObject player;

        Vector3 _offset;

        void Start()
        {
            _offset = transform.position - player.transform.position;
        }

        void LateUpdate()
        {
            transform.position = player.transform.position + _offset;
        }
    }
}
