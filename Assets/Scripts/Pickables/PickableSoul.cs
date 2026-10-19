
public class PickableSoul : Pickables
{
    public override void Pick()
    {
        //GameManager.AddPlayerPoints();
        Destroy(gameObject);
    }
}
