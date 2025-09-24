using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public int damage = 25;
    private bool canDamage = false;

    public void EnableDamage()
    {
        canDamage = true;
    }

    public void DisableDamage()
    {
        canDamage = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canDamage && other.CompareTag("Enemy"))
        {
            EnemyHealth enemy = other.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
