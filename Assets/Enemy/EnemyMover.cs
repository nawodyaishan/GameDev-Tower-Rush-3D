using System.Collections;
using System.Collections.Generic;
using Assets.Tiles;
using UnityEngine;

namespace Assets.Enemy
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private List<Waypoint> _size = new List<Waypoint>();

        void Start()
        {
            StopCoroutine(PrintWaypointName());
            //  InvokeRepeating("PrintWaypointName", 0,1f);
        }

        void Update()
        {
        }

        IEnumerator PrintWaypointName()
        {
            foreach (var waypoint in _size)
            {
                Debug.Log(waypoint.name);
                yield return new WaitForSeconds(1f);
            }
        }
    }
}