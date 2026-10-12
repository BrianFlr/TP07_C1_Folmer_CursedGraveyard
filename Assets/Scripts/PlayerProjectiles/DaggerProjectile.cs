using UnityEngine;

public class DaggerProjectile : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private PlayerProjectilesDataSo data;

    [Header("Visual")]
    [SerializeField] private TrailRenderer trailRenderer;

    private Rigidbody2D rb;

    private float daggerSpeed = 0f;
    private float daggerDamage = 0f;
    private float daggerLifeTime = 0f;
    private float daggerLifeTimer = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        daggerSpeed = data.daggerSpeed;
        daggerDamage = data.daggerDamage;
        daggerLifeTime = data.daggerLifeTime;
    }

    private void Update()
    {
        // Timer del tiempo de vida de la daga.
        daggerLifeTimer += Time.deltaTime;

        if (daggerLifeTimer >= daggerLifeTime)
        {
            gameObject.SetActive(false);
            trailRenderer.Clear();

            daggerLifeTimer = 0f;
        }
    }

    // Función para impulsar la daga.
    public void ImpulseDagger(int sign)
    {
        Vector3 direction = new Vector3(sign, 0, 0).normalized;
        rb.AddForce(direction * daggerSpeed, ForceMode2D.Impulse);
    }
}
