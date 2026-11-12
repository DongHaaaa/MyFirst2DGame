using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Enemy enemy;
    public float speed = 0.1f;
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //normalized là chuẩn hóa vector, để vector có độ dài bằng 1, tránh việc di chuyển chéo nhanh hơn
        transform.position += new Vector3(h, v, 0).normalized * speed * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            
        }
    }
}
