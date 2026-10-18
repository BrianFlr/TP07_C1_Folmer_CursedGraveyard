using UnityEngine;

public class EnemySkeletonHealth : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo skeletonData;

    private int health = 0;

    void Start()
    {
        health = skeletonData.skeletonHealth;
    }

    // Función para recibir daño.
    public void DoDamage(int damageAmount)
    {
        health -= damageAmount;
    }
}
