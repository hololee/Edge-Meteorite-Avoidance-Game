using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    PlayerControl playerCtrl;
    Vector2 initPlayerPosition;
    Rigidbody2D enemyRigid;

    public GameObject Enemy01;

    public float MaxSpeedX;
    public float MaxSpeedY;
    public float MinSpeedX;
    public float MinSpeedY;

   private  Vector2 EnemyDir;

    // Use this for initialization
    void Start () {
        enemyRigid = GetComponent<Rigidbody2D>();

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerCtrl = player.GetComponent<PlayerControl>();
        initPlayerPosition = playerCtrl.getPlayerPosition();
        this.calculateDir();
    }
	
	// Update is called once per frame
	void Update () {
        

    }

    void FixedUpdate() {
        this.enemyRigid.velocity = EnemyDir;
        this.enemy