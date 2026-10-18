using UnityEngine;

public class DaggerProjectile : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private PlayerProjectilesDataSo data;

    [Header("Visual")]
    [SerializeField] private TrailRenderer trailRenderer;

    private Rigidbody2D rb;

    private float daggerSpeed = 0f;
    private int daggerDamage = 0;
    private float daggerLifeTime = 0f;
    private float daggerLifeTimer = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
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
            DesactiveDagger();
            daggerLifeTimer = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemySkeleton skeleton = other.GetComponent<EnemySkeleton>();
        //EnemyGhost ghost = other.GetComponent<EnemyGhost>();

        if (skeleton != null )
        {
            skeleton.DoDamage(daggerDamage);
        }

        //if (ghost != null )
        //{
        //    ghost.DoDamage(daggerDamage);
        //    DesactiveDagger();
        //}

        DesactiveDagger();
    }

    private void DesactiveDagger()
    {
        gameObject.SetActive(false);
        trailRenderer.Clear();
    }

    // Función para impulsar la daga.
    public void ImpulseDagger(int sign)
    {
        Vector3 direction = new Vector3(sign, 0, 0).normalized;
        transform.right = direction;
        rb.AddForce(direction * daggerSpeed, ForceMode2D.Impulse);
    }

    
}
