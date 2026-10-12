using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;

    public float speed = 30f;
    public float maxBounceAngle = 75f;
    public float parryWindow = 0.2f;
    public float parryCooldown = 0.5f;

    private float parryTimer;
    private float cooldownTimer;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPaddle();
    }

    public void ResetPaddle()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = new Vector2(0f, transform.position.y);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            direction = Vector2.left;
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            direction = Vector2.right;
        } else {
            direction = Vector2.zero;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (cooldownTimer <= 0f) {
                parryTimer = parryWindow;
                cooldownTimer = parryCooldown;
                Debug.Log("Parry activated!");
            } else {
                Debug.Log("Parry is on cooldown!");
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
               GameManager.Instance.takeDamage(1);
                if (GameManager.Instance.health <= 0) {
                    return;
                }
            }
        }

        if (parryTimer > 0f) parryTimer -= Time.deltaTime;
        if (cooldownTimer > 0f) cooldownTimer -= Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero) {
            rb.AddForce(direction * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Ball")) {
            return;
        }
            if (parryTimer > 0f) {
                Debug.Log("parry");
            }
            else{
                Debug.Log("hit");
                GameManager.Instance.takeDamage(1);
                if (GameManager.Instance.health <= 0) {
                    return;
                }
            }
           

        

        Rigidbody2D ball = collision.rigidbody;
        Collider2D paddle = collision.otherCollider;

        // Gather information about the collision
        Vector2 ballDirection = ball.linearVelocity.normalized;
        Vector2 contactDistance = paddle.bounds.center - ball.transform.position;

        // Rotate the direction of the ball based on the contact distance
        // to make the gameplay more dynamic and interesting
        float bounceAngle = (contactDistance.x / paddle.bounds.size.x) * maxBounceAngle;
        ballDirection = Quaternion.AngleAxis(bounceAngle, Vector3.forward) * ballDirection;

        // Re-apply the new direction to the ball
        ball.linearVelocity = ballDirection * ball.linearVelocity.magnitude;
    }

}
