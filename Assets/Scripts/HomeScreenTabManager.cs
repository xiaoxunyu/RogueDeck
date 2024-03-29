﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreenTabManager : MonoBehaviour
{
    public Transform CityScreen;
    public Transform BattleScreen;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.UnlockCity)
            transform.GetChild(0).GetComponent<Button>().interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickCity()
    {
        BattleScreen.gameObject.SetActive(false);
        CityScreen.gameObject.SetActive(true);
        CityScreen.localPosition = Vector3.zero;
    }

    public void OnClickBattle()
    {
        CityScreen.gameObject.SetActive(false);
        BattleScreen.gameObject.SetActive(true);
    }
}
