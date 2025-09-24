using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player;
    public quest quest;
    public float see = 10f;
    public float speed = 2f;
    public float stop = 2f;

    void start()
    {

    }

    void Update()
    {
       if(!player) return;

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < see)
        {
            if(distance >stop)
            {
                Vector3 dir = player.position - transform.position;
                if(dir.sqrMagnitude > 0.01f) {

                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 0.3f);
                }


            }
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "attack")   
        {
            if (quest != null)
            {
                quest.AddKill();
            }
            Destroy(gameObject);
        }
    }
}