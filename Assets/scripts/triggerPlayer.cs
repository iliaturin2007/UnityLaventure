using UnityEngine;
using UnityEngine.Events;


public class triggerPlayer : MonoBehaviour
{
    [SerializeField] bool DestroyOnTrigger = true;
    [SerializeField] private UnityEvent playerEnterEvent;
    [SerializeField] private UnityEvent playerExitEvent;
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerEnterEvent.Invoke();
            if (DestroyOnTrigger)
                Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerExitEvent.Invoke();
        }
    }
}