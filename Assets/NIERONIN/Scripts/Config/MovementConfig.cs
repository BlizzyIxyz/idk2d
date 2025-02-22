using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Movement")]
public class MovementConfig : ScriptableObject
{
    [Header("Общие значения скоростей и сил")]
    [SerializeField] public float MovementSpeed;
    [SerializeField] public float JumpForce;

    [Space]
    [Header("Буферы")]
    [Tooltip("Время буфера прыжка.")]
    [SerializeField] public float JumpBufferTime;
    [Tooltip("Время койота для прыжка, срабатывает после того как персонаж перестал косаться земли.")]
    [SerializeField] public float JumpCoyoteTime;
}
