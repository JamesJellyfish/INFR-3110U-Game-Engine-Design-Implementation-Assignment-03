using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCubeCommand : ICommand
{
    Vector3 position;
    Color color;
    Transform cube;

    public PlaceCubeCommand(Vector3 position, Color color, Transform cube)
    {
        this.position = position;
        this.color = color;
        this.cube = cube;
    }
    
    public void Execute()
    {
        CubePlacer.PlaceCube(position, color, cube);
    }

    public void Undo()
    {
        CubePlacer.RemoveCube(position, color);
    }

    // Lab 7 Game Engine Dirty Flag
    public override string ToString()
    {
        return "PlaceSpaceParts:\t" + position.x + ":" + position.y + ":" + position.z + "\t"
        + color.r + ":" + color.g + ":" + color.b;
    }
}
