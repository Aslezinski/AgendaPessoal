﻿using Agenda.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.DAL
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private readonly Context context;

        private Singleton()
        {
            context = new Context();
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public Context Context
        {
            get
            {
                return context;
            }
        }
    }
}

