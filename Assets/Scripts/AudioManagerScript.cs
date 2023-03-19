using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManagerScript : MonoBehaviour
{
    private FMOD.Studio.Bus groupSfx;
    private FMOD.Studio.Bus groupMsc;

    private FMOD.Studio.EventInstance ambienceInstance;
    private FMOD.Studio.EventInstance moveLampShadeInstance;
    private FMOD.Studio.EventInstance restartFanInstance;
    private FMOD.Studio.EventInstance turnKnobInstance;
    private FMOD.Studio.EventInstance musicInstance; 

    void Start()
    {
        groupSfx = FMODUnity.RuntimeManager.GetBus("bus:/GroupSfx");
        groupMsc = FMODUnity.RuntimeManager.GetBus("bus:/GroupMsc");
 
        ambienceInstance = FMODUnity.RuntimeManager.CreateInstance("event:/sfx/ambience");
        moveLampShadeInstance = FMODUnity.RuntimeManager.CreateInstance("event:/sfx/moveLampShade");
        restartFanInstance = FMODUnity.RuntimeManager.CreateInstance("event:/sfx/restartFan");
        turnKnobInstance = FMODUnity.RuntimeManager.CreateInstance("event:/sfx/turnKnob");
        musicInstance = FMODUnity.RuntimeManager.CreateInstance("event:/msc");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySfx("alert");
        }
    }

    public void MuteSfx()
    {
        groupSfx.setVolume(0);
    }

    public void UnMuteSfx()
    {
        groupSfx.setVolume(1);
    }

    public void MuteMusic()
    {
        groupMsc.setVolume(0);
    }

    public void UnMuteMusic()
    {
        groupMsc.setVolume(1);
    }

    public void StartAmbience()
    {
        if (IsPlaying(ambienceInstance) == false)
        {
            ambienceInstance.start();
        }
    }

    public void StopAmbience()
    {
        if (IsPlaying(ambienceInstance) == true)
        {
            ambienceInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }

    public void StartMoveLampShade()
    {
        moveLampShadeInstance.setParameterByName("endMoveLampShade", 0);

        if (IsPlaying(moveLampShadeInstance) == false)
        {
            moveLampShadeInstance.start();
        }
    }

    public void StopMoveLampShade()
    {
        moveLampShadeInstance.setParameterByName("endMoveLampShade", 1);
    }

    public void StartRestartFan()
    {
        restartFanInstance.setParameterByName("endRestartFan", 0);

        if (IsPlaying(restartFanInstance) == false)
        {
            restartFanInstance.start();
        }
    }

    public void StopRestartFan()
    {
        restartFanInstance.setParameterByName("endRestartFan", 1);
    }

    public void StartTurnKnob()
    {
        if (IsPlaying(turnKnobInstance) == false)
        {
            turnKnobInstance.start();
        }
    }

    public void StopTurnKnob()
    {
        if (IsPlaying(turnKnobInstance) == true)
        {
            turnKnobInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }

    public void PlaySfx(string name)
    {
        /*
        All Sfx:

        alert
        codeInput
        error
        insectEscaped
        keyboardInput
        lightSwitch
        passwordCorrect
        UIExit
        UIHover
        UISelect
        weldingSystem
        */

        FMODUnity.RuntimeManager.PlayOneShot("event:/sfx/" + name);
    }

    public void StartMenuMusic()
    {
        if (IsPlaying(musicInstance) == false)
        {
            musicInstance.start();
        }
        else
        {
            musicInstance.setParameterByName("musicSystem", 0);
        }
    }

    public void StartMainMusic()
    {
        if (IsPlaying(musicInstance) == true)
        {
            musicInstance.setParameterByName("musicSystem", 1);
        }
        else
        {
            musicInstance.setParameterByName("musicSystem", 1);
            musicInstance.start();
        }
    }

    public static bool IsPlaying(FMOD.Studio.EventInstance instance)
    {
        FMOD.Studio.PLAYBACK_STATE state;
        instance.getPlaybackState(out state);
        return state != FMOD.Studio.PLAYBACK_STATE.STOPPED;
    }
}
