﻿using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
namespace AudioManager
{
    public class Pig : Animal
    {
        public override void AnimalSoud()
        {
            AudioFileReader audioFile = new AudioFileReader("Resource/pig.wav");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();
            while (waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }
            waveOutEvent.Dispose();
            audioFile.Dispose();

        }
    }
}
