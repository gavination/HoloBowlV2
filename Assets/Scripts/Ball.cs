using UnityEngine;
using System.Collections;
using HoloToolkit.Unity.InputModule;
using System;

public class Ball : MonoBehaviour, IFocusable, IInputClickHandler
{

    public Vector3 TapForce = new Vector3(0f, 3f, 600f);
    new Rigidbody rigidbody;

    private bool gazing = false;


    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
       

        if (rigidbody == null)
        {
            rigidbody = gameObject.AddComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gazing == false) return;

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        rigidbody.AddForce(TapForce);
     

    }

    public void OnFocusEnter()
    {
        gazing = true;    }

    public void OnFocusExit()
    {
        gazing = false;
    }
}
