using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//houd positie bij om naartoe te bewegen;
public class WayPoint : MonoBehaviour
{

    public Vector3 getPosition()
    {
        return transform.position;
    }
}
