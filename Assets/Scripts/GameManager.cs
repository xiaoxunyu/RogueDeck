using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<HeroData> heroDataList = new List<HeroData>();

    void Start()
    {
        DontDestroyOnLoad(this);

        heroDataList.Add((HeroData)Resources.Load("Sniper"));
        print(heroDataList[0].Range);
    }

    void Update()
    {
        
    }
}
