﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories
{
    interface IGetObject<T> where T : class
    {
        T GetObject(int? id);
    }
}
