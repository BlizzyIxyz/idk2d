using UnityEngine;

[CreateAssetMenu(menuName = "Configs/Health")]
public class HealthConfig : ScriptableObject
{
    [Min(1), SerializeField] public readonly int CharacterMaxHealth;
}
