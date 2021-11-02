﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCards.Models
{
    public class CardDAL
    {
        public CardModel GetData()
        {
            string key = "huvcludux6us";
            string url = $"https://deckofcardsapi.com/api/deck/{key}/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            CardModel result = JsonConvert.DeserializeObject<CardModel>(JSON);

            return result;
        }
    }
}
