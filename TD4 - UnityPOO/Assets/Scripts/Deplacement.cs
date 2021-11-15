using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    [SerializeField]
    private Vector3 Movement = new Vector3(0, 0, 1);

    [SerializeField]
    private float Speed = 2f;

    private Moteur Engine;

    // Wheels Transforms
    private Transform LeftFrontWheel;
    private Transform RightFrontWheel;
    private Transform LeftBackWheel;
    private Transform RightBackWheel;

    // Start is called before the first frame update
    void Start()
    {
        Engine = new Moteur();
        // Getting Wheels Transforms by Name
        LeftFrontWheel = gameObject.transform.Find("Wheel_fl");
        RightFrontWheel = gameObject.transform.Find("Wheel_fr");
        LeftBackWheel = gameObject.transform.Find("Wheel_rl");
        RightBackWheel = gameObject.transform.Find("Wheel_rr");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Offset = Vector3.zero;
        Vector3 Rotate = new Vector3(0, Time.deltaTime * Speed, 0);

        // Resetting Front Wheels Rotation
        LeftFrontWheel.rotation = gameObject.transform.rotation;
        RightFrontWheel.rotation = gameObject.transform.rotation;

        // Forward - Backward
        if (Input.GetKey(KeyCode.Z))
        {
            if (Engine.Roule(0.1f))
            {
                Offset += gameObject.transform.forward * Time.deltaTime * Speed;
                // Rotating Wheels in the Pitch axis
                LeftFrontWheel.Rotate(1f, 0, 0);
                RightFrontWheel.Rotate(1f, 0, 0);
                LeftBackWheel.Rotate(1f, 0, 0);
                RightBackWheel.Rotate(1f, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Engine.Roule(0.1f))
            {
                Offset += -1f * gameObject.transform.forward * Time.deltaTime * Speed;
                // Rotating Wheels in the Pitch axis
                LeftFrontWheel.Rotate(-1f, 0, 0);
                RightFrontWheel.Rotate(-1f, 0, 0);
                LeftBackWheel.Rotate(-1f, 0, 0);
                RightBackWheel.Rotate(-1f, 0, 0);
            }
            
        }

        // Updating the position
        gameObject.transform.position += Offset;

        // Rotate Left - Right
        if (Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(-Rotate);
            // Rotating Wheels in the Yaw axis
            LeftFrontWheel.Rotate(0, -30f, 0);
            RightFrontWheel.Rotate(0, -30f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(Rotate);
            // Rotating Wheels in the Pitch axis
            LeftFrontWheel.Rotate(0, 30f, 0);
            RightFrontWheel.Rotate(0, 30f, 0);
        }

    }
}
