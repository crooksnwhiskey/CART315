using UnityEngine;

public class AutoMove : MonoBehaviour
{

public Transform[] waypoints;
public float speed = 2f; 
int index = 0;  

    // Update is called once per frame
    void Update()
    {
        Transform target = waypoints[index];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            index++;
            if (index >= waypoints.Length)
            {
                index = 0; 
            }
        }
    }
    
}
