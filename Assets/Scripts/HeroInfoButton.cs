﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInfoButton : MonoBehaviour
{
    public HeroData myHero;
    
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {
        GameObject infoPanel = GameObject.Find("HeroInfo");
        infoPanel.GetComponentInChildren<HeroInfoPanel>().SetHero(myHero);
    }
}
