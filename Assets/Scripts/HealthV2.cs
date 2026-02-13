using UnityEngine;

public class HealthV2 : MonoBehaviour
{
    public int MaxHP = 100;
    int accumDamage = 0;
    public void TakeDamage(int damage)
    {
        accumDamage += damage;
        
        if (accumDamage >= MaxHP)
        {
            Destroy(gameObject);
        }
    }
}
