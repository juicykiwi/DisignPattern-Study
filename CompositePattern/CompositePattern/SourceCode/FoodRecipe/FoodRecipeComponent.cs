using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class FoodRecipeComponent
    {
        protected List<FoodRecipeComponent> _componentList = new List<FoodRecipeComponent>();

        public void Add(FoodRecipeComponent component)
        {
            if (component == null)
                return;

            _componentList.Add(component);
        }

        public void Remove(FoodRecipeComponent component)
        {
            if (component == null)
                return;

            _componentList.Remove(component);
        }

        public FoodRecipeComponent GetChild(int index)
        {
            if (index < 0)
                return null;

            if (_componentList.Count <= index)
                return null;

            return _componentList[index];
        }

        public abstract void Print();

        public List<FoodRecipeComponent>.Enumerator GetListEnumerator()
        {
            return _componentList.GetEnumerator();
        }
    }
}

