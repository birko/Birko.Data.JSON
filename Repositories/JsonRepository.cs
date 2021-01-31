﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birko.Data.Repositories
{
    public abstract class JsonRepository<TViewModel, TModel> : AbstractJsonSeparateRepository<TViewModel, TModel, Stores.JsonStore<TModel>>
        where TModel:Models.AbstractModel, Models.ILoadable<TViewModel>
        where TViewModel:Models.ILoadable<TModel>
    {
        public JsonRepository() : base()
        {

        }
    }
}
