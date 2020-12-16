using UnityEngine;
using System.Collections;





public class PlayerControl : MonoBehaviour
{


    public float Player_Speed;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public bool useful;

    Vector3 post;
    Vector3 worldpos;
    float difX;
    float difY;
    private Rigidbody2D myrigid;

    int flag;

    // Use this for initialization
    void Start()
    {

        myrigid = GetComponent<Rigidbody2D>();
        useful = true;



    }

    // Update is called once per frame
    void Update()
    {
        if (useful)
        {

            if (Input.touchCount > 0)
            {

                if (Input.GetMouseButtonDown(0))
                {
                    post = Input.GetTouch(0).position;
                    worldpos = Camera.main.ScreenToWorldPoint(post);

                    difX = this.transform.position.x - worldpos.x;
                    difY = this.transform.position.y - worldpos.y;
                }
                if (Input.GetMouseButton(0))
                {
                    post = Input.GetTouch(0).position;
                    worldpos = Camera.main.ScreenToWorldPoint(post);

                    Debug.Log("difX : " + difX + "   difY : " + difY);


                    this.transform.position = new Vector2(worldpos.x + difX, worldpos.y + difY);
                }
            }
        }
    }

    void FixedUpdate()
    {
        if (useful)
        {


            if (Input.GetAxis("Horizontal") != 0.0f)
            {
                myrigid.velocity = new Vector2(Input.GetAxis("Horizontal") * Player_Speed, myrigid.velocity.y);
            }
            if (Input.GetAxis("Vertical") != 0.0f)
            {
                myrigid.velocity = new Vector2(myrigid.velocity.x, Input.GetAxis("Vertical") * Player_Speed);
            }



        }

        //활동 영역 제한
        myrigid.position = new Vector3(Mathf.Clamp(myrigid.position.x, minX, maxX), Mathf.Clamp(myrigid.position.y, minY, maxY), 0.0f);




    }

    public Vector2 getPlayerPosition()
    {

        return new Vector2(this.transform.position.x, this.transform.position.y);

    }
}
