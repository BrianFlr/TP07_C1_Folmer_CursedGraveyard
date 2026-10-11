using System;
using TMPro;
using UnityEngine;

public class UiPlayerPoints : MonoBehaviour
{
    [Header("Canvas Players Points Text")]
    [SerializeField] private TMP_Text textPoints;

    void Update()
    {
        // Muestro los puntos del player
        //textPoints.text = GameManager.Instance.GetPlayerPoints().ToString("0");
    }
}
