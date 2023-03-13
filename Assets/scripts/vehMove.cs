using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehMove : MonoBehaviour
{
    public float fSpeed = 25f, stSpeed = 7.5f, hSpeed = 5f;
    private float actFSpeed, actStSpeed, actHSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        actFSpeed = Input.GetAxisRaw("Vertical") * fSpeed;
        actStSpeed = Input.GetAxisRaw("Horizontal") * stSpeed;
        actHSpeed = Input.GetAxisRaw("Hover") * hSpeed;

        transform.position += transform.forward * actFSpeed * Time.deltaTime;
        transform.position += (transform.right * actStSpeed * Time.deltaTime) + (transform.up * actHSpeed * Time.deltaTime);

    }
}
