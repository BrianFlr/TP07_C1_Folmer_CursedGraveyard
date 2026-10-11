using Unity.VisualScripting;
using UnityEngine;

public class PlayerAnimationHandle : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Animator playerAnimator;

    private void Awake()
    {
        playerController.onPlayerMove += PlayAnimationRun;
        playerController.onPlayerJump += PlayAnimationJump;
    }

    void Update()
    {
        //if (isGround)
        //{
        //    animator.SetBool("Jump", false);
        //    animator.SetBool("Fall", false);
        //    animator.SetBool("Ground", isGround);
        //}

        //if (rb.linearVelocityY > 0 && !isGround)
        //{
        //    animator.SetBool("Jump", true);
        //    animator.SetBool("Ground", false);
        //}
        //else if (rb.linearVelocityY < -0.1f && !isGround)
        //{
        //    animator.SetBool("Jump", false);
        //    animator.SetBool("Fall", true);
        //}    
    }

    private void OnDestroy()
    {
        playerController.onPlayerMove -= PlayAnimationRun;
        playerController.onPlayerJump -= PlayAnimationJump;
    }

    private void PlayAnimationRun()
    {
        playerAnimator.SetTrigger("Move");
    }

    private void PlayAnimationJump()
    {
        playerAnimator.SetBool("Jump", true);
    }

    private void PlayAnimationAttack()
    {

    }
}
