
using UnityEngine;

public class PickableSoul : Pickables
{
    [SerializeField] PickablesDataSo data;
    private float pointsToAdd = 0f;

    private void Start()
    {
        pointsToAdd = data.pointsToAdd;
    }

    public override void Pick()
    {
        //GameManager.Instance.AddPoints();
        Destroy(gameObject);
    }
}
