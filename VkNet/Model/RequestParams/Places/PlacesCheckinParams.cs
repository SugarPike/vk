﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkNet.Model.RequestParams
{
	/// <summary>
	/// Параметры запроса places.checkin
	/// </summary>
	public class PlacesCheckinParams
	{
		/// <summary>
		/// Комментарий к отметке длиной до 255 символов (переводы строк не поддерживаются). 
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Список сервисов или сайтов, на которые необходимо экспортировать отметку, в случае если пользователь настроил соответствующую опцию. Например twitter, facebook. 
		/// </summary>
		[JsonProperty("services")]
		public IEnumerable<string> Services { get; set; }

		/// <summary>
		/// Идентификатор места.
		/// </summary>
		[JsonProperty("place_id")]
		public ulong PlaceId { get; set; }

		/// <summary>
		/// Географическая широта отметки, заданная в градусах (от -90 до 90). 
		/// </summary>
		[JsonProperty("latitude")]
		public decimal Latitude { get; set; }

		/// <summary>
		/// Географическая долгота отметки, заданная в градусах (от -180 до 180). 
		/// </summary>
		[JsonProperty("longitude")]
		public decimal Longitude { get; set; }

		/// <summary>
		/// 1 — отметка будет доступна только друзьям, 0 — отметка будет доступна всем пользователям. По умолчанию 0. 
		/// </summary>
		[JsonProperty("friends_only")]
		public bool FriendsOnly { get; set; }
	}
}