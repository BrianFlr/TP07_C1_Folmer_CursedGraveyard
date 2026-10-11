using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Game/PlayerData")]

public class PlayerDataSo : ScriptableObject
{
    public KeyCode jump = KeyCode.Space;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;
    [Range (1,5)]public int health = 1;
    [Range(3, 10)] public float speed = 4f;
    [Range(8, 10)] public float jumpForce = 9.5f;
}
