using System;
using System.Collections.Generic;

namespace FixtureFactory
{
    public class FixtureFactory
    {
        private static Dictionary<Type, FakeObject> warehouse = new Dictionary<Type, FakeObject>();

        public static FakeObject Make(Type t)
        {
            if (!warehouse.ContainsKey(t))
            {
                warehouse.Add(t, new FakeObject(t));
            }

            return warehouse[t];
        }

        public static FakeObject From(Type type)
        {
            return Make(type);
        }

        public static T GetFakeOf<T>()
        {
            var fake = Make(typeof(T));
            return (T)fake.GetFake();
        }
    }
}