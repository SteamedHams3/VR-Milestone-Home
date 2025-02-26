using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
  public GameObject cube;

  public void InstantiateCube()
  {
    Instantiate(cube, new Vector3(0, 2, 2), Quaternion.identity);
  }
}
