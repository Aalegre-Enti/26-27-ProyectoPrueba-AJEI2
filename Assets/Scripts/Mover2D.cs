using UnityEngine;
using UnityEngine.InputSystem;

public class Mover2D : MonoBehaviour
{
    public int fps = -1;
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = fps;
        Vector3 dir = new Vector3(0, 0, 0);

        if (Keyboard.current.wKey.isPressed)
        {
            dir.y = 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            dir.y = -1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            dir.x = 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            dir.x = -1;
        }

        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
