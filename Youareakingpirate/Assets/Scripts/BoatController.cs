using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatController : MonoBehaviour
{
    [Header("STATE (no manual change)")]
    public BoatState currentState;

#pragma warning disable 0649
    [Header("SPEED PARAMETERS")]
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;
#pragma warning restore 0649

    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        switch (currentState)
        {
            case BoatState.noGameplay:
                break;
            case BoatState.gameplay:
                //Add limit to rotation depending of current heading
                if (Input.GetButton("Right"))
                {
                    transform.Rotate(0, rotationSpeed, 0);
                }
                if (Input.GetButton("Left"))
                {
                    transform.Rotate(0, -rotationSpeed, 0);
                }
                rigid.AddForce(transform.forward * speed);
                break;
        }
        //DEBUG
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //ENUM

    public enum BoatState
    {
        noGameplay, gameplay
    }
}
