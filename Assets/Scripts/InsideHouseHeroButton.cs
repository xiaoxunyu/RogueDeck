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
        GameObject contextMenu = GameObject.Find("ContextMenu");
        contextMenu.transform.position = new Vector2(-999, -999);

        if (GameObject.Find("Canvas").GetComponent<HouseHeroManager>().IsWaitToSwap)
        {
            if (IsEquipped)
                GameObject.Find("Canvas").GetComponent<HouseHeroManager>().OnClickHeroToSwap(transform.GetSiblingIndex());
            return;
        }

        if (IsEquipped)
        { 
            GameObject.Find("HeroInfo").GetComponent<HeroInfoPanel>().SetHero(hero);
        }
        else
        {
            contextMenu.transform.position = transform.position;
            contextMenu.GetComponentInChildren<HeroInfoButton>().myHero = hero;
            contextMenu.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = true;
        }
    }

    public void SetHero(HeroData hero, bool isEquipped)
    {
        this.hero = hero;
        buttonImage.sprite = hero.Portrait;
        IsEquipped = isEquipped;
    }
}
