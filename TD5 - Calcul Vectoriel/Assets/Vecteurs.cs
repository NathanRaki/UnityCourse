using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vecteurs : MonoBehaviour
{
    /* Calcul de Vecteur
     * 
     * +2D
     * (5, 8) + (3, 2) = (8, 10)
     * 
     * -2D
     * (-1, -3) - (-2, 2) = (1, -5)
     * 
     * +3D
     * (-2, -1, 5) + (1, 4, 3) = (-1, 3, 8)
     * 
     * -3D
     * (2, -4, 1) - (-1, -1, 3) = (3, -3, -2)
     * 
    */

    // Start is called before the first frame update
    void Start()
    {
        Vector2 Add2D = new Vector2(5, 8) + new Vector2(3, 2);
        Debug.Log(Add2D);
        Vector2 Sub2D = new Vector2(-1, -3) - new Vector2(-2, 2);
        Debug.Log(Sub2D);
        Vector3 Add3D = new Vector3(-2, -1, 5) + new Vector3(1, 4, 3);
        Debug.Log(Add3D);
        Vector3 Sub3D = new Vector3(2, -4, 1) - new Vector3(-1, -1, 3);
        Debug.Log(Sub3D);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
