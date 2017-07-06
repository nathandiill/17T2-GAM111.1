using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public AudioClip[] EventSounds;
    public AudioSource SFXChannel;

    // To call when boost audio is needed
    public void speedBoostAudio()
    {
        AudioClip speedBoost = EventSounds[0];
        SFXChannel.PlayOneShot(speedBoost);
    }

    // To call when bouncy wall audio is needed
    public void bounceWallAudio()
    {
        AudioClip bouncyWall = EventSounds[1];
        SFXChannel.PlayOneShot(bouncyWall);
    }

    // To call when enemy audio is needed
    public void enemyAudio()
    {
        AudioClip enemy = EventSounds[2];
        SFXChannel.PlayOneShot(enemy);
    }

    // To call when jump pad audio is needed
    public void jumpPadAudio()
    {
        AudioClip jumpPad = EventSounds[3];
        SFXChannel.PlayOneShot(jumpPad);
    }

    // To call when loss audio is needed
    public void lossAudio()
    {
        AudioClip loss = EventSounds[4];
        SFXChannel.PlayOneShot(loss);
    }

    // To call when next level audio is needed
    public void nextLevelAudio()
    {
        AudioClip nextLevel = EventSounds[5];
        SFXChannel.PlayOneShot(nextLevel);
    }

    // To call when player jump audio is needed
    public void playerJumpAudio()
    {
        AudioClip playerJump = EventSounds[6];
        SFXChannel.PlayOneShot(playerJump);
    }

    // To call when point pickup audio is needed
    public void pointPickUpAudio()
    {
        AudioClip pointPickUp = EventSounds[7];
        SFXChannel.PlayOneShot(pointPickUp);
    }

    // To call when slow pad audio is needed
    public void slowPadAudio()
    {
        AudioClip slowPad = EventSounds[8];
        SFXChannel.PlayOneShot(slowPad);
    }

    // To call when time pickup audio is needed
    public void timePickUpAudio()
    {
        AudioClip timePickUp = EventSounds[9];
        SFXChannel.PlayOneShot(timePickUp);
    }

    // To call when solid wall audio is needed
    public void solidWallAudio()
    {
        AudioClip solidWall = EventSounds[10];
        SFXChannel.PlayOneShot(solidWall);
    }

    // To call when victory audio is needed
    public void victoryAudio()
    {
        AudioClip victory = EventSounds[11];
        SFXChannel.PlayOneShot(victory);
    }
}
