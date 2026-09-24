using UnityEngine;

public class BoostPad : MonoBehaviour
{
    public float boostForce = 500.0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //check if the object that entered the trigger has a Ball component
        Ball ball = other.GetComponent<Ball>();
        //if it does, continiue

        if (ball != null)
        {
            //calculate the direction from the boost pad to the ball
            Vector2 forceDirection = ball.transform.position - transform.position;
            
            forceDirection.Normalize();
            //apply the boost force to the ball in the direction away from the boost pad
            
            ball.AddForce(forceDirection * boostForce);
        }
    }
}
