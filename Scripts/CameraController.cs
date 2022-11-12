using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Player;

    private Vector2 _mousePos;
    public Vector3 offset;
    public float _mouseSpeed = 100;
    private float _speed = 0.5f;
    private float _mousePosX;
    private float _mousePosY;
    private float _zoomSpeed = 2;
    private float _distance = -10;

    void Start()
    {
        _mousePos = transform.position;

    }


    void FixedUpdate()
    {
        CameraPosition(); // Позиция

        CameraDistance(); // Дистанция
    }
    
    
    void CameraDistance()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            _distance += Input.mouseScrollDelta.y * _zoomSpeed;
        }

    }
    
    void CameraPosition()
    {
        _mousePos = Input.mousePosition;
        _mousePosX = _mousePos.x - Screen.width / 2;
        _mousePosY = _mousePos.y - Screen.height / 2;

        Vector3 _mousePosV3 = new Vector3(_mousePosX / _mouseSpeed, _mousePosY / _mouseSpeed, _distance);

        Vector3 _playerPos = new Vector3(Player.position.x, Player.position.y, _distance) + offset;

        transform.position = Vector3.Lerp(_playerPos + _mousePosV3, _playerPos + _mousePosV3, _speed);
    }


}
