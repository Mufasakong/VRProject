using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnim : MonoBehaviour
{
    public InputActionProperty pointAnim;
    public InputActionProperty grabAnim;
    // Start is called before the first frame update

    public Animator handAnim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pointValue = pointAnim.action.ReadValue<float>();
        handAnim.SetFloat("Point", pointValue);

        float grabValue = grabAnim.action.ReadValue<float>();
        handAnim.SetFloat("Grab", grabValue);
    }
}
