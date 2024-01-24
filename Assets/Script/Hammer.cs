using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    [SerializeField]Animation anim;
    CapsuleCollider capsule;
    private AudioSource sound01;

    // Update is called once per frame

    void Start()
    {
        //anim = GetComponent<Animation>();
        capsule = GetComponent<CapsuleCollider>();
        sound01 = GetComponent<AudioSource>();

        capsule.enabled = false;
        anim.Play("Normal_Hammer");
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            //print("swing");
            anim.Play("Swing_Hammer");
            sound01.PlayOneShot(sound01.clip);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnHitHammer");
    }

    public void SwingStart()
    {
        capsule.enabled = true;
    }

    public void SwingEnd()
    {
        anim.Play("Normal_Hammer");
        capsule.enabled = false;
    }
}
