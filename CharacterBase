using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterbase : MonoBehaviour
{
    /*This line is responsible to Character attributes and status*/
    public float GetDamage(float damage, float criticalRangeMin = 0, float criticalRangeMax = 10)
    {
        byte isCritical = (byte)Random.Range(0, 1);
        float criticalDamage;

        if (isCritical == 1)
        {
            criticalDamage = Random.Range(criticalRangeMin, criticalRangeMax);
        }
        else
        {
            criticalDamage = 0;
        }

        return damage + criticalDamage;
    }

    public bool IsDead(float aimHealth)
    {
        if(aimHealth <= 0)
        {
            return true;
        }
        return false;
    }

    public float GetCure(float healing)
    {
        return healing;
    }

    /*This line is responsible to movement and positions of Character*/
    public void Move3D(Transform aim, string direction, float speed = 5, float jumpSpeed = 5)
    {
        //Forward
        if (direction == "Forward")
        {
            aim.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        //Back
        if (direction == "Back")
        {
            aim.Translate(Vector3.back * Time.deltaTime * speed);
        }

        //Right
        if (direction == "Right")
        {
            aim.Translate(Vector3.right * Time.deltaTime * speed);
        }

        //Left
        if (direction == "Left")
        {
            aim.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //Jump
        if(direction == "Jump")
        {
            aim.Translate(Vector3.up * Time.deltaTime * jumpSpeed);
        }
    }

    public void Move2D(Transform aim, string direction, float speed = 5, float jumpSpeed = 5)
    {
        //Forward
        if(direction == "Forward")
        {
            aim.Translate(Vector2.right * Time.deltaTime * speed);
        }

        //Back
        if (direction == "Back")
        {
            aim.Translate(Vector2.left * Time.deltaTime * speed);
        }

        //Duck
        if (direction == "Duck")
        {
            aim.Translate(Vector2.down * Time.deltaTime * speed);
        }

        //Jump
        if (direction == "Jump")
        {
            aim.Translate(Vector3.up * Time.deltaTime * jumpSpeed);
        }
    }

    //Detect objects
    public bool GetViewObjects(GameObject own, GameObject objectScene, float getMaxAngle = 30, float getMaxDist = 5)
    {
        if(objectScene != null)
        {
            Vector3 getObjectDist = objectScene.transform.position - own.transform.position;
            float getObjectAngle = Vector3.Angle(own.transform.forward, getObjectDist);

            if(getObjectAngle < getMaxAngle && getObjectDist.z <= getMaxDist)
            {
                return true;
            }
        }

        return false;
    }

    public GameObject GetObjectInFront(GameObject botAim, GameObject objView, float getMaxAngle = 30, float getMaxDist = 5)
    {
        if (GetViewObjects(gameObject, objView, getMaxAngle, getMaxDist))
        {
            return objView;
        }

        return null;
    }

    public string GetObjTag(GameObject aim, GameObject objView, string tagObj)
    {
        if (GetObjectInFront(aim, objView).tag == tagObj)
        {
            return tag;
        }

        return "";
    }

    public bool IsSameTagObject(GameObject aim, GameObject objView, string tagObj)
    {
        if (GetObjectInFront(aim, objView).tag == tagObj)
        {
            return false;
        }

        return true;
    }
}