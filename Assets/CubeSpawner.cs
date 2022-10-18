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
        try
        {
            script = Cube.GetComponentInChildren<CubeMove>();
            script.Speed = System.Convert.ToSingle(SpeedInput.text);
            script.Distance = System.Convert.ToSingle(DistanceInput.text);
            Instantiate(Cube, CubeSpawnerObject.transform.position, Quaternion.identity, CubeSpawnerObject.transform);
            Invoke("CreateCube", System.Convert.ToSingle(SpawnrateInput.text) / 1000);

        }
        catch
        {
            Debug.Log("bug");
            Invoke("CreateCube", 0.1f);
        }
    }
}
