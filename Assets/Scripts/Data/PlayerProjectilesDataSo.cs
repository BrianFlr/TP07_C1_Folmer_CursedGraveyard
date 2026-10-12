using UnityEngine;

[CreateAssetMenu(fileName = "PlayerProjectilesData", menuName = "Data/Game/PlayerProjectilesData")]

public class PlayerProjectilesDataSo : ScriptableObject
{
    [Header("Dagger")]
    [Range(1, 10)] public float daggerSpeed = 4.0f;
    [Range(10, 100)] public float daggerDamage = 10.0f;
    [Range(1, 5)] public float daggerLifeTime = 2.0f;
    [Range(1, 5)] public float daggerThrowRate = 0.8f;
}
