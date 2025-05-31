using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    public float lane1X;
    public float lane2X;
    public float lane3X;
    public float lane4X;

    [SerializeField] Note notePrefab;
    // Start is called before the first frame update
    public void SpawnNote1()
    {
        Instantiate(notePrefab, new Vector3(-lane1X, 60, 0), Quaternion.identity);
    }
    public void SpawnNote2()
    {
        Instantiate(notePrefab, new Vector3(-lane2X, 60, 0), Quaternion.identity);
    }
    public void SpawnNote3()
    {
        Instantiate(notePrefab, new Vector3(lane3X, 60, 0), Quaternion.identity);
    }
    public void SpawnNote4()
    {
        Instantiate(notePrefab, new Vector3(lane4X, 60, 0), Quaternion.identity);
    }
}
