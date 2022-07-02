using System.Collections;
using System.Collections.Generic;
using Assets.Tiles;
using UnityEngine;

namespace Assets.Enemy
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] List<Waypoint> _path = new List<Waypoint>();
        [SerializeField] float _waitTime = 1f;

        void Start()
        {
            StartCoroutine(FollowPath());
        }

        void Update()
        {
        }

        IEnumerator FollowPath()
        {
            foreach (Waypoint waypoint in _path)
            {
                transform.position = new Vector3(waypoint.transform.position.x, 5f, waypoint.transform.position.z);
                yield return new WaitForSeconds(_waitTime);
            }
        }
    }
}