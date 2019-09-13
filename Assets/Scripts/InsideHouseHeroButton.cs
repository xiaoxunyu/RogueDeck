using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsideHouseHeroButton : MonoBehaviour
{
    public HeroData hero;
    public GameObject contextMenu;
    private Image buttonImage;

    private GameObject contextPrefab = null;
    
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

    public void OnClick() {
        Debug.Log("outside");
        if (contextPrefab == null) {
            Debug.Log("got here");
            contextPrefab = Instantiate(contextMenu, this.transform.position, this.transform.rotation) as GameObject;
            contextPrefab.transform.parent = gameObject.transform;
            contextPrefab.transform.localScale = new Vector3(1, 1, 1);
            contextPrefab.transform.localPosition= new Vector3(2, -130, 0);
        }
    }
}
