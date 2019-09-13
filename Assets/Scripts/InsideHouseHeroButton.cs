using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsideHouseHeroButton : MonoBehaviour
{
    public bool IsEquipped;
    private Image buttonImage;
    HeroData hero;
    
    // Start is called before the first frame update
    void Start()
    {
        buttonImage = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        GameObject contextMenuInfo = GameObject.Find("ContextMenuInfo");
        contextMenuInfo.transform.position = new Vector2(-999, -999);
        GameObject contextMenuInfoEquip = GameObject.Find("ContextMenuInfoEquip");
        contextMenuInfoEquip.transform.position = new Vector2(-999, -999);
        if (IsEquipped) {
            contextMenuInfo.transform.position = transform.position;
            contextMenuInfo.GetComponentInChildren<HeroInfoButton>().myHero = hero; 
        } else
        {
            contextMenuInfoEquip.transform.position = transform.position;
            contextMenuInfoEquip.GetComponentInChildren<HeroInfoButton>().myHero = hero;
        }
    }

    public void SetHero(HeroData hero, bool isEquipped)
    {
        this.hero = hero;
        buttonImage.sprite = hero.Portrait;
        IsEquipped = isEquipped;
    }
}
