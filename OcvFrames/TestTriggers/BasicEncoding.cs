﻿using System.IO;
using NUnit.Framework;

namespace OcvFrames.TestTriggers
{
    [TestFixture]
    public class BasicEncoding
    {
        [Test]
        public void create_a_basic_movie_file()
        {
            const string path = "video_out.mp4";

            const int width = 800;
            const int height = 450;
            const int fps = 60;

            using var subject = new VideoFileSynthesiser(path, width, height, fps);
            subject.WriteVideo(new SimpleTestGen());

            Assert.That(File.Exists(path), "file was not written");
        }
    }
}