﻿using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface IYetenek : IAdd<Yetenekler>, IDelete<Yetenekler>, IUpdate<Yetenekler>, IGetObject<Yetenekler>, IGetObjects<Yetenekler>, ISave
    {
    }
}
