using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChatRoad : MonoBehaviour {

	public void ButtonClicked () {
		SceneManager.LoadScene("Chattest");
	}
}

