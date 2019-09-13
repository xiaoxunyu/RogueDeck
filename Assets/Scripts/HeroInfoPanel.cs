using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroInfoPanel : MonoBehaviour
{
    public HeroData hero;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI hp;
    public TextMeshProUGUI range;
    public TextMeshProUGUI spell;
    public TextMeshProUGUI charName;
    public Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        attack.text = hero.Attack.ToString();
        hp.text = hero.HP.ToString();
        range.text = hero.Range.ToString();
        spell.text = hero.Spell1Name;
        image.sprite = hero.Portrait;
        charName.text = hero.Name;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
