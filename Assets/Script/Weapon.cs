using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToViewportPoint(Input.mousePosition) - transform.position;
        //float rotZ = Mathf.Atan2(difference.y,difference.x)*
    }
}
