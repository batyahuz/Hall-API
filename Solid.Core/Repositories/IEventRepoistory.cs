﻿using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IEventRepoistory
    {
        IEnumerable<Event> GetEvents();
        Event GetEventById(int id);
        void AddEvent(Event e);
        void UpdateEventById(int id, Event e);
        void DeleteEventById(int id);
    }
}
