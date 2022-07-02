using UnityEngine;
using TMPro;

namespace Assets.Scripts
{
    [ExecuteAlways]
    public class CoordinateLabeler : MonoBehaviour
    {
        private TextMeshPro label;

        Vector2Int coordinates = new Vector2Int();

        void Awake()
        {
            label = GetComponent<TextMeshPro>();
        }

        void Start()
        {
        }

        void Update()
        {
            if (!Application.isPlaying)
            {
                DisplayCurrentCoordinates();
            }
        }

        private void DisplayCurrentCoordinates()
        {
            // Assigning Parent Game Object position vectors 
            coordinates.x = Mathf.RoundToInt(transform.parent.position.x);
            coordinates.y = Mathf.RoundToInt(transform.parent.position.z);
            
            label.text = $"{coordinates.x} : {coordinates.y}";
        }
    }
}