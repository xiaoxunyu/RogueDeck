using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<HeroData> HeroUnequipped = new List<HeroData>();
    public static List<HeroData> HeroEquipped = new List<HeroData>();
    public static List<HeroData> HeroSelected = new List<HeroData>();

    static bool inited = false;

    void Start()
    {
        if (inited)
        {
            Destroy(this);
            return;
        }

        inited = true;
        DontDestroyOnLoad(this);

        foreach(Object hero in Resources.LoadAll("HeroData"))
            HeroUnequipped.Add((HeroData)hero);

        for(int i = 0; i < 8; i++)
        {
            HeroEquipped.Add(HeroUnequipped[0]);
            HeroUnequipped.RemoveAt(0);
        }
    }

    void Update()
    {
        
    }
}
