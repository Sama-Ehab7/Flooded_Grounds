//using UnityEngine;

//public class PlayerController : MonoBehaviour
//{
//    public float moveSpeed = 5f;
//    private Animator animator;
//    private Rigidbody rb;

//    private Vector3 moveDirection;

//    void Start()
//    {
//        animator = GetComponent<Animator>();
//        rb = GetComponent<Rigidbody>();
//    }

//    void Update()
//    {
//        float moveX = Input.GetAxisRaw("Horizontal");
//        float moveZ = Input.GetAxisRaw("Vertical");
//        moveDirection = new Vector3(moveX, 0, moveZ).normalized;

//        animator.SetFloat("Speed", moveDirection.magnitude);

//        if (Input.GetMouseButtonDown(1))
//        {
//            animator.SetTrigger("Attack");
//        }
//    }

//    void FixedUpdate()
//    {
//        if (moveDirection.magnitude > 0)
//        {
//            rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);

//            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
//            rb.rotation = Quaternion.Slerp(rb.rotation, targetRotation, 0.15f);
//        }
//    }
//}
