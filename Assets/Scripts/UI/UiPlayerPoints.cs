using TMPro;
using UnityEngine;

public class UiPlayerPoints : MonoBehaviour
{
    [Header("Canvas Player Points Text")]
    [SerializeField] private TMP_Text textPoints;

    private void Awake()
    {
        GameManager.Instance.onPlayerPointsChange += ShowPlayerPoints;
    }

    private void OnDestroy()
    {
        GameManager.Instance.onPlayerPointsChange -= ShowPlayerPoints;
    }

    private void ShowPlayerPoints()
    {
        Debug.Log("Me ejecuté");

        // Muestro los puntos del player
        textPoints.text = GameManager.Instance.GetPlayerPoints().ToString("0");
    }
}
