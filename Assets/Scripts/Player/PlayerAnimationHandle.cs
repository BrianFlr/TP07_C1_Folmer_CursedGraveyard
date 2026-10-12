using UnityEngine;

public class PlayerAnimationHandle : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerController;
    [SerializeField] private Animator playerAnimator;
    private Rigidbody2D playerRb;

    private bool isGround;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGround = playerController.GetIsGroundState();

        if (isGround)
        {
            playerAnimator.SetBool("Jump", false);
            playerAnimator.SetBool("Fall", false);
            playerAnimator.SetBool("Ground", isGround);
        }

        if (playerRb.linearVelocityY > 0 && !isGround)
        {
            playerAnimator.SetBool("Jump", true);
            playerAnimator.SetBool("Ground", false);
        }
        else if (playerRb.linearVelocityY < -0.1f && !isGround)
        {
            playerAnimator.SetBool("Jump", false);
            playerAnimator.SetBool("Fall", true);
        }

        if (Mathf.Abs(playerRb.linearVelocityX) > 0 && isGround)
        {
            playerAnimator.SetBool("Run", true);
        }
        else
        {
            playerAnimator.SetBool("Run", false);
        }
    }
}
