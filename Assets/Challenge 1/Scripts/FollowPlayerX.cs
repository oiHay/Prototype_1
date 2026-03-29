using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] private GameObject _plane;
    
    private Vector3 _offset = new(0,4,-11);
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _plane.transform.position + _offset;
    }
}
