﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Language
    {
        DAL_Language dalLanguage = new DAL_Language();
        public DataTable getLanguage()
        {
            return dalLanguage.getLanguage();
        }
    }
}
