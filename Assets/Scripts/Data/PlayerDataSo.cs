using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Game/PlayerData")]

public class PlayerDataSo : ScriptableObject
{
    [Header("Controls")]
    public KeyCode jump = KeyCode.Space;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;
    public MouseButton throwDagger = MouseButton.Left;

    [Header("Stats")]
    [Range (1,150)]public int health = 100;
    [Range(3, 10)] public float speed = 4f;
    [Range(3, 10)] public float jumpForce = 8f;
}
