using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    private UIDocument document;
    private Button button;
    private Label time;

    private void Awake()
    {
        document = GetComponent<UIDocument>();

        VisualElement root = document.rootVisualElement;
        time = root.Q<Label>("Time");
        time.text = "hi mom this is a test";
    }

    public void SetTimerText(float value)
    {
        System.TimeSpan t = System.TimeSpan.FromSeconds(value);
        string text = t.ToString(@"mm\:ss\:fff");
        time.text = text;
    }
}
