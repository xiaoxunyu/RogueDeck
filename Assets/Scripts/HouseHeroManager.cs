using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseHeroManager : MonoBehaviour
{

    public Transform EquippedHeroList;
    public Transform UnequippedHeroList;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHeroPool();
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
}
