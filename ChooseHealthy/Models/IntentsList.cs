﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChooseHealthy.Models.Common;

namespace ChooseHealthy.Models
{
    public class IntentsList : List<KeyValuePair<string,Func<CommonModel, CommonModel>>>
    {
        public void Add(string intentName, Func<CommonModel, CommonModel> function)
        {
            var intent = this.FirstOrDefault(i => i.Key.ToLower() == intentName.ToLower());
            if (string.IsNullOrWhiteSpace(intent.Key))
            {
                Add(new KeyValuePair<string, Func<CommonModel, CommonModel>>(intentName, function));
            }
        }
    }
}