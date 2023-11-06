using UnityEngine;
using UnityEngine.UI;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject[] models; // Array of 3D model GameObjects
    public Text[] texts; // Array of Text GameObjects

    private int currentModelIndex = 0;

    void Start()
    {
        // Initialize by showing the first model and hiding the rest
        for (int i = 1; i < models.Length; i++)
        {
            models[i].SetActive(false);
            texts[i].gameObject.SetActive(false);
        }
    }

    public void SwitchModel(int newIndex)
    {
        // Hide the current model and its associated text
        models[currentModelIndex].SetActive(false);
        texts[currentModelIndex].gameObject.SetActive(false);

        // Show the new model and its associated text
        models[newIndex].SetActive(true);
        texts[newIndex].gameObject.SetActive(true);

        // Update the current model index
        currentModelIndex = newIndex;
    }
}
