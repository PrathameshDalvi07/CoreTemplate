
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Systems
{
    public class IInputSystem
    {
        InteractiveSystem iSystem;

        public IInputSystem(InteractiveSystem iSystem)
        {
            this.iSystem = iSystem;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("OnPointerDown Call");
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            Debug.Log("OnPointerUp Call");
        }
    }
}