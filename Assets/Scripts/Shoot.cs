using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    private int ctr = 0;

    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Disparar();
        }
    }

    void Disparar() {
        
        GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo, Mathf.Infinity) && hitInfo.collider.gameObject.tag == "Target")
        {
            ctr++;
            Debug.Log("Contador de monedas: " + ctr);
            score.text = "Score: " + ctr;
            Destroy(hitInfo.collider.gameObject);
        }
    }
}
