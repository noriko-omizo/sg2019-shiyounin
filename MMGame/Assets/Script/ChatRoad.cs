using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChatRoad : MonoBehaviour {
	[SerializeField] GameObject chatCanvas;
	[SerializeField] GameObject arCanvas;

	public void ButtonClicked () {
		chatCanvas.SetActive(true);
		arCanvas.SetActive(false);
	}
}

