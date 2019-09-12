using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectManager : MonoBehaviour
{
	List<HeroData> listToPick;

	// Start is called before the first frame update
	void Start()
    {
		listToPick = new List<HeroData>(GameManager.heroDataList);

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
		print(hero.Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
