using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Mushimegane : MonoBehaviour
{
    [SerializeField] GameObject chatCanvas;
    [SerializeField] GameObject arCanvas;
    [SerializeField] Player player;



    public void ButtonClicked()
    {
        if (player.aruse)
        {
            chatCanvas.SetActive(false);
            arCanvas.SetActive(true);
        }

    }
}
