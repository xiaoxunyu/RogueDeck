using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    HeroData hero;
    GameObject checkMark;

    // Start is called before the first frame update
    void Start()
    {
        checkMark = transform.GetChild(1).gameObject;
        checkMark.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHero(HeroData hero)
    {
        this.hero = hero;
        transform.GetChild(0).GetComponent<Text>().text = hero.Name;
    }

    public void OnClick()
    {
        if (checkMark.activeSelf)
        {
            checkMark.SetActive(false);
			GameManager.SelectedHeroList.Remove(hero);
        }
		else
		{
			checkMark.SetActive(true);
			GameManager.SelectedHeroList.Add(hero);
		}
    }
}
