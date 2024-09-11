using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMyLilGuy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * -10f);
        } else if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * 10f);
        }
    }
}
