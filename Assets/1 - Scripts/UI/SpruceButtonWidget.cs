using UnityEngine;
using Spruce;

public class SpruceButtonWidget : MonoBehaviour
{
    [SerializeField]public SpruceSpeciesIDs Id;
        
    [SerializeField] private string spruceName;
    public delegate void ButtonClick(string name);
    public static event ButtonClick buttonClick;

    public void PassSpruceNameToSpawn()
    {
        buttonClick?.Invoke(spruceName);
    }
}
