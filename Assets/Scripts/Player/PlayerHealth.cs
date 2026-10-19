using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerDataSo playerData;
    [SerializeField] private Image fillHealthBar;

    private float maxHealth = 0f;
    private float health = 0f;

    private void Start()
    {
        maxHealth = playerData.health;
        health = playerData.health;
    }

    // Función para añadir vida.
    public void AddHealth(float healthAmount)
    {
        health = Mathf.Clamp(health + healthAmount, 0, maxHealth);
        fillHealthBar.fillAmount = health / playerData.health;
    }

    // Función para recibir daño.
    public void ReceiveDamage(float damageAmount)
    {
        health -= damageAmount;
        fillHealthBar.fillAmount = health / playerData.health;

        GameOver();
    }

    private void GameOver()
    {
        if (health < 1)
        {
            //GameManager.SetGameOverState(false);
        }
    }
}
