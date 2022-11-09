﻿using System.Collections;
using UnityEngine;

public class CameraService : MonoBehaviour, IService
{
    public const string NAME = "Camera";

    private GameObject currentCamera;

    [SerializeField] private float duration;
    [SerializeField] private float magnitude;

    private void Awake()
    {
        currentCamera = Camera.main.gameObject;
    }

    public string GetName()
    {
        return NAME;
    }

    public void Shake()
    {
        StartCoroutine(EnumShake());
    }

    public IEnumerator EnumShake()
    {
        Vector3 originalPos = currentCamera.transform.position;

        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            float xOffset = Random.Range(originalPos.x - 0.5f * magnitude, originalPos.x + 0.5f * magnitude);
            float yOffset = Random.Range(originalPos.y - 0.5f * magnitude, originalPos.y + 0.5f * magnitude);

            currentCamera.transform.position = new Vector3(xOffset, yOffset, originalPos.z);
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        currentCamera.transform.position = originalPos;
    }

    public void FocusToOther(GameObject otherObject, float duration)
    {
        StartCoroutine(FocusToOtherEnum(otherObject, duration));
    }

    private IEnumerator FocusToOtherEnum(GameObject otherObject, float duration)
    {
        CameraFollow cameraFollow = currentCamera.GetComponent<CameraFollow>();
        GameObject currentObject = cameraFollow.GetObjectToFollow();
        cameraFollow.SetObjectToFollow(otherObject);

        yield return new WaitForSeconds(duration);

        cameraFollow.SetObjectToFollow(currentObject);
    }
}