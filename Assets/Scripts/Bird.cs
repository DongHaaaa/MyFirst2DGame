using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class Bird : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 1.2f;
    [SerializeField] private int _score = 0;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _checkScore;
    [SerializeField] private GameObject GamemanagerFB;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _scoreText.text = _score.ToString();
    }
    private void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.linearVelocity = Vector2.up * _velocity;
            Debug.Log("Input is pressed");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("ScoreCheck"))
        {
            _score++;
            _scoreText.text = _score.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        GamemanagerFB.GetComponent<GamemanagerFB>().GameOver();
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * _rotationSpeed);
    }
}
