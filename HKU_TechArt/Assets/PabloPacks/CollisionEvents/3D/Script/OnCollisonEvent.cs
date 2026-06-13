using UnityEngine;
using UnityEngine.Events;

namespace ThreeDColider
{
    [RequireComponent(typeof(Rigidbody))]
    public class OnCollisonEvent : MonoBehaviour
    {
        [SerializeField] private string playerTag = "Player";

        [SerializeField] private UnityEvent OnEnter;
        [SerializeField] private UnityEvent OnExit;

        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.gameObject.CompareTag(playerTag))
                return;

            OnEnter?.Invoke();
        }
        private void OnCollisionExit(Collision collision)
        {
            if (!collision.gameObject.CompareTag(playerTag))
                return;

            OnExit?.Invoke();
        }
    }
}