using UnityEngine;

public class HealthV1 : MonoBehaviour
{
    public int HP = 100;
    public void TakeDamage(int damage)
    {
        HP -= damage;

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
