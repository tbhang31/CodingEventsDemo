﻿using CodingEventsDemo.Models;
using System;
using System.Collections.Generic;

namespace CodingEventsDemo.Controllers.Data
{
    public class EventData
    {
        // store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        //retrieve events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //retrieve a single event
        public static Event GetById(int id)
        {
            return Events[id];
        }


        //remove an event from the collection 


    }
}
