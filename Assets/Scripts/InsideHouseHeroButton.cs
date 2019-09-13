using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsideHouseHeroButton : MonoBehaviour
{
    public bool IsEquipped;

    HouseHeroManager manager;
    Image buttonImage;
    HeroData hero;
    
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Canvas").GetComponent<HouseHeroManager>();
        buttonImage = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (manager.IsWaitToSwap)
        {
            manager.IsWaitToSwap = false;
            if (IsEquipped)
            {
                manager.OnClickHeroToSwap(transform.GetSiblingIndex());
            }

            manager.HideContextMenu();
            return;
        }

        manager.HideContextMenu();
        if (IsEquipped)
        { 
            GameObject.Find("HeroInfo").GetComponent<HeroInfoPanel>().SetHero(hero);
        }
        else
        {
            GameObject contextMenu = GameObject.Find("ContextMenu");
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
