using Unity.VisualScripting;
using UnityEngine;

public class PickableHealth : Pickables
{
    //[SerializeField] 

    public override void Pick()
    {
        //PlayerHealth.AddHealth();
        Destroy(gameObject);
    }
}
