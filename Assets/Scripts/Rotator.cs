using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 rotationValue = new Vector3(15, 30, 45);

    void Update()
    {
        //Rotate the object over time
        transform.Rotate(rotationValue * Time.deltaTime * speed, Space.World);
    }
}
