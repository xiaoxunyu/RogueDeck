using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<HeroData> heroDataList = new List<HeroData>();

    void Start()
    {
        DontDestroyOnLoad(this);

        foreach(Object hero in Resources.LoadAll("HeroData"))
            heroDataList.Add((HeroData)hero);
    }

    void Update()
    {
        
    }
}
