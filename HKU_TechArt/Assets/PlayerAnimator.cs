using PacoUtility;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private HorizontalMovement movement;
    [SerializeField] private PlayerJump jump;

    private void Update()
    {
        animator.SetBool("IsGrounded", jump.IsGrounded());
        animator.SetFloat("Velocity", movement.inputDir.magnitude);
    }
}
