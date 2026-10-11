using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{
    [Header ("Object Pools")]
    [SerializeField] private CrowObjectPool crowPool;

    // Creo variables GameObject para luego asignarle el objeto que tomare de mis pools
    private GameObject crowClone;

    private float crowSpawnRate = 0f;
    private float crowSpawnTimer = 0f;
    private float crowRrandomPositionY = 0f;

    void Update()
    {
        crowSpawnTimer += Time.deltaTime;

        // Comparo con si el tiempo paso lo suficiente para volver a spawnear otro cuervo
        if (crowSpawnTimer >= crowSpawnRate)
        {
            crowRrandomPositionY = Random.Range(-1.5f,5f);
            SpawnCrow();

            crowSpawnTimer -= crowSpawnRate;
            crowSpawnRate = Random.Range(1.5f, 3f);
        }
    }

    // Funcion para spawnear los cuervos
    private void SpawnCrow()
    {
        // Tomo un objeto de mi pool
        crowClone = crowPool.GetObjectCrow();

        // Ubico el objeto en la posicion X del spawner y en una posicion aleatoria en Y
        crowClone.transform.position = new Vector2(transform.position.x, crowRrandomPositionY);
    }
}
