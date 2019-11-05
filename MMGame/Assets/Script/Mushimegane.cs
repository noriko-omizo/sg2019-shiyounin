using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Mushimegane : MonoBehaviour {

	public void ButtonClicked () {
		SceneManager.LoadScene("ARScene");
	}
}
