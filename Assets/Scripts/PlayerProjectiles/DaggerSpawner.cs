using UnityEngine;

public class DaggerSpawner : MonoBehaviour
{
    [Header ("Object Pool")]
    [SerializeField] private DaggerObjectPool daggerPool;

    // Creo una variable GameObject para luego asignarle el objeto que tomare del pool
    private GameObject daggerClone;

    private float throwRate = 2f;
    private float throwTimer = 0f;

    void Update()
    {
        throwTimer += Time.deltaTime;

        // Comparo con si el tiempo paso lo suficiente para volver a lanzar otra daga
        if (throwTimer >= throwRate)
        {
            ThrowDagger();
            throwTimer -= throwRate;
        }
    }

    // Funcion para lanzar las dagas
    private void ThrowDagger()
    {
        // Tomo un objeto de la pool
        daggerClone = daggerPool.GetObjectDagger();

        // Ubico el objeto en la posicion de lanzamiento
        daggerClone.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
}
