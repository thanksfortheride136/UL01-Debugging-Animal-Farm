using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greeting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello there, I am a " + this.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
