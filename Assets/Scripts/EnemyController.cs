using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log(other);
            gameObject.SetActive(false);
            GameManager.instance.UpdateScore();
            Vector3 newPosition = new Vector3();
            newPosition.x = Random.Range(-1.5f, 1.5f);
            newPosition.y = Random.Range(-0.75f, 0.75f);
            transform.position = newPosition;
            gameObject.SetActive(true);
        }
    }
}
