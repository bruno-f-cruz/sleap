﻿using OpenCV.Net;
using System.Collections.ObjectModel;

namespace Bonsai.Sleap
{
    public class Pose : KeyedCollection<string, BodyPart>
    {
        public Pose(IplImage image)
        {
            Image = image;
        }

        public IplImage Image { get; }

        public BodyPart Centroid { get; set; }

        protected override string GetKeyForItem(BodyPart item)
        {
            return item.Name;
        }
    }

    public class BodyPart
    {
        public string Name { get; set; }
        public Point2f Position { get; set; }
        public float Confidence { get; set; }
    }
}
