//https://www.codegrepper.com/code-examples/csharp/can+you+reference+ui+button+being+pressed+in+script+in+unity
//This website helped with the Button code

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPlane : MonoBehaviour
{
    Camera maincam;
    RaycastHit hitInfo;
    public Transform CubePrefab;
    public Transform PlantsPrefab;
    public Transform SpacePartPrefab;
    public Button spawnButton;
    public Button PlantsButton;
    public Button SpacePartButton;
    public int press = 1;//spawner

    // Start is called before the first frame update
    void Awake()
    {
        maincam = Camera.main;
    }

    void Start()
    {
        Button spawnBut = spawnButton.GetComponent<Button>();
        spawnBut.onClick.AddListener(clickCheckSpawn);

        Button cylinderBut = PlantsButton.GetComponent<Button>();
        cylinderBut.onClick.AddListener(clickCheckPlants);

        Button cubeBut = SpacePartButton.GetComponent<Button>();
        cubeBut.onClick.AddListener(clickCheckSpacePart);
    }

    void clickCheckSpawn()
    {
        Debug.Log("You have clicked the button!");
        press = 1;
    }

    void clickCheckPlants()
    {
        Debug.Log("You have clicked the button!");
        press = 2;
    }

    void clickCheckSpacePart()
    {
        Debug.Log("You have clicked the button!");
        press = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Color c = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
                //CubePlacer.PlaceCube(hitInfo.point, c, cubePrefab);

                if (press == 1)
                {
                    ICommand command = new PlaceCubeCommand(hitInfo.point, c, CubePrefab);
                    CommandInvoker.AddCopmmand(command);
                }

                if (press == 2)
                {
                    ICommand command = new PlaceCubeCommand(hitInfo.point, c, PlantsPrefab);
                    CommandInvoker.AddCopmmand(command);
                }

                if (press == 3)
                {
                    ICommand command = new PlaceCubeCommand(hitInfo.point, c, SpacePartPrefab);
                    CommandInvoker.AddCopmmand(command);
                }

                //CommandInvoker.AddCopmmand(command);
            }
        }
    }
}
