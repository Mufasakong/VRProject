using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject cup;
    private Renderer cupMat;

    void Start()
    {
            cupMat = cup.GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Renderer ballMat = other.GetComponent<Renderer>();

            if (ballMat != null && cupMat != null)
            {
                cupMat.material.color = ballMat.material.color;
            }

            Destroy(other.gameObject);
        }
    }
}
