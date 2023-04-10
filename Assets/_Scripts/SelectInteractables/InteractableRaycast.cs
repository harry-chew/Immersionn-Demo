using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableRaycast : MonoBehaviour
{
    [SerializeField] private IInteractable _selectedInteraction;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                _selectedInteraction = hit.collider.gameObject.GetComponent<IInteractable>();
                _selectedInteraction?.Interact();

                if(_selectedInteraction != null)
                {
                    Debug.Log(_selectedInteraction.ToString());
                }
            }
        }
    }
}
