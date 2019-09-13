using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleResult : MonoBehaviour
{
    public TextMeshProUGUI Title;
    public Transform EquipmentList;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in EquipmentList)
        {
            EquipmentData equipment = GameManager.EquipmentList[Random.Range(0, GameManager.EquipmentList.Count)];
            child.GetComponent<Image>().sprite = equipment.Portrait;
            child.GetComponentInChildren<TextMeshProUGUI>().text = equipment.Name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndBattle()
    {
        SceneManager.LoadScene("MapScreen");
    }
}
