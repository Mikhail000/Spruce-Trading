using UnityEngine;
using UnityEngine.Events;

namespace Spruce.StateMachine
{
    public class StateMachine : MonoBehaviour
    {
        public static event UnityAction Transition;
        public void TransferState()
        {
            Transition?.Invoke();
            
            Debug.Log("Transmissions Stage");
        }
    }
}

