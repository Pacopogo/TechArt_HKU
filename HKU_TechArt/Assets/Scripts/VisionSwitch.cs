using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class VisionSwitch : MonoBehaviour
{

    [SerializeField] private Animator animator;
    private bool isDark = false;

    private UnityEvent theEvent;

    [SerializeField] private UnityEvent OnDark;
    [SerializeField] private UnityEvent OffDark;

    public void SwitchDark(InputAction.CallbackContext context)
    {
        if (!context.performed)
            return;

        isDark = !isDark;
        animator.SetBool("Dark", isDark);

        theEvent = isDark ? OnDark : OffDark;

        theEvent?.Invoke();
    }
}
