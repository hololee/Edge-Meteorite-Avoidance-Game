using UnityEngine;
using System.Collections;

public class PlayerSprite : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadLevel() {
    // 끝날때 불림.
          Application.LoadLevel("GameOver_scene");

    }

    public void noVelocity() {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>().useful = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
    }
}
