//using UnityEngine;
//using UnityEngine.InputSystem;

//public class player_script : MonoBehaviour
//{


//    public InputActionAsset inputActions;
//    InputAction moveAction;
//    InputAction jumpAction;
//    Animator animator;
//    AudioSource AudioClip;

//    public float moveSpeed = 5f;
//    public float rotateSpeed = 10f;

//    public AudioClip walk;
//    public AudioClip jump;

//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        moveAction = inputActions.FindAction("player/move");
//        jumpAction = inputActions.FindAction("player/jump");
//        moveAction.Enable();
//        jumpAction.Enable();
//        animator = GetComponent<Animator>();
//        animator.SetTrigger("idle");
//        AudioClip = GetComponent<AudioSource>();

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Vector2 moveValue = moveAction.ReadValue<Vector2>();
//        Vector3 moveDirection = new Vector3(moveValue.x, 0, moveValue.y);

//        if (moveDirection.magnitude > 0.1f)
//        {
//            animator.SetTrigger("walk");

//            if (!AudioClip.isPlaying)
//            {
//                AudioClip.clip = walk;
//                AudioClip.loop = true;
//                AudioClip.Play();
//            }


//            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
//            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

//            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

//        }
//        else
//        {
//            AudioClip.Stop();
//            animator.SetTrigger("idle");
//        }
//        if (jumpAction.WasPressedThisFrame())
//        {
//            AudioClip.PlayOneShot(jump);
//            animator.SetTrigger("jump");
//            transform.Translate(Vector3.up * Time.deltaTime * 5f);
//        }

//    }
//}


