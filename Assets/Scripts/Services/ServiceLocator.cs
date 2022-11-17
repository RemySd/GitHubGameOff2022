using System.Collections.Generic;
using UnityEngine;


public class ServiceLocator : MonoBehaviour
{
    [SerializeField] private GameObject cameraServicePrefab;
    [SerializeField] private GameObject effectServicePrefab;
    [SerializeField] private GameObject transitionServicePrefab;
    [SerializeField] private GameObject levelServicePrefab;
    [SerializeField] private GameObject uiServicePrefab;
    [SerializeField] private GameObject dialogPanelServicePrefab;
    [SerializeField] private GameObject playerServicePrefab;

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

    private void Start()
    {
        GetUiService();
        GetDialogPanelService();
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

    public LevelService GetLevelService()
    {
        if (instance.services.ContainsKey(LevelService.NAME))
        {
            return (LevelService)instance.services[LevelService.NAME];
        }

        GameObject levelService = Instantiate(levelServicePrefab, Vector2.zero, Quaternion.identity);
        levelService.transform.parent = gameObject.transform;

        instance.services.Add(LevelService.NAME, levelService.GetComponent<LevelService>());

        return (LevelService)instance.services[LevelService.NAME];
    }

    public UiService GetUiService()
    {
        if (instance.services.ContainsKey(UiService.NAME))
        {
            return (UiService) instance.services[UiService.NAME];
        }

        GameObject uiService = Instantiate(uiServicePrefab, Vector2.zero, Quaternion.identity);
        uiService.transform.parent = gameObject.transform;

        instance.services.Add(UiService.NAME, uiService.GetComponent<UiService>());

        return (UiService) instance.services[UiService.NAME];
    }

    public DialogPanelService GetDialogPanelService()
    {
        if (instance.services.ContainsKey(DialogPanelService.NAME))
        {
            return (DialogPanelService)instance.services[DialogPanelService.NAME];
        }

        GameObject dialogPanelService = Instantiate(dialogPanelServicePrefab, Vector2.zero, Quaternion.identity);
        dialogPanelService.transform.parent = gameObject.transform;

        instance.services.Add(DialogPanelService.NAME, dialogPanelService.GetComponent<DialogPanelService>());

        return (DialogPanelService)instance.services[DialogPanelService.NAME];
    }

    public PlayerService GetPlayerService()
    {
        if (instance.services.ContainsKey(PlayerService.NAME))
        {
            return (PlayerService)instance.services[PlayerService.NAME];
        }

        GameObject playerService = Instantiate(playerServicePrefab, Vector2.zero, Quaternion.identity);
        playerService.transform.parent = gameObject.transform;

        PlayerService playerServiceScript = playerService.GetComponent<PlayerService>();
        playerServiceScript.Init();

        instance.services.Add(PlayerService.NAME, playerServiceScript);

        return (PlayerService)instance.services[PlayerService.NAME];
    }
}
