using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    KeyCode buttonUp, buttonDown;

    [SerializeField]
    float speedPlayer = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(buttonDown))
        {
            transform.position += Vector3.down * Time.deltaTime * speedPlayer;
        }
        else if (Input.GetKey(buttonUp))
        {
            transform.position += Vector3.up * Time.deltaTime * speedPlayer;
        }

    }
}
