using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsideHouseHeroButton : MonoBehaviour
{
    public HeroData hero;
    private Image buttonImage;
    
    // Start is called before the first frame update
    void Start()
    {
        buttonImage = gameObject.GetComponent<Image>();
        if (hero != null) {
            buttonImage.sprite = hero.Portrait;
        } else {
            gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
