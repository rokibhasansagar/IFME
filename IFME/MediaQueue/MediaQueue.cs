﻿using System.ComponentModel;
using System.Collections.Generic;

public enum MediaContainer
{
	AVI,
	MPEG,
	MP4,
	MKV,
	WEBM,
	IVF,
	MP2,
	MP3,
	M4A,
	OGG,
	OPUS,
	FLAC
}

namespace IFME
{
	public class MediaQueue
    {
		public bool Enable { get; set; }
		public string FilePath { get; set; }
		public bool HardSub { get; set; }
		public MediaContainer OutputFormat { get; set; }
		public MediaQueueTrim Trim { get; set; } = new MediaQueueTrim();
		public List<MediaQueueAudio> Audio { get; set; } = new List<MediaQueueAudio>();
		public List<MediaQueueVideo> Video { get; set; } = new List<MediaQueueVideo>();
		public List<MediaQueueSubtitle> Subtitle { get; set; } = new List<MediaQueueSubtitle>();
		public List<MediaQueueAttachment> Attachment { get; set; } = new List<MediaQueueAttachment>();
	}

	public partial class MediaQueueCommon
	{
		public bool Enable { get; set; }
		public int Id { get; set; }
		public float Duration { get; set; }
		public string Lang { get; set; }
		public string File { get; set; }
		public string Codec { get; set; }
	}

	public class MediaQueueTrim
	{
		public bool Enable { get; set; } = false;
		public string Start { get; set; } = "00:00:00";
		public string End { get; set; } = "00:00:00";
		public string Duration { get; set; } = "00:00:00";
	}
}