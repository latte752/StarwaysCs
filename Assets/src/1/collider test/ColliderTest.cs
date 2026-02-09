using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    #region TesterScript
    [SerializeField] Color testColor = Color.green;
    private Color originalColor = Color.white;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        // Store the starting color so we can reset to it
        if (rend != null) originalColor = rend.material.color;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Reset();
        }

    }
    void Reset()
    {
        ChangeColor(originalColor);
    }
    void ChangeColor(Color colorToSet)
    {
        if (rend != null)
        {
            rend.material.color = colorToSet;
        }
    }
    #endregion

    void OnCollisionEnter(Collision collision)
    {

    }

    void OnCollisionStay(Collision collision)
    {

    }

    void OnCollisionExit(Collision collision)
    {

    }

    void OnTriggerEnter(Collider other)
    {

    }

    void OnTriggerStay(Collider other)
    {

    }

    void OnTriggerExit(Collider other)
    {

    }
}
