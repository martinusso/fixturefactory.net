using System;
using System.Collections.Generic;

namespace FixtureFactory
{
    public class FixtureFactory
    {
        protected static Dictionary<Type, FakeObject> _warehouse = new Dictionary<Type, FakeObject>();

        public static FakeObject Make(Type t)
        {
            if (!_warehouse.ContainsKey(t))
            {
                _warehouse.Add(t, new FakeObject(t));
            }

            return _warehouse[t];
        }

        public static T GetFakeOf<T>()
        {
            var fake = Make(typeof(T));
            return (T)fake.GetFake();
        }
    }
}