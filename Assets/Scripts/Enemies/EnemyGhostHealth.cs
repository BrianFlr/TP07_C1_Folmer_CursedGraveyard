using UnityEngine;
using UnityEngine.UI;

public class EnemyGhostHealth : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo ghostData;
    [SerializeField] private Image healthBar;

    private int health = 0;

    void Start()
    {
        health = ghostData.ghostHealth;
    }

    // Función para recibir daño.
    public void DoDamage(int damageAmount)
    {
        health -= damageAmount;
        healthBar.fillAmount = health / ghostData.ghostHealth;
    }
}
