using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHeroManager : MonoBehaviour
{

    public Transform EquippedHeroList;
    public Transform UnequippedHeroList;

    public bool IsWaitToSwap;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHeroPool();
        IsWaitToSwap = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHeroPool()
    {
        for(int i = 0; i < EquippedHeroList.childCount; i++)
        {
            EquippedHeroList.GetChild(i).GetComponent<InsideHouseHeroButton>().SetHero(GameManager.HeroEquipped[i], true);
        }

        for (int i = 0; i < UnequippedHeroList.childCount; i++)
        {
            if (i < GameManager.HeroUnequipped.Count)
            {
                UnequippedHeroList.GetChild(i).GetComponent<InsideHouseHeroButton>().SetHero(GameManager.HeroUnequipped[i], false);
            }
            else
            {
                UnequippedHeroList.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void HideContextMenu()
    {
        GameObject contextMenuInfoEquip = GameObject.Find("ContextMenu");
        contextMenuInfoEquip.transform.position = new Vector2(-999, -999);
        IsWaitToSwap = false;
    }

    public void OnClickEquip()
    {
        IsWaitToSwap = true;
    }

    public void OnClickHeroToSwap(int index)
    {
        HeroData heroToRetire = GameManager.HeroEquipped[index];
        GameManager.HeroEquipped.Remove(heroToRetire);
        GameManager.HeroEquipped.Insert(index, GameObject.Find("ContextMenu").GetComponentInChildren<HeroInfoButton>().myHero);
        GameManager.HeroUnequipped.Remove(GameObject.Find("ContextMenu").GetComponentInChildren<HeroInfoButton>().myHero);
        GameManager.HeroUnequipped.Add(heroToRetire);
        UpdateHeroPool();
    }
}
