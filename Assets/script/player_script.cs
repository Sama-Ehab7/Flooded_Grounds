using UnityEngine;
using UnityEngine.InputSystem;

public class player_script : MonoBehaviour
{
    public InputActionAsset inputActions;
    InputAction moveAction;
    InputAction jumpAction;
    InputAction attackAction;

    Animator animator;

    public float moveSpeed = 5f;
    public float rotateSpeed = 10f;


    public Collider swordCollider; // assign in inspector

    void Start()
    {
        moveAction = inputActions.FindAction("player/move");
        jumpAction = inputActions.FindAction("player/jump");
        attackAction = inputActions.FindAction("player/attack");

        moveAction.Enable();
        jumpAction.Enable();
        attackAction.Enable();

        animator = GetComponent<Animator>();

        if (swordCollider != null) swordCollider.enabled = false;
    }

    void Update()
    {
        // movement
        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(moveValue.x, 0, moveValue.y);

        if (moveDirection.magnitude > 0.1f)
        {
           animator.SetBool("isWalking", true);

            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
       
            animator.SetBool("isWalking", false);
        }

        // jump
        if (jumpAction.WasPressedThisFrame())
        {
            animator.SetTrigger("Jump");
            transform.Translate(Vector3.up * Time.deltaTime * 5f);
        }

        // attack
        if (attackAction.WasPressedThisFrame())
        {
            animator.SetTrigger("Attack");
        }
    }

    // called from Animation Events
    public void EnableSwordHit()
    {
        if (swordCollider != null) swordCollider.enabled = true;
    }

    public void DisableSwordHit()
    {
        if (swordCollider != null) swordCollider.enabled = false;
    }
}
