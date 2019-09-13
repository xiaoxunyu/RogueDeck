using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapIconList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < GameManager.BattleCount; i++)
            transform.GetChild(i + 1).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
