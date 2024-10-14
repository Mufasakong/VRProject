using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    private Vector3 ballPos;
    private Quaternion ballRot;
    
    void Start() {
        ballPos = transform.position;
        ballRot = transform.rotation;

    }
    public void SpawningBall()
    {
        Instantiate(gameObject, ballPos, ballRot);
    }
}
