using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * _speed;
    }
}
