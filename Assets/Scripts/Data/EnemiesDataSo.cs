using UnityEngine;

[CreateAssetMenu(fileName = "EnemiesData", menuName = "Data/Game/EnemiesData")]

public class EnemiesDataSo : ScriptableObject
{
    [Header("Skeleton")]
    [Range(1, 150)] public int skeletonHealth = 20;
    [Range(3, 10)] public float skeletonSpeed = 2f;

    [Header("Ghost")]
    [Range(1, 150)] public int ghostHealth = 30;
}
