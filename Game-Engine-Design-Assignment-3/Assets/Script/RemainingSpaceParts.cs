using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingSpaceParts : MonoBehaviour
{
    public static int SpaceParts = 5;
    Text spaceParts;

    // Start is called before the first frame update
    void Start()
    {
        spaceParts = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        spaceParts.text = "Space Parts Remaining: " + SpaceParts;
    }
}
