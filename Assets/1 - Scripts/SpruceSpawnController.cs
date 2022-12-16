using UnityEngine;

public class SpruceSpawnController : MonoBehaviour
{
    [SerializeField] private SpruceStorage spruceStorage;
    [SerializeField] private Transform spawnPoint;

    private bool IsEngaged
    {
        set
        {
            value = true;
        }
    }

    private void OnEnable()
    {
        SpruceWidgetExtension.buttonClick += FindSpruceNameInStorage;
    }

    private void OnDisable()
    {
        SpruceWidgetExtension.buttonClick -= FindSpruceNameInStorage;
    }

    private void SpawnNewSpruce(GameObject sprucePrefab)
    {
        var type = sprucePrefab;

        Instantiate(type, spawnPoint);
    }

    private void FindSpruceNameInStorage(string spruceType)
    {
        foreach (var node in spruceStorage.Nodes)
        {
            SpruceStorageNode curNode = node;

            if (spruceType == curNode.Id.ToString())
            {
               SpawnNewSpruce(curNode.Prefab);
            }
        }
    }
    
    private void ChangeSpawnPlaceState(bool value)
    {
        IsEngaged = value;
    }
}
