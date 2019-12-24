using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapimage : MonoBehaviour
{
    public GameObject mapPanel;

    // Start is called before the first frame update
    void Start()
    {
        mapPanel.SetActive(false);
    }


    // Update is called once per frame
    public void ButtonClicked()
    {
        var to = Instantiate(mapPanel);
        mapPanel.SetActive(true);
        print("panelset");
    }
}
