using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    [SerializeField]
    private int id;

    int x;

    // Start is called before the first frame update
    void Start()
    {
        id = 3;
        x = 1;
        Debug.Log(id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
