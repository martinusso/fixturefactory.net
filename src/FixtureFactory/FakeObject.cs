using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FixtureFactory
{
    public class FakeObject
    {
        private Type type;
        
        public FakeObject(Type t)
        {
            this.type = t;
        }

        public object GetFake()
        {
            var fake = Activator.CreateInstance(type);
            AssignFields(fake);
            AssignProperties(fake);
            
            return fake;
        }

        private void AssignFields(object obj) 
        {
            var fields = obj.GetType().GetFields();
            for (int i = 0; i < fields.Length; i++)
            {
                var fieldInfo = fields[i];
                var f = type.GetField(fieldInfo.Name);
                var value = GetValueFor(fieldInfo.FieldType);
                f.SetValue(obj, value);
            }
        }

        private void AssignProperties(object obj) 
        {
            var properties = obj.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                var propInfo = properties[i];
                var f = type.GetProperty(propInfo.Name);
                var value = GetValueFor(propInfo.PropertyType);
                f.SetValue(obj, value);
            }
        }

        private object GetValueFor(Type t)
        {
            var generator = new GeneratorValues();
            return generator.GetValue(t);
        }
    }
}
