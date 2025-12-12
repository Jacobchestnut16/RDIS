using UnityEngine;
using UnityEngine.XR;

public class VRRayInteract : MonoBehaviour
{
    public Transform rayOrigin;          // controller transform
    public float interactDistance = 10f;
    public LayerMask interactMask;

    public XRNode controllerNode = XRNode.RightHand;

    void Update()
    {
        if (!TriggerPressed())
            return;
		Debug.LogWarning("TriggerPressed");

        Ray ray = new Ray(rayOrigin.position, rayOrigin.forward);
        Debug.DrawRay(ray.origin, ray.direction * interactDistance, Color.green, 1);

        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance, interactMask))
        {
            InteractableCamera interact =
                hit.collider.GetComponent<InteractableCamera>();
            
            Debug.LogWarning($"pssible interactable {interact.name}");
            if (interact != null)
                interact.Trigger();
        }
    }

    bool TriggerPressed()
    {
        return OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger);
    }
}