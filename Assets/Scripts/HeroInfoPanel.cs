using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class HeroInfoPanel : MonoBehaviour, IPointerDownHandler
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
        transform.position = Vector3.zero;

        Portrait.sprite = hero.Portrait;
        Name.text = hero.Name;
        Attack.text = hero.Attack.ToString();
        Hp.text = hero.HP.ToString();
        Range.text = hero.Range.ToString();
        Spell.text = hero.Spell1Name;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.position = new Vector2(-999, -999);
    }
}
