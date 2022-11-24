using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    private TextMeshPro _label;

    Vector2Int _coordinates = new Vector2Int();

    void Awake()
    {
        _label = GetComponent<TextMeshPro>();
        DisplayCurrentCoordinates();
    }

    void Update()
    {
        if (!Application.isPlaying)
        {
            DisplayCurrentCoordinates();
            UpdateObjectName();
        }
    }
        
    private void DisplayCurrentCoordinates()
    {
        // Assigning Parent Game Object position vectors 
        _coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        _coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);

        _label.text = $"{_coordinates.x} : {_coordinates.y}";
    }

    void UpdateObjectName()
    {
        transform.parent.name = _coordinates.ToString();
    }
}