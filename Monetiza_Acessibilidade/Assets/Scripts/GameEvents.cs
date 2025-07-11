using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    public event Action<int> OnMouseEnter;
    public event Action OnMouseExit;

    void Awake() => Instance = this;

    public void MouseEnter(int id) => OnMouseEnter?.Invoke(id);

    public void MouseExit() => OnMouseExit?.Invoke();
}
