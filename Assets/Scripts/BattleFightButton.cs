using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFightButton : MonoBehaviour
{
    public GameObject BattleResultPrefab;

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
        Instantiate(BattleResultPrefab, GameObject.Find("Canvas").transform);
    }
}
