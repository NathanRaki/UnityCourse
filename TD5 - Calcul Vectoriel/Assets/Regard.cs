using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regard : MonoBehaviour
{
    [SerializeField]
    private Transform Target;

    [SerializeField]
    private float Distance = 10f;

    private Vector3 Direction;
    // Start is called before the first frame update
    void Start()
    {
        if (Target)
        {
            transform.LookAt(Target);
            Direction = (Target.position - transform.position).normalized;
            transform.position = Target.position + Direction * Distance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Target);
        transform.position = Target.position - Direction * Distance;
    }
}
