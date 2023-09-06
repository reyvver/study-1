using System;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private GameObject starVisual;
    [SerializeField] private float floatForce;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private AudioSource soundCollect;
    [SerializeField] private AudioSource soundAura;

    private bool _collected;
    private Vector3 _pos;
    private double x;
    private double _sign = 1;
    private float _startY;
    
    private void Awake()
    {
        _pos = transform.position;
        _startY = _pos.y;
        x = 0;
    }

    void Update()
    {
        x += Time.deltaTime;
        if (x > 1)
        {
            x = 0;
            _sign *= -1;
        }
        
        _pos.y = _startY + floatForce * (float) Math.Sin(Math.PI * x * _sign);
        transform.position = _pos;
        transform.Rotate(0,rotateSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_collected) return;
        soundAura.Stop();
        soundCollect.Play();
        _collected = true;
        starVisual.SetActive(false);
    }
}
