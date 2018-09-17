using System.Collections;
using System.Collections.Generic;

namespace IonDotnet.Internals.Lite
{
    internal abstract class IonSequenceLite : IonContainerLite, IIonSequence
    {
        protected IonSequenceLite(ContainerlessContext containerlessContext, bool isNull) : base(containerlessContext, isNull)
        {
        }

        protected IonSequenceLite(IonContainerLite existing, IContext context, bool isStruct) : base(existing, context, isStruct)
        {
        }

        public int IndexOf(IIonValue item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, IIonValue item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public IIonValue this[int index]
        {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public IIonValue Get(int index)
        {
            throw new System.NotImplementedException();
        }

        public bool Add(IIonValue child)
        {
            throw new System.NotImplementedException();
        }

        public IValueFactory Add()
        {
            throw new System.NotImplementedException();
        }

        public void Add(int index, IIonValue child)
        {
            throw new System.NotImplementedException();
        }

        public IValueFactory Add(int index)
        {
            throw new System.NotImplementedException();
        }

        public IIonValue Set(int index, IIonValue element)
        {
            throw new System.NotImplementedException();
        }

        public IIonValue Remove(int index)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(object o)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveAll(ICollection c)
        {
            throw new System.NotImplementedException();
        }

        public bool RetainAll(ICollection c)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(object o)
        {
            throw new System.NotImplementedException();
        }

        public bool ContainsAll(ICollection c)
        {
            throw new System.NotImplementedException();
        }

        public int IndexOf(object o)
        {
            throw new System.NotImplementedException();
        }

        public int LastIndexOf(object o)
        {
            throw new System.NotImplementedException();
        }

        public bool AddAll(ICollection<IIonValue> c)
        {
            throw new System.NotImplementedException();
        }

        public bool AddAll(int index, ICollection<IIonValue> c)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<IIonValue> ListIterator(int index)
        {
            throw new System.NotImplementedException();
        }

        public List<IIonValue> SubList(int @from, int to)
        {
            throw new System.NotImplementedException();
        }

        public IIonValue[] ToArray()
        {
            throw new System.NotImplementedException();
        }
    }
}
