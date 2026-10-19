using UnityEngine;

public class PickableHealth : Pickables
{
    [SerializeField] PickablesDataSo data;
    private float healthToAdd = 0f;

    private void Start()
    {
        healthToAdd = data.healthToAdd;
    }

    public override void Pick()
    {
        //GameManager.Instance.AddHealth(healthToAdd);
        Destroy(gameObject);
    }
}
