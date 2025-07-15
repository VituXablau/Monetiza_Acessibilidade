using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    public event Action<int> OnMouseEnter;

    void Awake() => Instance = this;

    public void MouseEnter(int id) => OnMouseEnter?.Invoke(id);
}
