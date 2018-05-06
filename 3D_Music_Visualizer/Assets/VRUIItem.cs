using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class VRUIItem : MonoBehaviour
{
    private BoxCollider boxCollider;
    private RectTransform rectTransform;

	void Update(){
		ValidateCollider ();
	}

    private void OnEnable()
    {
        ValidateCollider();
    }

    private void OnValidate()
    {
        ValidateCollider();
    }

    private void ValidateCollider()
    {
        rectTransform = GetComponent<RectTransform>();

        boxCollider = GetComponent<BoxCollider>();
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider>();
        }

		boxCollider.size = (Vector3) rectTransform.sizeDelta;
    }
}