using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroInfoPanel : MonoBehaviour
{
    public Image Portrait;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Attack;
    public TextMeshProUGUI Hp;
    public TextMeshProUGUI Range;
    public TextMeshProUGUI Spell;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHero(HeroData hero)
    {
        Portrait.sprite = hero.Portrait;
        Name.text = hero.Name;
        Attack.text = hero.Attack.ToString();
        Hp.text = hero.HP.ToString();
        Range.text = hero.Range.ToString();
        Spell.text = hero.Spell1Name;
    }
}
