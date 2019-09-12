using UnityEngine;

[CreateAssetMenu(fileName = "Hero", menuName = "ScriptableObjects/Hero", order = 1)]
public class HeroData : ScriptableObject
{
    public string Name;
    public Sprite Portrait;

    public int HP;
    public int Attack;
    public int Range;
    public string Spell1Name;
}