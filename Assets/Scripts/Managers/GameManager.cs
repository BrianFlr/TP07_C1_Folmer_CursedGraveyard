using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public event Action onPlayerPointsChange;
    public event Action onGameWin;
    public event Action onGameOver;

    [SerializeField] private PlayerHealth playerHealth;
    //[SerializeField] private DaggerProjectile daggerProjectile;
    [SerializeField] private Transform skeletonParentTransform;
    [SerializeField] private Transform ghostParentTransform;

    private float playerPoints = 0;
    private int collectableCounter = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playerHealth.onPlayerHealthChange += GameOver;
    }

    private void OnDestroy()
    {
        playerHealth.onPlayerHealthChange -= GameOver;
    }

    private void GameWin()
    {
        if(collectableCounter == 3 && GetActiveChildrenSkeleton() == 0 && GetActiveChildrenGhost() == 0)
        {
            onGameWin?.Invoke();
        }
    }

    private void GameOver()
    {
        if (playerHealth.GetHealthValue() < 1)
        {
            onGameOver?.Invoke();
        }
    }

    public void AddPlayerPoints(float pointsAmount)
    {
        playerPoints += pointsAmount;

        onPlayerPointsChange?.Invoke();
    }

    public float GetPlayerPoints()
    {
        return playerPoints;
    }

    private int GetActiveChildrenSkeleton()
    {
        int skeletonCount = 0;

        foreach (Transform child in skeletonParentTransform)
        {
            skeletonCount++;
        }

        return skeletonCount;
    }

    private int GetActiveChildrenGhost()
    {
        int ghostCount = 0;

        foreach (Transform child in ghostParentTransform)
        {
            ghostCount++;
        }

        return ghostCount;
    }
}
