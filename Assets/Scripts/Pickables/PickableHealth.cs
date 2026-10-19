using UnityEngine;

public class PickableHealth : Pickables
{
    [SerializeField] PickablesDataSo data;
    private PlayerHealth playerHealth;
    private float healthToAdd;

    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void Start()
    {
        healthToAdd = data.healthToAdd;
    }

    public override void Pick()
    {
        playerHealth.AddHealth(healthToAdd);
        Destroy(gameObject);
    }
}
