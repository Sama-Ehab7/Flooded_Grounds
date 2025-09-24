using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public int damage = 25;



    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag("Enemy"))
        {
            EnemyHealth enemy = other.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
