using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("There is more than one InputManager " + transform + " - " + Instance);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public bool IsLeftMouseClicked()
    {
        return Input.GetMouseButtonDown(0);
    }

    public bool IsRightMouseClicked()
    {
        return Input.GetMouseButtonDown(1);
    }
}
