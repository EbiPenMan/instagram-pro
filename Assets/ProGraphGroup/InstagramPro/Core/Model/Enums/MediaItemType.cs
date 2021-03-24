
using System.Collections.Generic;

namespace ProGraphGroup.InstagramPro.Core.Model.Enums
{

public sealed class MediaItemType
{
	public static readonly MediaItemType MEDIA_TYPE_IMAGE = new MediaItemType("MEDIA_TYPE_IMAGE", InnerEnum.MEDIA_TYPE_IMAGE, 1);
	public static readonly MediaItemType MEDIA_TYPE_VIDEO = new MediaItemType("MEDIA_TYPE_VIDEO", InnerEnum.MEDIA_TYPE_VIDEO, 2);
	public static readonly MediaItemType MEDIA_TYPE_SLIDER = new MediaItemType("MEDIA_TYPE_SLIDER", InnerEnum.MEDIA_TYPE_SLIDER, 3);
	public static readonly MediaItemType MEDIA_TYPE_VOICE = new MediaItemType("MEDIA_TYPE_VOICE", InnerEnum.MEDIA_TYPE_VOICE, 4);
	public static readonly MediaItemType MEDIA_TYPE_LIVE = new MediaItemType("MEDIA_TYPE_LIVE", InnerEnum.MEDIA_TYPE_LIVE, 5);

	private static readonly List<MediaItemType> valueList = new List<MediaItemType>();

	public enum InnerEnum
	{
		MEDIA_TYPE_IMAGE,
		MEDIA_TYPE_VIDEO,
		MEDIA_TYPE_SLIDER,
		MEDIA_TYPE_VOICE,
		MEDIA_TYPE_LIVE
	}

	public readonly InnerEnum innerEnumValue;
	private readonly string nameValue;
	private readonly int ordinalValue;
	private static int nextOrdinal = 0;

	private readonly int id;
	private static readonly IDictionary<int, MediaItemType> map = new Dictionary<int, MediaItemType>();

	static MediaItemType()
	{
		foreach (MediaItemType type in MediaItemType.values())
		{
			map[type.id] = type;
		}

		valueList.Add(MEDIA_TYPE_IMAGE);
		valueList.Add(MEDIA_TYPE_VIDEO);
		valueList.Add(MEDIA_TYPE_SLIDER);
		valueList.Add(MEDIA_TYPE_VOICE);
		valueList.Add(MEDIA_TYPE_LIVE);
	}

	internal MediaItemType(string name, InnerEnum innerEnum, in int id)
	{
		this.id = id;

		nameValue = name;
		ordinalValue = nextOrdinal++;
		innerEnumValue = innerEnum;
	}

	public int Id
	{
		get
		{
			return id;
		}
	}

	public static MediaItemType valueOf(in int id)
	{
		return map[id];
	}

	public static MediaItemType[] values()
	{
		return valueList.ToArray();
	}

	public int ordinal()
	{
		return ordinalValue;
	}

	public override string ToString()
	{
		return nameValue;
	}
}

}