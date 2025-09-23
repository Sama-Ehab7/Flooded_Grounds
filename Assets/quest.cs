using UnityEngine;
using TMPro;

public class quest : MonoBehaviour
{
    public int target= 5;
    public TextMeshProUGUI uitext;
    int Current = 0;

    public void AddKill()
    {
        Current++;
        uitext.text = "Kill: " + Current + "/" + target;
        if (Current >= target)
        {
            Debug.Log("quest complete ");

        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
