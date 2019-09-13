
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "ScriptableObjects/Equipment", order = 1)]
public class EquipmentData : ScriptableObject
{
    public string Name;
    public Sprite Portrait;

    public int HP;
    public int Attack;
    public int Range;
    public string Spell1Name;
}
