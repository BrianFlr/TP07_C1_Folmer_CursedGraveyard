using UnityEngine;

public class EnemyGhostHealth : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo ghostData;

    private int health = 0;

    void Start()
    {
        health = ghostData.ghostHealth;
    }

    // Función para recibir daño.
    public void DoDamage(int damageAmount)
    {
        health -= damageAmount;
    }
}
