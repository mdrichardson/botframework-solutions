﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Luis;

namespace EventSkill.Models
{
    public class EventSkillState
    {
        public string Token { get; set; }

        public EventLuis LuisResult { get; set; }

        public void Clear()
        {
        }
    }
}