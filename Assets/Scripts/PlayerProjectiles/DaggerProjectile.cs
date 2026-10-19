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

    private void OnEnable()
    {
        daggerSpeed = data.daggerSpeed;
        daggerDamage = data.daggerDamage + GameManager.Instance.GetDamageBoost();
        daggerLifeTime = data.daggerLifeTime;
    }

    private void Update()
    {
        // Timer del tiempo de vida de la daga.
        daggerLifeTimer += Time.deltaTime;

        if (daggerLifeTimer >= daggerLifeTime)
        {
            DesactiveDagger();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemySkeletonHealth skeleton = other.GetComponent<EnemySkeletonHealth>();
        EnemyGhostHealth ghost = other.GetComponent<EnemyGhostHealth>();

        if (skeleton != null )
        {
            skeleton.ReceiveDamage(daggerDamage);
        }

        if (ghost != null)
        {
            ghost.ReceiveDamage(daggerDamage);
        }

        DesactiveDagger();
    }

    private void DesactiveDagger()
    {
        gameObject.SetActive(false);
        trailRenderer.Clear();
        daggerLifeTimer = 0f;
    }

    // Función para impulsar la daga.
    public void ImpulseDagger(int sign)
    {
        Vector3 direction = new Vector3(sign, 0, 0).normalized;
        transform.right = direction;
        rb.AddForce(direction * daggerSpeed, ForceMode2D.Impulse);
    }
}
