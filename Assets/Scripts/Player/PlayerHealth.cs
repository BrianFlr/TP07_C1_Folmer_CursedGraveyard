using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerDataSo playerData;
    [SerializeField] private Image fillHealthBar;
    [SerializeField] private GameObject enemyDeathEffectPrefab;

    private float health = 0f;

    private void Start()
    {
        health = playerData.health;
    }

    // Función para recibir daño.
    public void ReceiveDamage(float damageAmount)
    {
        health -= damageAmount;
        fillHealthBar.fillAmount = health / playerData.health;

        Die();
    }

    private void Die()
    {
        if (health < 1)
        {
            //GameManager.SetGameOverState(false);
        }
    }
}
