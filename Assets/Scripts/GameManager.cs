using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<HeroData> HeroDataList = new List<HeroData>();
    public static List<HeroData> SelectedHeroList = new List<HeroData>();

    void Start()
    {
        DontDestroyOnLoad(this);

        foreach(Object hero in Resources.LoadAll("HeroData"))
            HeroDataList.Add((HeroData)hero);
    }

    void Update()
    {
        
    }
}
