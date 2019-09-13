using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapScreenCharacterList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            if (i < GameManager.SelectedHeroList.Count)
            {
                HeroData hero = GameManager.SelectedHeroList[i];
                transform.GetChild(i).GetComponent<Image>().sprite = hero.Portrait;
                transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = hero.Name;
            }
            else
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
