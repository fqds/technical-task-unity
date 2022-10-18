using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeSpawner : MonoBehaviour
{
    public GameObject Cube, CubeSpawnerObject;
    private CubeMove script;
    public TMP_InputField SpawnrateInput, DistanceInput, SpeedInput;

    void Start()
    {
        Invoke("CreateCube", System.Convert.ToSingle(SpawnrateInput.text) / 1000);
    }
    void CreateCube()
    {
        if (SpawnrateInput.text == "") { SpawnrateInput.text = "0"; }
        script = Cube.GetComponentInChildren<CubeMove>();
        script.Speed =  System.Convert.ToSingle(SpeedInput.text);
        script.Distance =  System.Convert.ToSingle(DistanceInput.text);
        GameObject cube = Instantiate(Cube, CubeSpawnerObject.transform.position, Quaternion.identity, CubeSpawnerObject.transform);
        Invoke("CreateCube", System.Convert.ToSingle(SpawnrateInput.text) / 1000);
    }
}
