using UnityEngine;
using System.Collections;

public class GameContrl : MonoBehaviour {

    [System.NonSerialized]
    public float playTime;
    GameObject ScoreView;
    public GameObject Enemy1;

	// Use this for initialization
	void Start () {

        playTime = 0.0f;
        ScoreView = GameObject.Find("Score");


        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f,-0.5f),Random.Range(-3.0f,-1.0f),0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(-3.0f, -1.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(-2.0f, -0.5f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);
        Instantiate(Enemy1, new Vector3(Random.Range(0.5f, 2.0f), Random.Range(1.0f, 3.0f), 0.0f), Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update () {


        playTime += Time.deltaTime;
        ScoreView.GetComponent<TextMesh>().text = "Time : "+ playTime.ToString("F2");

       
       GameScore.score = playTime.ToString("F2");

    }

   
}
