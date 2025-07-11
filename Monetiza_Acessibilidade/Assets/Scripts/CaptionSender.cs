using UnityEngine;
using UnityEngine.EventSystems;

public class CaptionSender : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private int id;

    public bool IsMouseOver { get; private set; }

    public void OnPointerEnter(PointerEventData eventData) => GameEvents.Instance.MouseEnter(id);

    public void OnPointerExit(PointerEventData eventData) => GameEvents.Instance.MouseExit();
}
