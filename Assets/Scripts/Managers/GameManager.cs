using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public event Action onPlayerPointsChange;
    public event Action onCollectablePicked;
    public event Action onGameWin;
    public event Action onGameOver;

    [SerializeField] private PlayerHealth playerHealth;
    //[SerializeField] private DaggerProjectile daggerProjectile;

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
        onCollectablePicked += GameWin;
    }

    private void OnDestroy()
    {
        playerHealth.onPlayerHealthChange -= GameOver;
        onCollectablePicked -= GameWin;
    }

    public void SetCollectablePickedCounter()
    {
        collectableCounter++;

        onCollectablePicked?.Invoke();
    }

    private void GameWin()
    {
        if(collectableCounter == 3)
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
}
