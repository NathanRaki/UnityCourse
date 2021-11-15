using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [SerializeField]
    private Vector3 Movement = new Vector3(0, 0, 1);

    [SerializeField]
    private float Speed = 0f;

    [SerializeField]
    private float TurnRate = 45f;

    private Vector3 PrevPos;
    private Vector3 NewPos;

    public Vector3 Velocity;

    // Start is called before the first frame update
    void Start()
    {
        PrevPos = transform.position;
        NewPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Offset = Vector3.zero;
        Vector3 Rotate = new Vector3(0, Time.deltaTime * TurnRate, 0);

        // Forward - Backward
        if (Input.GetKey(KeyCode.Z))
        {
            Speed += 0.01f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Speed -= 0.01f;
        }

        Offset += gameObject.transform.forward * Time.deltaTime * Speed;

        // Updating the position
        gameObject.transform.position += Offset;

        // Rotate Left - Right
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(-Rotate);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(Rotate);
        }

        NewPos = transform.position;
        Velocity = (NewPos - PrevPos) / Time.deltaTime;
        PrevPos = NewPos;
    }
}
