using UnityEngine;
using UnityEngine.UI;

public class EnemyGhostHealth : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo ghostData;
    [SerializeField] private Image healthBar;

    private float health = 0f;

    private void Start()
    {
        health = ghostData.ghostHealth;
    }

    // Función para recibir daño.
    public void ReceiveDamage(float damageAmount)
    {
        health -= damageAmount;
        healthBar.fillAmount = health / ghostData.ghostHealth;

        if (health < 1)
        {
            gameObject.SetActive(false);
        }
    }
}
