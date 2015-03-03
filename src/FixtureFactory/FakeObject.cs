using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FixtureFactory
{
    public class FakeObject
    {
        private Type _type;
        
        public FakeObject(Type t)
        {
            this._type = t;
        }

        public object GetFake()
        {
            var fake = Activator.CreateInstance(_type);
            AssignFields(fake);
            AssignProperties(fake);
            
            return fake;
        }

        private void AssignFields(object obj) 
        {
            foreach (var f in obj.GetType().GetFields())
            {
                var fieldType = f.FieldType;
                if (fieldType.IsPrimitive
                    || fieldType == typeof(string)
                    || fieldType == typeof(DateTime))
                {
                    var value = GetValueFor(fieldType);
                    f.SetValue(obj, value);
                }
                else
                {
                    var child = new FakeObject(fieldType).GetFake();
                    f.SetValue(obj, child);
                }
            }
        }

        private void AssignProperties(object obj) 
        {
            foreach (var p in obj.GetType().GetProperties())
            {
                var propType = p.PropertyType;
                if (propType.IsPrimitive
                    || propType == typeof(string)
                    || propType == typeof(DateTime))
                {
                    var value = GetValueFor(propType);
                    p.SetValue(obj, value);
                }
                else if (propType.IsEnum)
                {
                    var values = Enum.GetValues(propType);
                    var randomEnum = values.GetValue(new Random().Next(values.Length));
                    p.SetValue(obj, randomEnum, null);
                }
                else
                {
                    if (p.CanWrite)
                    {
                        var child = new FakeObject(propType).GetFake();
                        p.SetValue(obj, child);
                    }
                }
            }
        }

        private object GetValueFor(Type t)
        {
            var generator = new GeneratorValues();
            return generator.GetValue(t);
        }
    }
}
