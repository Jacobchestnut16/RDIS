using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance = 4f;
    public LayerMask interactMask;
    public Camera cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))        // interaction key
        {
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * interactDistance, Color.red, 4);
            
            
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDistance, interactMask))
            {
                // Look for an interactable script on the object
                InteractableCamera interact = hit.collider.GetComponent<InteractableCamera>();
                
                if (interact != null)
                {
                    interact.Trigger();
                }
            }
        }
    }
}