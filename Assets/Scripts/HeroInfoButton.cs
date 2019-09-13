using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInfoButton : MonoBehaviour
{
    public GameObject heroInfoPrefab;
    private GameObject myPanel;
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
        if(myPanel == null) {
            myPanel  = Instantiate(heroInfoPrefab, this.transform.position, this.transform.rotation) as GameObject;
            myPanel.transform.SetParent(gameObject.transform.root,false);
            //myPanel.transform.localScale = new Vector3(1, 1, 1);
            myPanel.GetComponentInChildren<HeroInfoPanel>().hero = this.myHero;
        }

    }
}
