using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{
    public bool PlayTimeline = false;
    public PlayableDirector triggerTimeline;

    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerTimeline.Play();
    }
}