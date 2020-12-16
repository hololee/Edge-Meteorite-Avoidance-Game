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
                    difY = this.tran