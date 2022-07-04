using System.Collections;
using System.Collections.Generic;
using Assets.Tiles;
using UnityEngine;

namespace Assets.Enemy
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] List<Waypoint> _path = new List<Waypoint>();

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

                float travelPercent = 0f;

                while (travelPercent < 1f)
                {
                    travelPercent += Time.deltaTime;
                    transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                    yield return new WaitForEndOfFrame();
                }
            }
        }
    }
}