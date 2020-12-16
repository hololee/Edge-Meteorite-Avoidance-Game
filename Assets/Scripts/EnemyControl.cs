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
        this.enemyRigid.velocity = new Vector2(Mathf.Clamp(enemyRigid.velocity.x, MinSpeedX, MaxSpeedX),
                                           Mathf.Clamp(enemyRigid.velocity.y, MinSpeedY, MaxSpeedY));

        //화면 밖으로 나갈때 대칭인 위치에서 다시 생성.
        
        Respone();




    }


    public void calculateDir() {

        EnemyDir = new Vector2(initPlayerPosition.x - transform.position.x,
                                       initPlayerPosition.y - transform.position.y);

       
        //Debug.Log("EnemyDir : " + EnemyDir);
    }

    private void Respone() {
        //범위 밖으로 나가면.
       if(this.transform.position.x > 3.5f || this.transform.position.x <-3.5f|| this.transform.position.y > 5.5f|| this.transform.position.y < -5.5f) {

            if (Random.Range(0.0f, 6.0f) > 3.0f)
            {

                if (Random.Range(0.0f, 3.0f) > 1.5f)
                {
                    GameObject responedEnemy = Instantiate(Enemy01, new Vector3(2.9f, Random.Range(-4.9f, 4.9f), 0.0f), Quaternion.identity) as GameObject;
                    responedEnemy.name = "Enemy01";
                    Destroy(gameObject);
                    
                }
                else {
                    GameObject responedEnemy = Instantiate(Enemy01, new Vector3(-2.9f, Random.Range(-4.9f, 4.9f), 0.0f), Quaternion.identity) as GameObject;
                    responedEnemy.name = "Enemy01";
                    Destroy(this.gameObject);
                    
                }
            }
            else {
                if (Random.Range(0.0f, 3.0f) > 1.5f)
                {
                    GameObject responedEnemy = Instantiate(Enemy01, new Vector3(Random.Range(-2.9f, 2.9f), 4.9f, 0.0f), Quaternion.identity) as GameObject;
                    responedEnemy.name = "Enemy01";
                    Destroy(this.gameObject);
                   
                }
                else {
                    GameObject responedEnemy = Instantiate(Enemy01, new Vector3(Random.Range(-2.9f, 2.9f), -4.9f, 0.0f), Quaternion.identity) as GameObject;
                    responedEnemy.name = "Enemy01";
                    Destroy(this.gameObject);
                   
                }
            }
          }

    }
}
