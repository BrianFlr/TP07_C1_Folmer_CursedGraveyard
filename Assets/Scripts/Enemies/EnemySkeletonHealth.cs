using UnityEngine;
using UnityEngine.UI;

public class EnemySkeletonHealth : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo skeletonData;
    [SerializeField] private Image healthBar;

    private int health = 0;

    void Start()
    {
        health = skeletonData.skeletonHealth;
    }

    // Función para recibir daño.
    public void DoDamage(int damageAmount)
    {
        health -= damageAmount;
        healthBar.fillAmount = health / skeletonData.skeletonHealth;

        if (health < 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void Die()
    {

    }
}
