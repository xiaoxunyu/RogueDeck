using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectManager : MonoBehaviour
{
    public Button LockTeamButton;
	List<HeroData> listToPick;

	// Start is called before the first frame update
	void Start()
    {
		listToPick = new List<HeroData>(GameManager.HeroDataList);

		for (int i = 0; i < 4; i++)
        {
            PickAHero(i);
        }
    }

    void PickAHero(int index)
    {
		int heroIndex = Random.Range(0, listToPick.Count);
		HeroData hero = listToPick[heroIndex];
		listToPick.RemoveAt(heroIndex);
		transform.GetChild(index).GetComponent<CharacterSelector>().SetHero(hero);
    }

    // Update is called once per frame
    void Update()
    {
        LockTeamButton.interactable = GameManager.SelectedHeroList.Count == 3;
    }
}
