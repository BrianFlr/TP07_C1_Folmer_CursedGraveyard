using Unity.VisualScripting;
using UnityEngine;

public class EnemySkeleton : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo skeletonData;

    private int skeletonHealth = 0;
    private float skeletonSpeed = 0;

    void Start()
    {
        skeletonHealth = skeletonData.skeletonHealth;
        skeletonSpeed = skeletonData.skeletonSpeed;
    }

    // Función para recibir daño.
    public void DoDamage(int damageAmount)
    {
        skeletonHealth -= damageAmount;
    }
}
