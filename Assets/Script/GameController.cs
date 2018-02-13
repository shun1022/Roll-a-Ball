using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public UnityEngine.UI.Text ScoreLabel;
	// Update is called once per frame
	public void Update () 
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = count.ToString();
	}
}
