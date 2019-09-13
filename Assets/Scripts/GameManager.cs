using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static List<HeroData> HeroLocked = new List<HeroData>();
    public static List<HeroData> HeroUnequipped = new List<HeroData>();
    public static List<HeroData> HeroEquipped = new List<HeroData>();
    public static List<HeroData> HeroSelected = new List<HeroData>();
    public static List<EquipmentData> EquipmentList = new List<EquipmentData>();

    public static int BattleCount = 0;

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

        foreach (Object hero in Resources.LoadAll("HeroData"))
            HeroLocked.Add((HeroData)hero);

        for (int i = 0; i < 8; i++)
        {
            HeroEquipped.Add(HeroLocked[0]);
            HeroLocked.RemoveAt(0);
        }

        foreach (Object equipment in Resources.LoadAll("EquipmentData"))
            EquipmentList.Add((EquipmentData)equipment);
    }

    void Update()
    {
        
    }
}
