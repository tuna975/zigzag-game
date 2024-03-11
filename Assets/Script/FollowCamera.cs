using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;


    void Awake()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        transform.position = offset + target.position;
    }


}
