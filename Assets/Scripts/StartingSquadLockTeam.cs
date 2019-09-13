using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingSquadLockTeam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.HeroSelected.Count == 3)
            GetComponentInChildren<TextMeshProUGUI>().text = "Lock Team";
        else
            GetComponentInChildren<TextMeshProUGUI>().text = "Selected " + GameManager.HeroSelected.Count + "/3";
    }

    public void OnClick() {
        SceneManager.LoadScene("MapScreen");
    }
}
