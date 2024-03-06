using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerMoving : MonoBehaviour
{
    public GameObject player;
    public float propellerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(propellerSpeed * Time.deltaTime * Vector3.forward);
    }
}
