using UnityEngine;
using System.Collections;

public class GameOverText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        
        
        this.GetComponent<TextMesh>().text = "Score : " + GameScore.score;

    }
}
