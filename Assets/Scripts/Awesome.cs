using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Awesome : MonoBehaviour
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
        GameManager.HeroUnequipped.Add(GameManager.HeroLocked[0]);
        GameManager.HeroLocked.RemoveAt(0);
        SceneManager.LoadScene("HomeScreen");
    }
}
