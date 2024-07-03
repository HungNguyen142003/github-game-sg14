using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Junk", menuName = "ScriptableObjects/Junk")]//tao menu khi click chuot phai
public class JunkSO : ScriptableObject
{
    public string junkName = "Junk";
    public int hpMax = 2;
}
