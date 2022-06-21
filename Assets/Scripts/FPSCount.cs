using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCount : MonoBehaviour
{
	private Text txt;

	private int current_frame;
	
	private void Start()
	{
		txt = GetComponent<Text>();
	}
	
	private void Update()
	{
		//mostra o FPS
		current_frame = (int)(1f / Time.unscaledDeltaTime);
		txt.text = "FPS: " + current_frame;
	}
}
