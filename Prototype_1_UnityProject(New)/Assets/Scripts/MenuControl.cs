using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public GameObject howToPlay; // How to play text;
    public GameObject play; // Play text;
    Vector3 mouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse = GetMousePoint();

        if (mouse.y > -1f && mouse.y < 1f)
        {
            if (mouse.x < 0)
            {
                play.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
                howToPlay.GetComponent<Text>().color = new Color32(241, 241, 241, 0);
            }
                
          
            else
            {
                play.GetComponent<Text>().color = new Color32(241, 241, 241, 0);
                howToPlay.GetComponent<Text>().color = new Color32(241, 241, 241, 255);
            }
                
        }
        else
        {
            howToPlay.GetComponent<Text>().color = new Color32(241, 241, 241, 0);
            play.GetComponent<Text>().color = new Color32(241, 241, 241, 0);
        }

    }
            
          
    Vector3 GetMousePoint() //Get and return the mouse point
    {
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        point.z = 0;
        //print(point);

        return point;
    }

}
