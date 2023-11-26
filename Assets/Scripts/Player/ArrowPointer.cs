using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArrowPointer : MonoBehaviour
{
    [Header("References")]
    public Transform TargetTransform;
    public Transform PlayerTransform;
    public RectTransform TextTransform;
    [Range(200f, 400f)]
    [Tooltip("The higher the number the closer you can get before the arrow disappear")]
    public float ScreenHeightDectionReduction = 350f; 

    [Header("Graphic")]
    public TextMeshProUGUI DistanceText;
    public Image PointerImageComponent;
    public Sprite ArrowImage;
    public Sprite OnScreenImage;

    [Header("Debug")]
    public bool DebugMode;
    public Transform HomeUiPOs;
    public Transform fromUiPOs;

    private Camera mainCamera;
    private float screenWidthLimit, screenHeighLimit;
    private Vector3 centerOfTheScreen, targetPosition;
    void Start()
    {
        CacheForPerformance();
    }

    private void CacheForPerformance()
    {
        mainCamera = Camera.main;
        targetPosition = TargetTransform.position;

        screenWidthLimit = Screen.width + ScreenHeightDectionReduction;
        screenHeighLimit = Screen.height - ScreenHeightDectionReduction;
        centerOfTheScreen = new Vector2(Screen.width / 2f, Screen.height / 2f);
    }

    void Update()
    {
        Vector3 targetPositionOnScreen = mainCamera.WorldToScreenPoint(calculateWorldPosition(targetPosition, mainCamera));
        bool HouseOffScreen = targetPositionOnScreen.x <= -ScreenHeightDectionReduction || targetPositionOnScreen.x >= screenWidthLimit || targetPositionOnScreen.y <= ScreenHeightDectionReduction || targetPositionOnScreen.y >= screenHeighLimit;

        if (HouseOffScreen)
        {
            OutSideHouseRange(targetPositionOnScreen);
        }
        else
        {
            InsideHouseRange(targetPositionOnScreen);
        }

        if (DebugMode)
        {
            if (!fromUiPOs.gameObject.activeInHierarchy) fromUiPOs.gameObject.SetActive(true);
            if (!HomeUiPOs.gameObject.activeInHierarchy) HomeUiPOs.gameObject.SetActive(true);

            fromUiPOs.position = centerOfTheScreen; //delete later
            HomeUiPOs.position = targetPositionOnScreen; //delete later
        }
        else
        {
            if (fromUiPOs.gameObject.activeInHierarchy) fromUiPOs.gameObject.SetActive(false);
            if (HomeUiPOs.gameObject.activeInHierarchy) HomeUiPOs.gameObject.SetActive(false);
        }
    }

    // position = the world position of the entity to be tested
    private Vector3 calculateWorldPosition(Vector3 position, Camera camera)
    {
        //if the point is behind the camera then project it onto the camera plane
        Vector3 camNormal = camera.transform.forward;
        Vector3 vectorFromCam = position - camera.transform.position;
        float camNormDot = Vector3.Dot(camNormal, vectorFromCam.normalized);
        if (camNormDot <= 0f)
        {
            //we are beind the camera, project the position on the camera plane
            float camDot = Vector3.Dot(camNormal, vectorFromCam);
            Vector3 proj = (camNormal * camDot * 1.01f);   //small epsilon to keep the position infront of the camera
            position = camera.transform.position + (vectorFromCam - proj);
        }

        return position;
    }

    private void OutSideHouseRange(Vector3 targetPositionOnScreen)
    {
        if (!PointerImageComponent.enabled) PointerImageComponent.enabled = true;
        CaculateRotationAngle(targetPositionOnScreen);

        int distance = (int)Vector3.Distance(targetPosition, PlayerTransform.position);
        DistanceText.text = distance + "M.";
    }

    private void CaculateRotationAngle(Vector3 targetPositionOnScreen)
    {
        Vector3 direction = (targetPositionOnScreen - centerOfTheScreen).normalized;
        float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) % 360;

        transform.localEulerAngles = new Vector3(0, 0, angle);
        TextTransform.localEulerAngles = new Vector3(0, 0, -angle);
    }

    private void InsideHouseRange(Vector3 targetPositionOnScreen)
    {
        if (PointerImageComponent.enabled) PointerImageComponent.enabled = false;
        DistanceText.text = "";
    }

    public float GetAngleFromVector3(Vector3 direction)
    {
        float n = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (n < 0) n += 360;
        return n;
    }
}
