//using UnityEngine;
//using UnityEngine.InputSystem;

//public class player_script : MonoBehaviour
//{
//    public InputActionAsset inputActions;
//    InputAction moveAction;
//    InputAction jumpAction;
//    InputAction attackAction;

//    Animator animator;
//    AudioSource audioSource;

//    public float moveSpeed = 5f;
//    public float rotateSpeed = 10f;

//    public AudioClip walk;
//    public AudioClip jump;

//    public Collider swordCollider; // assign in inspector

//    void Start()
//    {
//        moveAction = inputActions.FindAction("player/move");
//        jumpAction = inputActions.FindAction("player/jump");
//        attackAction = inputActions.FindAction("player/attack");

//        moveAction.Enable();
//        jumpAction.Enable();
//        attackAction.Enable();

//        animator = GetComponent<Animator>();
//        audioSource = GetComponent<AudioSource>();

//        if (swordCollider != null) swordCollider.enabled = false;
//    }

//    void Update()
//    {
//        // movement
//        Vector2 moveValue = moveAction.ReadValue<Vector2>();
//        Vector3 moveDirection = new Vector3(moveValue.x, 0, moveValue.y);

//        if (moveDirection.magnitude > 0.1f)
//        {
//            animator.SetFloat("Speed", 1f);

//            if (!audioSource.isPlaying)
//            {
//                audioSource.clip = walk;
//                audioSource.loop = true;
//                audioSource.Play();
//            }

//            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
//            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

//            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
//        }
//        else
//        {
//            audioSource.Stop();
//            animator.SetFloat("Speed", 0f);
//        }

//        // jump
//        if (jumpAction.WasPressedThisFrame())
//        {
//            audioSource.PlayOneShot(jump);
//            animator.SetTrigger("Jump");
//            transform.Translate(Vector3.up * Time.deltaTime * 5f);
//        }

//        // attack
//        if (attackAction.WasPressedThisFrame())
//        {
//            animator.SetTrigger("Attack");
//        }
//    }

//    // called from Animation Events
//    public void EnableSwordHit()
//    {
//        if (swordCollider != null) swordCollider.enabled = true;
//    }

//    public void DisableSwordHit()
//    {
//        if (swordCollider != null) swordCollider.enabled = false;
//    }
//}
