using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapclose : MonoBehaviour
{
    public GameObject mapPanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void ButtonClicked()
    {
        mapPanel.SetActive(false);
    }
}
