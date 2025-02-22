using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Movement")]
public class MovementConfig : ScriptableObject
{
    [Header("����� �������� ��������� � ���")]
    [SerializeField] public float MovementSpeed;
    [SerializeField] public float JumpForce;

    [Space]
    [Header("������")]
    [Tooltip("����� ������ ������.")]
    [SerializeField] public float JumpBufferTime;
    [Tooltip("����� ������ ��� ������, ����������� ����� ���� ��� �������� �������� �������� �����.")]
    [SerializeField] public float JumpCoyoteTime;
}
