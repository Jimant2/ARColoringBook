using UnityEngine;
using TMPro;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject[] models; // Array of model parent GameObjects
    public TextMeshProUGUI[] texts; // Array of TextMeshPro Text elements

    private int currentModelIndex = 0;

    void Start()
    {
        // Initialize by showing the first model and hiding the rest
        for (int i = 1; i < models.Length; i++)
        {
            models[i].SetActive(false);
        }
    }

    public void SwitchModel(int newIndex)
    {
        // Hide the current model
        models[currentModelIndex].SetActive(false);

        // Show the new model and its associated text
        models[newIndex].SetActive(true);

        // Update the current model index
        currentModelIndex = newIndex;
    }
}
