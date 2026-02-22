using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical"); 
        transform.Translate(Vector3.right * -h * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * -v * speed * Time.deltaTime);
    }
}