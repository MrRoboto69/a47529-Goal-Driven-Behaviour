using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateWorld : MonoBehaviour
{
    public Text states;

    void LateUpdate()
    {
        Dictionary<string, int> WorldStates = GWorld.Instance.GetWorld().GetStates();
        states.text = "";
        foreach (KeyValuePair<string, int> s in WorldStates)
        {
            states.text += s.Key + ", " + s.Value + "\n";
        }
    }
}
