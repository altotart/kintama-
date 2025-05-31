using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteEvent : MonoBehaviour
{
    [SerializeField] NoteGenerator noteGenerator = default;
    public void Note1()
    {
        noteGenerator.SpawnNote1();
    }
    public void Note2()
    {
        noteGenerator.SpawnNote2();
    }
    public void Note3()
    {
        noteGenerator.SpawnNote3();
    }
    public void Note4()
    {
        noteGenerator.SpawnNote4();
    }
}
