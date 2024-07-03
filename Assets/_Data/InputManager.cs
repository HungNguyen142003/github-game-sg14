using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance => instance;//get

    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos => mouseWorldPos;//get
    [SerializeField] protected float onFiring;
    public float OnFiring => onFiring;//get
    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("Only 1 InpuManager allow to exits");
        InputManager.instance = this;
    }
    private void Update()
    {
        this.GetMouseDown();
    }

    void FixedUpdate()
    {
        this.GetMousePos();
    }

    protected virtual void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }

    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
