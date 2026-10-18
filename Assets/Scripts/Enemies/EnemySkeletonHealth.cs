using UnityEngine;
using UnityEngine.UI;

public class EnemySkeletonHealth : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo skeletonData;
    [SerializeField] private Image fillHealthBar;

    [SerializeField] private float health = 0f;

    private void Start()
    {
        health = skeletonData.skeletonHealth;
    }

    // Función para recibir daño.
    public void ReceiveDamage(float damageAmount)
    {
        health -= damageAmount;
        fillHealthBar.fillAmount = health / skeletonData.skeletonHealth;

        if (health < 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void Die()
    {

    }
}
