using UnityEngine;
using System.Collections;

public class GameFinish : MonoBehaviour {

    public GameObject resultpoint;

	void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == resultpoint)
        {
            Application.LoadLevel("Result");

        }
    }
}
