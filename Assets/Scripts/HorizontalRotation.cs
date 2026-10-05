using UnityEngine;
using UnityEngine.InputSystem;

public class HorizontalRotation : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.localEulerAngles = transform.localEulerAngles 
            + new Vector3(0, Mouse.current.delta.value.x, 0) * speed * Time.deltaTime;
    }
}
