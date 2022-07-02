using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private List<Waypoint> _size = new List<Waypoint>();

        void Start()
        {
            PrintWaypointName();
        }

        void Update()
        {
        }

        void PrintWaypointName()
        {
            foreach (var waypoint in _size)
            {
                Debug.Log(waypoint.name);
            }
        }
    }
}