using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> _path = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)] private float enemySpeed = 1f;

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach (Waypoint waypoint in _path)
        {
            // Using Lerp Linear Interpolation
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;

            // Looking at end position to face correct travel direction
            transform.LookAt(endPosition);

            float travelPercent = 0f;

            while (travelPercent < 1f)
            {
                // Adding Movement Incrementation
                travelPercent += Time.deltaTime * enemySpeed;

                // Calling Vector3.Lerp function
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}