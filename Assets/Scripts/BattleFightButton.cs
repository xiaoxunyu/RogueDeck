using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFightButton : MonoBehaviour
{
	public GameObject BattleResultPrefab;
	public GameObject OverallResultPrefab;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
	{
		GameManager.BattleCount++;
        if (GameManager.BattleCount < 3)
    		Instantiate(BattleResultPrefab, GameObject.Find("Canvas").transform);
		else
			Instantiate(OverallResultPrefab, GameObject.Find("Canvas").transform);
	}
}
