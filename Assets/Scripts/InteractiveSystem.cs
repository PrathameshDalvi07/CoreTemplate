using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Systems
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class InteractiveSystem : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
    {
        private IInputSystem iInputSystem;

        private void Awake()
        {
            iInputSystem = new IInputSystem(this);
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            //Debug.Log("OnPointerDown Call");
            iInputSystem.OnPointerDown(eventData);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            //Debug.Log("OnPointerUp Call");
            iInputSystem.OnPointerUp(eventData);
        }
    }
}
