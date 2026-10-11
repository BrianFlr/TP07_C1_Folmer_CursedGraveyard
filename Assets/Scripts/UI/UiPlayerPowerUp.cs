using System;
using TMPro;
using UnityEngine;

public class UiPlayerPowerUp : MonoBehaviour
{
    [SerializeField] private GameObject panelPowerUp;
    [SerializeField] private TMP_Text textTimePowerUp;

    private float powerUpSeconds = 0f;

    private void Update()
    {
        /*if (GameManager.Instance.GetShieldPowerUpState())
        {
            panelPowerUp.SetActive(true);
        }
        else
        {
            panelPowerUp.SetActive(false);
        }

        // Muestro el tiempo activo de los power ups
        powerUpSeconds = GameManager.Instance.GetPowerUpTimer();*/
        TimeSpan timePowerUp = TimeSpan.FromSeconds(powerUpSeconds);
        textTimePowerUp.text = timePowerUp.ToString(@"mm\:ss");
    }
}
