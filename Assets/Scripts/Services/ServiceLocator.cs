using System.Collections.Generic;
using UnityEngine;


public class ServiceLocator : MonoBehaviour
{
    [SerializeField] private GameObject cameraServicePrefab;

    private static ServiceLocator instance;
    private IDictionary<string, IService> services;

    private void Awake()
    {
        services = new Dictionary<string, IService>();

        if (instance)
        {
            return;
        }

        instance = this;
    }

    public static ServiceLocator GetInstance()
    {
        return instance;
    }

    public CameraService GetCameraService()
    {
        if (instance.services.ContainsKey(CameraService.NAME))
        {
            return (CameraService)instance.services[CameraService.NAME];
        }

        GameObject cameraService = Instantiate(cameraServicePrefab, Vector2.zero, Quaternion.identity);
        cameraService.transform.parent = gameObject.transform;

        instance.services.Add(CameraService.NAME, cameraService.GetComponent<CameraService>());

        return (CameraService)instance.services[CameraService.NAME];
    }
}
