﻿using System.Collections.Generic;

namespace Sitecore.DatabaseSync.Models
{
    public interface IDatabaseSyncChangesProvider
    {
        List<ItemChange> GetItems();
    }
}
