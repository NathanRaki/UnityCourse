using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelBehaviour : MonoBehaviour
{
    [SerializeField]
    private bool bIsFront = false;

    private Deplacement ParentDeplacement;
    private Quaternion ParentRotation;

    // Start is called before the first frame update
    void Start()
    {
        ParentDeplacement = transform.parent.GetComponent<Deplacement>();
        ParentRotation = transform.parent.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        ParentRotation = transform.parent.rotation;
        // If this is a Front Wheel
        if (bIsFront)
        {
            if (Input.GetKeyDown(KeyCode.Q))
                transform.rotation = Quaternion.Euler(ParentRotation.eulerAngles.x, ParentRotation.eulerAngles.y - 30, ParentRotation.eulerAngles.z);
            if (Input.GetKeyUp(KeyCode.Q))
                transform.rotation = ParentRotation;
            if (Input.GetKeyDown(KeyCode.D))
                transform.rotation = Quaternion.Euler(ParentRotation.eulerAngles.x, ParentRotation.eulerAngles.y + 30, ParentRotation.eulerAngles.z);
            if (Input.GetKeyUp(KeyCode.D))
                transform.rotation = ParentRotation;
        }

        // Checking if the velocity vector is opposing the car direction
        if (Vector3.Dot(ParentDeplacement.Velocity, transform.parent.forward) > 0)
            transform.Rotate(ParentDeplacement.Velocity.magnitude, 0, 0);
        else if (Vector3.Dot(ParentDeplacement.Velocity, transform.parent.forward) < 0)
            transform.Rotate(-ParentDeplacement.Velocity.magnitude, 0, 0);
    }
}
