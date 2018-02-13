using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public UnityEngine.UI.Text ScoreLabel;
    public GameObject WinnerLabelObject;
	// Update is called once per frame
	public void Update () 
    {
        int Count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = Count.ToString();
        if (Count == 0)
        {
            WinnerLabelObject.SetActive(true);
        }
	}
}
