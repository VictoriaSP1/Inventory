using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    interface ICRUD <Entity>
    {
        List<Entity> ItemList();

        void CreateItem(Entity obj);

        void UpdateItem(Entity obj);

        void DeleteItem(Entity obj);
    }
}
