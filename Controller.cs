using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Characterbase characterbase;
    public KeyCode[] key3D;
    public KeyCode[] key2D;
    
    public void SetKeyDefault()
    {
        //Key 3D
        key3D[0] = KeyCode.W;
        key3D[1] = KeyCode.S;
        key3D[2] = KeyCode.D;
        key3D[3] = KeyCode.A;
        key3D[4] = KeyCode.Space;

        //Key 2D
        key2D[0] = KeyCode.RightArrow;
        key2D[1] = KeyCode.LeftArrow;
        key2D[2] = KeyCode.DownArrow;
        key2D[3] = KeyCode.UpArrow;
    }

    public void GetController3D(Transform aim, float speed, float jumpSpeed)
    {
        //Forward
        if(Input.GetKey(key3D[0]) || Input.GetKeyDown(key3D[0]))
        {
            characterbase.Move3D(aim,"Forward", speed);
        }

        //Back
        if (Input.GetKey(key3D[1]) || Input.GetKeyDown(key3D[1]))
        {
            characterbase.Move3D(aim, "Back", speed);
        }

        //Right
        if (Input.GetKey(key3D[2]) || Input.GetKeyDown(key3D[2]))
        {
            characterbase.Move3D(aim, "Right", speed);
        }

        //Left
        if(Input.GetKey(key3D[3]) || Input.GetKeyDown(key3D[3]))
        {
            characterbase.Move3D(aim, "Left", speed);
        }

        //Jump
        if (Input.GetKey(key3D[4]) || Input.GetKeyDown(key3D[4]))
        {
            characterbase.Move3D(aim, "Jump", speed, jumpSpeed);
        }
    }

    public void GetController2D(Transform aim, float speed, float jumpSpeed)
    {
        //Forward
        if (Input.GetKey(key2D[0]) || Input.GetKeyDown(key2D[0]))
        {
            characterbase.Move2D(aim, "Forward", speed);
        }

        //Back
        if (Input.GetKey(key2D[1]) || Input.GetKeyDown(key2D[1]))
        {
            characterbase.Move2D(aim, "Back", speed);
        }

        //Duck
        if (Input.GetKey(key2D[2]) || Input.GetKeyDown(key2D[2]))
        {
            characterbase.Move2D(aim, "Duck", speed);
        }

        //Jump
        if (Input.GetKey(key2D[3]) || Input.GetKeyDown(key2D[3]))
        {
            characterbase.Move2D(aim, "Jump", speed, jumpSpeed);
        }
    }
}
