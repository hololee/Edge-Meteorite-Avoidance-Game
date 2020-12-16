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
    private Rig