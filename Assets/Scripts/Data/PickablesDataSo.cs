using UnityEngine;

[CreateAssetMenu(fileName = "PickablesData", menuName = "Data/Game/PickablesData")]

public class PickablesDataSo : ScriptableObject
{
    [Header("Pickable Points")]
    [Range(1, 10)] public float pointsToAdd = 5.0f;

    [Header("Pickable Health")]
    [Range(1, 10)] public float healthToAdd = 10.0f;

    [Header("Pickable Damage Attack")]
    [Range(1, 10)] public float damageToAdd = 10.0f;

}
