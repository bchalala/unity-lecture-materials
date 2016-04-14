using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public int x_speed;
    public int y_speed;
    public int z_speed;
    
    void Update () 
    {
        transform.Rotate (new Vector3 (x_speed, y_speed, z_speed) * Time.deltaTime);
    }
}
