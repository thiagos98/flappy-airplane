using UnityEngine;

public class Tutorial : MonoBehaviour
{
    private void Start()
    {
        DestroyTutorial();
    }

    private void DestroyTutorial()
    {
        Destroy(gameObject, 5f);
    }
}
