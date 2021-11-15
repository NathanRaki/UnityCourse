using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 3f * Time.deltaTime;
        transform.Rotate(0, 45f * Time.deltaTime, 0);
    }
}
