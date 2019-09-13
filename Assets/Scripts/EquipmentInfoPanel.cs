using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipmentInfoPanel : MonoBehaviour {

    public EquipmentData equip;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI hp;
    public TextMeshProUGUI range;
    public TextMeshProUGUI spell;
    public Image image;

    // Start is called before the first frame update
    void Start() {

        attack.text = equip.Attack.ToString();
        hp.text = equip.HP.ToString();
        range.text = equip.Range.ToString();
        spell.text = equip.Spell1Name;
        image.sprite = equip.Portrait;
    }

    // Update is called once per frame
    void Update() {

    }
}

