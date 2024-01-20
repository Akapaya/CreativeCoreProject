using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Camera _camera1;
    [SerializeField] Camera _camera2;
    [SerializeField] Camera _camera3;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            DeactiveCamera();
            _camera1.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DeactiveCamera();
            _camera2.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DeactiveCamera();
            _camera3.gameObject.SetActive(true);
        }
    }

    private void DeactiveCamera()
    {
        _camera1.gameObject.SetActive(false);
        _camera2.gameObject.SetActive(false);
        _camera3.gameObject.SetActive(false);
    }
}