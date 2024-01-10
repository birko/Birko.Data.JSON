﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birko.Data.Repositories
{
    public abstract class AbstractJsonRepository<TViewModel, TModel, TStore> : AbstractStoreRepository<TViewModel, TModel>
        where TModel:Models.AbstractModel, Models.ILoadable<TViewModel>
        where TViewModel:Models.ILoadable<TModel>
        where TStore : Stores.AbstractJsonStore<TModel>
    {
        public AbstractJsonRepository() : base()
        {

        }
    }
}
