using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreenTowerList : MonoBehaviour
{
	int currentSelection = 0;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.GetChild(1).position.x - transform.GetChild(0).position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scroll(bool toLeft){
		if (toLeft)
        {
            if (currentSelection < transform.childCount - 1)
            {
                currentSelection++;
                transform.position -= new Vector3(distance, 0);
            }
        }
        else
        {
            if (currentSelection > 0)
            {
                currentSelection--;
                transform.position += new Vector3(distance, 0);
            }
        }
    }
}
