using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color startColor;
    public Color hoverColor;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.SetColor("_Color", hoverColor);
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.SetColor("_Color", startColor);

    }

    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        Physics.Raycast(myRay, out hitInfo);
        rb.AddForce(-hitInfo.normal * 10, ForceMode.Impulse);
        rb.useGravity = true;
    }
}
