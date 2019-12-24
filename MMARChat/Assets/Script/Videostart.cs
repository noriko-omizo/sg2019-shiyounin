using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class Videostart : MonoBehaviour {

	public VideoPlayer videoPlayer;
	[SerializeField] InputField input;
	[SerializeField] GameObject videoCanvas;
	public bool startvideo;

	void start (){
		
		videoCanvas.SetActive(false);

	}

	public void ButtonClicked()
	{
		videoPlayer = GetComponent<VideoPlayer>();

		string userText = input.text;

		if(userText == ("あいことば")) {
			videoCanvas.SetActive(true);
			videoPlayer.Play();
			print("aaaa");
			startvideo = true;

		}
	}
}
