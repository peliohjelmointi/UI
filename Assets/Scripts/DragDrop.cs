using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler,
    IDragHandler
{
    [SerializeField] Canvas canvas;
    RectTransform rectTransform;
    CanvasGroup canvasGroup;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //print("dragging started");
        canvasGroup.alpha = 0.5f; //raahatessa osittain läpinäkyvä
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //print("dragging ongoing");           //scaleFactor ei pakollinen mutta suositeltu
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //print("dragging ENDED");
        canvasGroup.alpha = 1f; //takaisin täysin näkyväksi
        canvasGroup.blocksRaycasts = true; 
    }



}
