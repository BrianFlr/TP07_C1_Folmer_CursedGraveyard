using UnityEngine;

public class EnemyGhostFollow : MonoBehaviour
{
    [SerializeField] private EnemiesDataSo ghostData;
    [SerializeField] private LayerMask playerMask;
    private Transform playerTransform;
    private Rigidbody2D rb;
    
    private GhostStateMovement actualState = GhostStateMovement.Wait;
    private float speed = 0f;
    private float aggroRange = 0f;

    private Vector3 initialPosition = Vector3.zero;
    private float maxDistance = 0f;

    public enum GhostStateMovement
    {
        Wait,
        Follow
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        speed = ghostData.ghostSpeed;
        aggroRange = ghostData.ghostAggroRange;
        initialPosition = transform.position;
    }

    private void FixedUpdate()
    {
        // Analizo el estado actual del enemigo.
        switch (actualState)
        {
            case GhostStateMovement.Wait:
                WaitState();
                break;
            case GhostStateMovement.Follow:
                FollowState();
                break;
        }
    }

    // Función para dibujar la esfera.
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, aggroRange);
    }

    // Función del estado de esperar del enemigo.
    private void WaitState()
    {
        // Genero un círculo para detectar si algo colisiona ingresando dentro de este.
        Collider2D playerCollision = Physics2D.OverlapCircle(transform.position, aggroRange, playerMask);

        // Si algo entra dentro del rango.
        if (playerCollision != null)
        {
            // Asigno el tranform de lo que hizo colision.
            playerTransform = playerCollision.transform;
            
            // Cambio el estado del enemigo a seguir.
            actualState = GhostStateMovement.Follow;
        }
    }

    // Función del estado de seguir del enemigo.
    private void FollowState()
    {
        // Obtengo la dirección y muevo al enemigo a esa posición.
        Vector2 direction = (playerTransform.position - transform.position).normalized;
        rb.linearVelocity = direction * speed;
    }
}
