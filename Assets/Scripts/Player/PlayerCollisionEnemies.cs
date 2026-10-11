using UnityEngine;

public class PlayerCollisionEnemies : MonoBehaviour
{
    // Colision con los enemigos u obstaculos
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemies"))
        {
            //GameManager.Instance.RemovePlayerHealth();
            //GameManager.Instance.SetDamageState(true);
        }
    }
}
