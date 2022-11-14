using System.Collections.Generic;
using UnityEngine;


public class ServiceLocator : MonoBehaviour
{
    [SerializeField] private GameObject cameraServicePrefab;
    [SerializeField] private GameObject effectServicePrefab;
    [SerializeField] private GameObject transitionServicePrefab;

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

    public EffectService GetEffectService()
    {
        if (instance.services.ContainsKey(EffectService.NAME))
        {
            return (EffectService)instance.services[EffectService.NAME];
        }

        GameObject effectService = Instantiate(effectServicePrefab, Vector2.zero, Quaternion.identity);
        effectService.transform.parent = gameObject.transform;

        instance.services.Add(EffectService.NAME, effectService.GetComponent<EffectService>());

        return (EffectService)instance.services[EffectService.NAME];
    }

    public TransitionService GetTransitionService()
    {
        if (instance.services.ContainsKey(TransitionService.NAME))
        {
            return (TransitionService)instance.services[TransitionService.NAME];
        }
    
        GameObject transitionService = Instantiate(transitionServicePrefab, Vector2.zero, Quaternion.identity);
        transitionService.transform.parent = gameObject.transform;
    
        instance.services.Add(TransitionService.NAME, transitionService.GetComponent<TransitionService>());
    
        return (TransitionService)instance.services[TransitionService.NAME];
    }
}
