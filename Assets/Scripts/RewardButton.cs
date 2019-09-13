using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardButton : MonoBehaviour
{
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
        foreach(Transform child in transform.parent)
            child.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(!transform.GetChild(1).gameObject.activeSelf);
        GameObject.Find("ConfirmButton").GetComponent<Button>().interactable = true;
    }
}
